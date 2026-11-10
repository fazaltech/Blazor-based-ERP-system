using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class JournalEntry
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long BatchId { get; set; }

    public string EntryNo { get; set; } = null!;

    public DateOnly EntryDate { get; set; }

    public string? Description { get; set; }

    public string? SourceType { get; set; }

    public long? SourceId { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? PostedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Apinvoice> Apinvoices { get; set; } = new List<Apinvoice>();

    public virtual ICollection<Appayment> Appayments { get; set; } = new List<Appayment>();

    public virtual ICollection<Arinvoice> Arinvoices { get; set; } = new List<Arinvoice>();

    public virtual ICollection<Arreceipt> Arreceipts { get; set; } = new List<Arreceipt>();

    public virtual ICollection<AssetDepreciationRun> AssetDepreciationRuns { get; set; } = new List<AssetDepreciationRun>();

    public virtual JournalBatch Batch { get; set; } = null!;

    public virtual ICollection<CostAllocation> CostAllocations { get; set; } = new List<CostAllocation>();

    public virtual ICollection<JournalLine> JournalLines { get; set; } = new List<JournalLine>();

    public virtual ICollection<PayrollRun> PayrollRuns { get; set; } = new List<PayrollRun>();

    public virtual Tenant Tenant { get; set; } = null!;
}
