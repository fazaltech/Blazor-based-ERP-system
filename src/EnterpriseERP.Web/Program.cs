using EnterpriseERP.Infrastructure;
using EnterpriseERP.Infrastructure.Identity;
using EnterpriseERP.Web;
using EnterpriseERP.Web.Components;
using Microsoft.AspNetCore.Authorization;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddAuthorization(options =>
{
    options.FallbackPolicy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
    options.AddPolicy("SuperAdminOnly", policy => policy.RequireRole("SuperAdmin"));
    options.AddPolicy("UserDirectoryView", policy => policy.RequireAuthenticatedUser().RequireAssertion(c => c.User.IsInRole("SuperAdmin") || c.User.HasClaim("permission", "platform.users.view")));
    foreach (var role in new[] { "TenantAdmin", "CompanyAdmin", "BranchManager", "DepartmentManager", "Employee" })
        options.AddPolicy(role + "Only", policy => policy.RequireRole(role));
});
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddRazorComponents().AddInteractiveServerComponents();

var app = builder.Build();
if (args.Contains("--bootstrap-superadmin", StringComparer.Ordinal))
{
    await using var scope = app.Services.CreateAsyncScope();
    try
    {
        await scope.ServiceProvider.GetRequiredService<IdentityDataSeeder>().SeedAsync();
        Console.WriteLine("Bootstrap administrator and platform role verified.");
    }
    catch (Exception ex)
    {
        Console.Error.WriteLine($"Bootstrap failed: {ex.Message}");
        Environment.ExitCode = 1;
    }
    return;
}

if (!app.Environment.IsDevelopment()) app.UseExceptionHandler("/Error", createScopeForErrors: true);
app.UseAuthentication();
app.UseAuthorization();
app.UseAntiforgery();
app.MapStaticAssets().AllowAnonymous();
app.MapAccountEndpoints();
app.MapUserEndpoints();
app.MapRazorComponents<App>().AddInteractiveServerRenderMode();
app.Run();

public partial class Program;
