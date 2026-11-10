using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EnterpriseERP.Infrastructure.Identity;

public class ApplicationIdentityDbContext(DbContextOptions<ApplicationIdentityDbContext> options)
    : IdentityDbContext<ApplicationUser, ApplicationRole, long>(options)
{
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.HasDefaultSchema("erp_core");
        builder.Entity<ApplicationUser>(b =>
        {
            // The ERP context owns the original table. Identity's migration only adds its own columns.
            b.ToTable("Users", "erp_core", t => t.ExcludeFromMigrations());
            b.Property(x => x.Email).HasMaxLength(254).IsRequired();
            b.Property(x => x.PasswordHash).HasMaxLength(500);
            b.Property(x => x.DisplayName).HasMaxLength(160).IsRequired();
            b.Property(x => x.LastLoginAt).HasColumnType("timestamp(3) without time zone");
            b.HasIndex(x => x.NormalizedUserName).IsUnique().HasDatabaseName("UX_IdentityUsers_NormalizedUserName");
            b.HasIndex(x => x.NormalizedEmail).HasDatabaseName("IX_IdentityUsers_NormalizedEmail");
        });
        builder.Entity<ApplicationRole>().ToTable("PlatformRoles", "erp_core");
        builder.Entity<IdentityUserRole<long>>().ToTable("PlatformUserRoles", "erp_core");
        builder.Entity<IdentityUserClaim<long>>().ToTable("IdentityUserClaims", "erp_core");
        builder.Entity<IdentityUserLogin<long>>().ToTable("IdentityUserLogins", "erp_core");
        builder.Entity<IdentityUserToken<long>>().ToTable("IdentityUserTokens", "erp_core");
        builder.Entity<IdentityRoleClaim<long>>().ToTable("PlatformRoleClaims", "erp_core");
    }
}
