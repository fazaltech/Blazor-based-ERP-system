using EnterpriseERP.Application.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
namespace EnterpriseERP.Infrastructure.Identity;
public class UserRepository(UserManager<ApplicationUser> users, RoleManager<ApplicationRole> roles, ApplicationIdentityDbContext db) : IUserRepository
{
    public async Task<string?> Register(string email, string name, string password)
    {
        if (await db.Users.AnyAsync(u => u.Email!.ToUpper() == email.ToUpper())) return "Unable to register with these details.";
        var result = await users.CreateAsync(new ApplicationUser { Email = email, UserName = email, DisplayName = name, IdentityEnabled = true, IsActive = false }, password);
        return Error(result);
    }
    public async Task<IReadOnlyList<UserRow>> List()
    {
        var result = new List<UserRow>();
        foreach (var user in await db.Users.OrderBy(u => u.Id).Take(200).ToListAsync())
            result.Add(new UserRow(user.Id, user.Email!, user.DisplayName, user.IsActive,
                string.Join(", ", await users.GetRolesAsync(user)), string.Join(", ", (await users.GetClaimsAsync(user)).Where(c => c.Type == "permission").Select(c => c.Value))));
        return result;
    }
    public async Task<string?> Manage(long id, string action, string value)
    {
        var user = await users.FindByIdAsync(id.ToString());
        if (user is null || !user.IdentityEnabled) return "User is unavailable.";
        if (user.IsBootstrapAdmin) return "The bootstrap administrator cannot be changed here.";
        IdentityResult result;
        switch (action)
        {
            case "activate": user.IsActive = true; result = await users.UpdateAsync(user); break;
            case "disable": user.IsActive = false; result = await users.UpdateAsync(user); break;
            case "unlock": result = await users.SetLockoutEndDateAsync(user, null); if (result.Succeeded) result = await users.ResetAccessFailedCountAsync(user); break;
            case "reset": result = await users.ResetPasswordAsync(user, await users.GeneratePasswordResetTokenAsync(user), value); break;
            case "role":
            case "remove-role":
                if (!new[] { "TenantAdmin", "CompanyAdmin", "BranchManager", "DepartmentManager", "Employee" }.Contains(value)) return "Choose a supported role.";
                if (action == "role") {
                    if (!await roles.RoleExistsAsync(value)) { var created = await roles.CreateAsync(new ApplicationRole { Name = value }); if (!created.Succeeded) return Error(created); }
                    result = await users.AddToRoleAsync(user, value);
                } else result = await users.RemoveFromRoleAsync(user, value);
                break;
            case "permission":
            case "remove-permission":
                if (value != "platform.users.view") return "Choose a supported permission.";
                var claim = new Claim("permission", value);
                if (action == "permission" && (await users.GetClaimsAsync(user)).Any(c => c.Type == claim.Type && c.Value == claim.Value)) return null;
                result = action == "permission" ? await users.AddClaimAsync(user, claim) : await users.RemoveClaimAsync(user, claim); break;
            default: return "Unsupported action.";
        }
        if (result.Succeeded) result = await users.UpdateSecurityStampAsync(user);
        return Error(result);
    }
    private static string? Error(IdentityResult result) => result.Succeeded ? null : string.Join(" ", result.Errors.Select(e => e.Description));
}
