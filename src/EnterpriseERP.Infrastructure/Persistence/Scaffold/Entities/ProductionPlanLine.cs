using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class ProductionPlanLine
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long PlanId { get; set; }

    public long ItemId { get; set; }

    public decimal PlannedQty { get; set; }

    public DateOnly DueDate { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual ProductionPlan Plan { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
