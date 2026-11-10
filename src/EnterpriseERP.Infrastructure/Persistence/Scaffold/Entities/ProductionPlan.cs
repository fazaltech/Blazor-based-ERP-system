using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class ProductionPlan
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public string PlanNo { get; set; } = null!;

    public DateOnly PlanStart { get; set; }

    public DateOnly PlanEnd { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<ProductionPlanLine> ProductionPlanLines { get; set; } = new List<ProductionPlanLine>();

    public virtual Tenant Tenant { get; set; } = null!;
}
