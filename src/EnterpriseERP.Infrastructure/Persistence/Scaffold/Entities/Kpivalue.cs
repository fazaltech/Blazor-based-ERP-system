using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class Kpivalue
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long Kpiid { get; set; }

    public long PeriodId { get; set; }

    public decimal ActualValue { get; set; }

    public decimal? TargetValue { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ManagementKpi Kpi { get; set; } = null!;

    public virtual AccountingPeriod Period { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
