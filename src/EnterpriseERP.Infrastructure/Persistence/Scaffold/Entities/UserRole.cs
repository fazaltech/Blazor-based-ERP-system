using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class UserRole
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long TenantUserId { get; set; }

    public long RoleId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Role Role { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;

    public virtual TenantUser TenantUser { get; set; } = null!;
}
