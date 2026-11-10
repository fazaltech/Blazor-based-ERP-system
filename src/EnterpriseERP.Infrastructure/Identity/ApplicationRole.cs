using Microsoft.AspNetCore.Identity;

namespace EnterpriseERP.Infrastructure.Identity;

// Platform roles are distinct from the tenant-owned erp_core.Roles table.
public class ApplicationRole : IdentityRole<long>
{
    public string? Description { get; set; }
    public bool IsSystemRole { get; set; }
}
