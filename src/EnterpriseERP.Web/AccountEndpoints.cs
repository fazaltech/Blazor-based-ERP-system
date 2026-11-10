using EnterpriseERP.Infrastructure.Identity;
using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Identity;

namespace EnterpriseERP.Web;

public static class AccountEndpoints
{
    public static void MapAccountEndpoints(this WebApplication app)
    {
        app.MapPost("/account/login/submit", async (HttpContext context, IAntiforgery antiforgery,
            UserManager<ApplicationUser> users, SignInManager<ApplicationUser> signIn) =>
        {
            try { await antiforgery.ValidateRequestAsync(context); }
            catch (AntiforgeryValidationException) { return Results.BadRequest(); }
            var form = await context.Request.ReadFormAsync();
            var email = form["Email"].ToString().Trim();
            var password = form["Password"].ToString();
            var returnUrl = SafeReturnUrl(form["ReturnUrl"].ToString());
            var user = string.IsNullOrWhiteSpace(email) ? null : await users.FindByEmailAsync(email);
            if (user is not null && user.IsActive && user.IdentityEnabled)
            {
                var result = await signIn.PasswordSignInAsync(user, password,
                    form["RememberMe"] == "true", lockoutOnFailure: true);
                if (result.Succeeded)
                {
                    user.LastLoginAt = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Unspecified);
                    await users.UpdateAsync(user);
                    return Results.LocalRedirect(returnUrl);
                }
            }
            return Results.LocalRedirect("/account/login?error=1&returnUrl=" + Uri.EscapeDataString(returnUrl));
        }).AllowAnonymous();

        app.MapPost("/account/logout", async (HttpContext context, IAntiforgery antiforgery,
            SignInManager<ApplicationUser> signIn) =>
        {
            try { await antiforgery.ValidateRequestAsync(context); }
            catch (AntiforgeryValidationException) { return Results.BadRequest(); }
            await signIn.SignOutAsync();
            return Results.LocalRedirect("/account/login");
        }).RequireAuthorization();
    }

    public static string SafeReturnUrl(string? url) =>
        !string.IsNullOrEmpty(url) && url[0] == '/' && (url.Length == 1 || (url[1] != '/' && url[1] != '\\'))
        && !url.Any(char.IsControl) ? url : "/dashboard";
}
