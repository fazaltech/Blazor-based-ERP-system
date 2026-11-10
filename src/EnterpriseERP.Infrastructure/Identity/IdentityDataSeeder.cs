using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EnterpriseERP.Infrastructure.Identity;

public class IdentityDataSeeder(ApplicationIdentityDbContext db, UserManager<ApplicationUser> users,
    RoleManager<ApplicationRole> roles, IConfiguration configuration)
{
    public async Task SeedAsync(CancellationToken cancellationToken = default)
    {
        var email = configuration["IdentitySeed:SuperAdminEmail"]?.Trim();
        var fullName = configuration["IdentitySeed:SuperAdminFullName"]?.Trim();
        var password = configuration["IdentitySeed:SuperAdminPassword"];
        if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(fullName) || string.IsNullOrEmpty(password))
            throw new InvalidOperationException("Set the bootstrap email, full name, and password before running bootstrap.");

        await using var transaction = await db.Database.BeginTransactionAsync(cancellationToken);
        // Serialize bootstrap runs, including when there are not yet any rows to lock.
        await db.Database.ExecuteSqlRawAsync("SELECT pg_advisory_xact_lock(68114052581934)", cancellationToken);
        var normalizedEmail = users.NormalizeEmail(email);
        var marked = await db.Users.Where(u => u.IsBootstrapAdmin).ToListAsync(cancellationToken);
        if (marked.Count > 1 || (marked.Count == 1 && marked[0].NormalizedEmail != normalizedEmail))
            throw new InvalidOperationException("A different bootstrap administrator already exists; refusing to create another.");
        var user = marked.SingleOrDefault();
        if (user is null)
        {
            // Never turn an existing ERP user into an administrator based on email alone.
            if (await db.Users.AnyAsync(u => u.Email!.ToUpper() == normalizedEmail, cancellationToken))
                throw new InvalidOperationException("The configured email belongs to an existing user; refusing to elevate it.");
            user = new ApplicationUser { UserName = email, Email = email, DisplayName = fullName,
                IsActive = true, IdentityEnabled = true, IsBootstrapAdmin = true, EmailConfirmed = true };
            Check(await users.CreateAsync(user, password));
        }
        else if (!user.IsActive || !user.IdentityEnabled)
            throw new InvalidOperationException("The bootstrap administrator is disabled; refusing to change its status.");

        var role = await roles.FindByNameAsync("SuperAdmin");
        if (role is null)
        {
            role = new ApplicationRole { Name = "SuperAdmin", Description = "ERP Platform Super Administrator", IsSystemRole = true };
            Check(await roles.CreateAsync(role));
        }
        else if (!role.IsSystemRole)
            throw new InvalidOperationException("The existing SuperAdmin platform role is not a system role; refusing to assign it.");
        if (!await users.IsInRoleAsync(user, "SuperAdmin")) Check(await users.AddToRoleAsync(user, "SuperAdmin"));
        await transaction.CommitAsync(cancellationToken);
    }

    private static void Check(IdentityResult result)
    {
        if (!result.Succeeded)
            throw new InvalidOperationException("Identity bootstrap failed: " + string.Join("; ", result.Errors.Select(e => e.Description)));
    }
}
