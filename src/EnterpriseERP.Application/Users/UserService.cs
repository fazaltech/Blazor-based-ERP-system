using System.Security.Claims;
using System.ComponentModel.DataAnnotations;
namespace EnterpriseERP.Application.Users;
public record UserRow(long Id, string Email, string Name, bool Active, string Roles = "", string Permissions = "");
public interface IUserRepository
{
    Task<string?> Register(string email, string name, string password);
    Task<IReadOnlyList<UserRow>> List();
    Task<string?> Manage(long id, string action, string value);
}
public class UserService(IUserRepository repository)
{
    public Task<string?> Register(string email, string name, string password)
    {
        if (!new EmailAddressAttribute().IsValid(email) || email.Length > 254 || string.IsNullOrWhiteSpace(name) || name.Length > 160)
            return Task.FromResult<string?>("Enter a valid email and name (maximum 160 characters).");
        return repository.Register(email.Trim(), name.Trim(), password);
    }
    public Task<IReadOnlyList<UserRow>> List(ClaimsPrincipal actor) {
        if (actor.Identity?.IsAuthenticated != true || (!actor.IsInRole("SuperAdmin") && !actor.HasClaim("permission", "platform.users.view"))) throw new UnauthorizedAccessException();
        return repository.List();
    }
    public Task<string?> Manage(ClaimsPrincipal actor, long id, string action, string value)
    { RequireAdmin(actor); return repository.Manage(id, action, value); }
    private static void RequireAdmin(ClaimsPrincipal actor)
    { if (actor.Identity?.IsAuthenticated != true || !actor.IsInRole("SuperAdmin")) throw new UnauthorizedAccessException(); }
}
