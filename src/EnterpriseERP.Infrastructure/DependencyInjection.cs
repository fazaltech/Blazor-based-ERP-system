using EnterpriseERP.Infrastructure.Persistence.Scaffold;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using EnterpriseERP.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;

namespace EnterpriseERP.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContextFactory<ERPDbContext>(options =>
        {
            var connection = configuration.GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException("Configure ConnectionStrings:DefaultConnection using user secrets or an environment variable.");
            options.UseNpgsql(connection, npgsql => npgsql.MigrationsAssembly(typeof(ERPDbContext).Assembly.FullName));
        });
        services.AddDbContext<ApplicationIdentityDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException("Configure ConnectionStrings:DefaultConnection."),
                npgsql => npgsql.MigrationsHistoryTable("__IdentityMigrationsHistory", "erp_core")));
        services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
        {
            options.Password.RequiredLength = 8;
            options.Password.RequireDigit = true;
            options.Password.RequireLowercase = true;
            options.Password.RequireUppercase = true;
            options.Password.RequireNonAlphanumeric = true;
            options.Lockout.MaxFailedAccessAttempts = 5;
            options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(15);
            options.Lockout.AllowedForNewUsers = true;
            options.User.RequireUniqueEmail = true;
        }).AddEntityFrameworkStores<ApplicationIdentityDbContext>().AddDefaultTokenProviders();
        services.AddScoped<IdentityDataSeeder>();
        services.ConfigureApplicationCookie(options =>
        {
            options.LoginPath = "/account/login";
            options.LogoutPath = "/account/logout";
            options.AccessDeniedPath = "/account/access-denied";
            options.Cookie.HttpOnly = true;
            options.Cookie.SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Lax;
            options.Cookie.SecurePolicy = Microsoft.AspNetCore.Http.CookieSecurePolicy.SameAsRequest;
            options.ExpireTimeSpan = TimeSpan.FromHours(8);
            options.SlidingExpiration = true;
            options.Events.OnValidatePrincipal = async context =>
            {
                var signIn = context.HttpContext.RequestServices.GetRequiredService<SignInManager<ApplicationUser>>();
                var user = context.Principal is null ? null : await signIn.ValidateSecurityStampAsync(context.Principal);
                if (user is null || !user.IsActive || !user.IdentityEnabled)
                {
                    context.RejectPrincipal();
                    await signIn.SignOutAsync();
                }
            };
        });
        return services;
    }
}
