using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class JournalBatch
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long LegalEntityId { get; set; }

    public long PeriodId { get; set; }

    public string BatchNo { get; set; } = null!;

    public string Source { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime? PostedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<JournalEntry> JournalEntries { get; set; } = new List<JournalEntry>();

    public virtual LegalEntity LegalEntity { get; set; } = null!;

    public virtual AccountingPeriod Period { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
