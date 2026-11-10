using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class CostObject
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string CostObjectType { get; set; } = null!;

    public long? ProjectId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<ActivityDriverUsage> ActivityDriverUsages { get; set; } = new List<ActivityDriverUsage>();

    public virtual Project? Project { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;
}
