using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class JournalLine
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long EntryId { get; set; }

    public int LineNumber { get; set; }

    public long GlaccountId { get; set; }

    public long? CostCenterId { get; set; }

    public decimal Debit { get; set; }

    public decimal Credit { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public decimal ExchangeRate { get; set; }

    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<BankReconciliationLine> BankReconciliationLines { get; set; } = new List<BankReconciliationLine>();

    public virtual CostCenter? CostCenter { get; set; }

    public virtual JournalEntry Entry { get; set; } = null!;

    public virtual Glaccount Glaccount { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
