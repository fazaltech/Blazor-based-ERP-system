using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class ManagementKpi
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? FormulaJson { get; set; }

    public string Unit { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Kpivalue> Kpivalues { get; set; } = new List<Kpivalue>();

    public virtual Tenant Tenant { get; set; } = null!;
}
