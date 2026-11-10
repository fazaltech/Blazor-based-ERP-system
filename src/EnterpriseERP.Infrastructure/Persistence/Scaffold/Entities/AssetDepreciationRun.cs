using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class AssetDepreciationRun
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long PeriodId { get; set; }

    public DateOnly RunDate { get; set; }

    public string Status { get; set; } = null!;

    public long? JournalEntryId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<AssetDepreciationLine> AssetDepreciationLines { get; set; } = new List<AssetDepreciationLine>();

    public virtual JournalEntry? JournalEntry { get; set; }

    public virtual AccountingPeriod Period { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
