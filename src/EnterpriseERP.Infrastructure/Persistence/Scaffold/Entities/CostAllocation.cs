using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class CostAllocation
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long PeriodId { get; set; }

    public long SourceCostCenterId { get; set; }

    public long DestinationCostCenterId { get; set; }

    public decimal Amount { get; set; }

    public string AllocationMethod { get; set; } = null!;

    public long? JournalEntryId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual CostCenter DestinationCostCenter { get; set; } = null!;

    public virtual JournalEntry? JournalEntry { get; set; }

    public virtual AccountingPeriod Period { get; set; } = null!;

    public virtual CostCenter SourceCostCenter { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
