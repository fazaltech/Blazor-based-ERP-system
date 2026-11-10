using Microsoft.AspNetCore.Identity;

namespace EnterpriseERP.Infrastructure.Identity;

public class ApplicationUser : IdentityUser<long>
{
    public string DisplayName { get; set; } = string.Empty;
    public bool IsActive { get; set; }
    public bool IdentityEnabled { get; set; }
    public bool IsBootstrapAdmin { get; set; }
    public DateTime? LastLoginAt { get; set; }
}
