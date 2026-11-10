using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class AccountingPeriod
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long FiscalYearId { get; set; }

    public int PeriodNumber { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public bool IsClosed { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<ActivityDriverUsage> ActivityDriverUsages { get; set; } = new List<ActivityDriverUsage>();

    public virtual ICollection<AssetDepreciationRun> AssetDepreciationRuns { get; set; } = new List<AssetDepreciationRun>();

    public virtual ICollection<BudgetLine> BudgetLines { get; set; } = new List<BudgetLine>();

    public virtual ICollection<CostAllocation> CostAllocations { get; set; } = new List<CostAllocation>();

    public virtual FiscalYear FiscalYear { get; set; } = null!;

    public virtual ICollection<JournalBatch> JournalBatches { get; set; } = new List<JournalBatch>();

    public virtual ICollection<Kpivalue> Kpivalues { get; set; } = new List<Kpivalue>();

    public virtual Tenant Tenant { get; set; } = null!;
}
