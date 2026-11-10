using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class ActivityDriverUsage
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long ActivityPoolId { get; set; }

    public long CostDriverId { get; set; }

    public long CostObjectId { get; set; }

    public long PeriodId { get; set; }

    public decimal DriverQuantity { get; set; }

    public decimal AllocatedCost { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ActivityPool ActivityPool { get; set; } = null!;

    public virtual CostDriver CostDriver { get; set; } = null!;

    public virtual CostObject CostObject { get; set; } = null!;

    public virtual AccountingPeriod Period { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
