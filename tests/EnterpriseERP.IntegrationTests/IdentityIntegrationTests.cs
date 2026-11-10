using System.Net;
using System.Security.Claims;
using System.Text.RegularExpressions;
using EnterpriseERP.Infrastructure.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;

namespace EnterpriseERP.IntegrationTests;

public sealed class IdentityDatabaseFactAttribute : FactAttribute
{
    public IdentityDatabaseFactAttribute()
    {
        if (string.IsNullOrEmpty(Environment.GetEnvironmentVariable("ERP_IDENTITY_TEST_CONNECTION")) ||
            string.IsNullOrEmpty(Environment.GetEnvironmentVariable("ERP_IDENTITY_TEST_PASSWORD")))
            Skip = "Set ERP_IDENTITY_TEST_CONNECTION and ERP_IDENTITY_TEST_PASSWORD for the isolated test database.";
    }
}

[CollectionDefinition("Identity database", DisableParallelization = true)]
public class IdentityDatabaseCollection;

[Collection("Identity database")]
public class IdentityIntegrationTests
{
    private const string Email = "bootstrap@example.test";

    private static WebApplicationFactory<Program> CreateApp(string email = Email)
    {
        var connection = Environment.GetEnvironmentVariable("ERP_IDENTITY_TEST_CONNECTION")!;
        var database = new NpgsqlConnectionStringBuilder(connection).Database;
        if (database != "enterprise_erp_identity_test_20261110")
            throw new InvalidOperationException("Refusing to run Identity integration tests outside the designated test database.");
        return new WebApplicationFactory<Program>().WithWebHostBuilder(host => host.ConfigureAppConfiguration((_, config) =>
            config.AddInMemoryCollection(new Dictionary<string, string?>
            {
                ["ConnectionStrings:DefaultConnection"] = connection,
                ["IdentitySeed:SuperAdminEmail"] = email,
                ["IdentitySeed:SuperAdminFullName"] = "Test Bootstrap",
                ["IdentitySeed:SuperAdminPassword"] = Environment.GetEnvironmentVariable("ERP_IDENTITY_TEST_PASSWORD")
            })));
    }

    private static async Task EnsureBootstrap(WebApplicationFactory<Program> app)
    {
        await using var scope = app.Services.CreateAsyncScope();
        await scope.ServiceProvider.GetRequiredService<IdentityDataSeeder>().SeedAsync();
    }

    [IdentityDatabaseFact]
    public async Task BootstrapIsIdempotentAndPreservesLegacyUser()
    {
        using var app = CreateApp();
        await using var scope = app.Services.CreateAsyncScope();
        var seeder = scope.ServiceProvider.GetRequiredService<IdentityDataSeeder>();
        await seeder.SeedAsync();
        await seeder.SeedAsync();
        var db = scope.ServiceProvider.GetRequiredService<ApplicationIdentityDbContext>();
        var manager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
        var user = await manager.FindByEmailAsync(Email);
        Assert.NotNull(user);
        Assert.True(await manager.IsInRoleAsync(user, "SuperAdmin"));
        Assert.True(await manager.CheckPasswordAsync(user, Environment.GetEnvironmentVariable("ERP_IDENTITY_TEST_PASSWORD")!));
        Assert.Equal(1, await db.Users.CountAsync(x => x.IsBootstrapAdmin));
        var legacy = await db.Users.SingleAsync(x => x.Email == "legacy@example.test");
        Assert.Equal("legacy-hash-fixture", legacy.PasswordHash);
        Assert.False(legacy.IdentityEnabled);
    }

    [IdentityDatabaseFact]
    public async Task HttpLoginAndLogoutRequireAntiforgeryAndProtectDashboard()
    {
        using var app = CreateApp();
        await EnsureBootstrap(app);
        using var client = app.CreateClient(new WebApplicationFactoryClientOptions { AllowAutoRedirect = false });
        Assert.Equal(HttpStatusCode.Redirect, (await client.GetAsync("/dashboard")).StatusCode);
        var missingToken = await client.PostAsync("/account/login/submit", new FormUrlEncodedContent([]));
        Assert.True(missingToken.StatusCode == HttpStatusCode.BadRequest, $"Unexpected response {missingToken.StatusCode}: {missingToken.Headers.Location}");
        var login = await client.GetAsync("/account/login");
        var token = Token(await login.Content.ReadAsStringAsync());
        var response = await client.PostAsync("/account/login/submit", new FormUrlEncodedContent(new Dictionary<string, string>
        {
            ["__RequestVerificationToken"] = token, ["Email"] = Email,
            ["Password"] = Environment.GetEnvironmentVariable("ERP_IDENTITY_TEST_PASSWORD")!, ["ReturnUrl"] = "//example.com"
        }));
        Assert.Equal(HttpStatusCode.Redirect, response.StatusCode);
        Assert.Equal("/dashboard", response.Headers.Location?.OriginalString);
        var dashboard = await client.GetAsync("/dashboard");
        Assert.Equal(HttpStatusCode.OK, dashboard.StatusCode);
        var loginWhileAuthenticated = await client.GetAsync("/account/login");
        Assert.Equal(HttpStatusCode.Redirect, loginWhileAuthenticated.StatusCode);
        token = Token(await dashboard.Content.ReadAsStringAsync());
        Assert.Equal(HttpStatusCode.BadRequest, (await client.PostAsync("/account/logout", new FormUrlEncodedContent([]))).StatusCode);
        Assert.Equal(HttpStatusCode.Redirect, (await client.PostAsync("/account/logout", new FormUrlEncodedContent(new Dictionary<string, string> { ["__RequestVerificationToken"] = token }))).StatusCode);
        Assert.Equal(HttpStatusCode.Redirect, (await client.GetAsync("/dashboard")).StatusCode);
    }

    [IdentityDatabaseFact]
    public async Task RolesPasswordsAndLockoutAreEnforced()
    {
        using var app = CreateApp();
        await EnsureBootstrap(app);
        await using var scope = app.Services.CreateAsyncScope();
        var users = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
        var user = (await users.FindByEmailAsync(Email))!;
        Assert.False(await users.CheckPasswordAsync(user, "wrong-password"));
        await users.SetLockoutEndDateAsync(user, null);
        await users.ResetAccessFailedCountAsync(user);
        try
        {
            for (var i = 0; i < 5; i++) await users.AccessFailedAsync(user);
            Assert.True(await users.IsLockedOutAsync(user));
            var authorization = scope.ServiceProvider.GetRequiredService<IAuthorizationService>();
            var employee = new ClaimsPrincipal(new ClaimsIdentity([new Claim(ClaimTypes.Role, "Employee")], "test"));
            var admin = new ClaimsPrincipal(new ClaimsIdentity([new Claim(ClaimTypes.Role, "SuperAdmin")], "test"));
            Assert.False((await authorization.AuthorizeAsync(employee, "SuperAdminOnly")).Succeeded);
            Assert.True((await authorization.AuthorizeAsync(admin, "SuperAdminOnly")).Succeeded);
        }
        finally { await users.SetLockoutEndDateAsync(user, null); await users.ResetAccessFailedCountAsync(user); }
    }

    [IdentityDatabaseFact]
    public async Task BootstrapRejectsASecondAdministrator()
    {
        using var setup = CreateApp();
        await EnsureBootstrap(setup);
        using var app = CreateApp("different@example.test");
        await using var scope = app.Services.CreateAsyncScope();
        await Assert.ThrowsAsync<InvalidOperationException>(() => scope.ServiceProvider.GetRequiredService<IdentityDataSeeder>().SeedAsync());
    }

    [IdentityDatabaseFact]
    public async Task EmployeeCannotOpenSuperAdminPage()
    {
        using var app = CreateApp();
        await EnsureBootstrap(app);
        await using var scope = app.Services.CreateAsyncScope();
        var users = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
        var roles = scope.ServiceProvider.GetRequiredService<RoleManager<ApplicationRole>>();
        if (!await roles.RoleExistsAsync("Employee")) Assert.True((await roles.CreateAsync(new ApplicationRole { Name = "Employee" })).Succeeded);
        const string email = "employee@example.test";
        var user = await users.FindByEmailAsync(email);
        if (user is null)
        {
            user = new ApplicationUser { UserName = email, Email = email, DisplayName = "Test employee", IsActive = true, IdentityEnabled = true };
            Assert.True((await users.CreateAsync(user, Environment.GetEnvironmentVariable("ERP_IDENTITY_TEST_PASSWORD")!)).Succeeded);
            Assert.True((await users.AddToRoleAsync(user, "Employee")).Succeeded);
        }
        using var client = app.CreateClient(new WebApplicationFactoryClientOptions { AllowAutoRedirect = false });
        var page = await client.GetAsync("/account/login");
        var token = Token(await page.Content.ReadAsStringAsync());
        var login = await client.PostAsync("/account/login/submit", new FormUrlEncodedContent(new Dictionary<string, string>
        { ["__RequestVerificationToken"] = token, ["Email"] = email, ["Password"] = Environment.GetEnvironmentVariable("ERP_IDENTITY_TEST_PASSWORD")! }));
        Assert.Equal("/dashboard", login.Headers.Location?.OriginalString);
        var denied = await client.GetAsync("/platform/tenants");
        Assert.Equal(HttpStatusCode.Redirect, denied.StatusCode);
        Assert.Contains("/account/access-denied", denied.Headers.Location!.OriginalString);
    }

    [IdentityDatabaseFact]
    public async Task InactiveAndLockedUsersCannotSignIn()
    {
        using var app = CreateApp();
        await EnsureBootstrap(app);
        await using var scope = app.Services.CreateAsyncScope();
        var users = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
        var db = scope.ServiceProvider.GetRequiredService<ApplicationIdentityDbContext>();
        var user = (await users.FindByEmailAsync(Email))!;
        using var client = app.CreateClient(new WebApplicationFactoryClientOptions { AllowAutoRedirect = false });
        async Task<HttpResponseMessage> Login(string password)
        {
            var page = await client.GetAsync("/account/login");
            var token = Token(await page.Content.ReadAsStringAsync());
            return await client.PostAsync("/account/login/submit", new FormUrlEncodedContent(new Dictionary<string, string>
            { ["__RequestVerificationToken"] = token, ["Email"] = Email, ["Password"] = password }));
        }
        try
        {
            user.IsActive = false;
            Assert.True((await users.UpdateAsync(user)).Succeeded);
            var inactive = await Login(Environment.GetEnvironmentVariable("ERP_IDENTITY_TEST_PASSWORD")!);
            Assert.Contains("error=1", inactive.Headers.Location!.OriginalString);
            user.IsActive = true;
            Assert.True((await users.UpdateAsync(user)).Succeeded);
            await users.SetLockoutEndDateAsync(user, null);
            await users.ResetAccessFailedCountAsync(user);
            for (var i = 0; i < 5; i++) Assert.Contains("error=1", (await Login("wrong-password")).Headers.Location!.OriginalString);
            Assert.Contains("error=1", (await Login(Environment.GetEnvironmentVariable("ERP_IDENTITY_TEST_PASSWORD")!)).Headers.Location!.OriginalString);
            db.ChangeTracker.Clear();
            Assert.True(await users.IsLockedOutAsync((await users.FindByEmailAsync(Email))!));
        }
        finally
        {
            db.ChangeTracker.Clear();
            user = (await users.FindByEmailAsync(Email))!;
            user.IsActive = true;
            await users.UpdateAsync(user);
            await users.SetLockoutEndDateAsync(user, null);
            await users.ResetAccessFailedCountAsync(user);
        }
    }

    private static string Token(string html)
    {
        var match = Regex.Match(html, "name=\"__RequestVerificationToken\"[^>]*value=\"([^\"]+)\"");
        Assert.True(match.Success, "Antiforgery token was not rendered.");
        return WebUtility.HtmlDecode(match.Groups[1].Value);
    }
}
