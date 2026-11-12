using EnterpriseERP.Application.Users;
using Microsoft.AspNetCore.Antiforgery;
namespace EnterpriseERP.Web;
public static class UserEndpoints
{
    public static void MapUserEndpoints(this WebApplication app)
    {
        app.MapPost("/account/register/submit", async (HttpContext context, IAntiforgery csrf, UserService service) =>
        {
            try { await csrf.ValidateRequestAsync(context); } catch (AntiforgeryValidationException) { return Results.BadRequest(); }
            var form = await context.Request.ReadFormAsync();
            var error = form["Password"] != form["ConfirmPassword"] ? "Passwords do not match." :
                await service.Register(form["Email"].ToString(), form["Name"].ToString(), form["Password"].ToString());
            return Results.LocalRedirect("/account/register?message=" + Uri.EscapeDataString(error ?? "Account created. Contact your administrator for activation."));
        }).AllowAnonymous();
        app.MapPost("/users/manage", async (HttpContext context, IAntiforgery csrf, UserService service) =>
        {
            try { await csrf.ValidateRequestAsync(context); } catch (AntiforgeryValidationException) { return Results.BadRequest(); }
            var form = await context.Request.ReadFormAsync();
            if (!long.TryParse(form["Id"], out var id)) return Results.BadRequest();
            var action = form["Action"].ToString();
            var value = action.Contains("permission") ? form["Permission"] : action.Contains("role") ? form["Role"] : form["Value"];
            var error = await service.Manage(context.User, id, action, value.ToString());
            return Results.LocalRedirect("/users?message=" + Uri.EscapeDataString(error ?? "Changes saved. Existing sessions were invalidated."));
        }).RequireAuthorization("SuperAdminOnly");
    }
}
