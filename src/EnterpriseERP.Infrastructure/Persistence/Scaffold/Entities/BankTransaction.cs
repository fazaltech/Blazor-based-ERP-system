using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class BankTransaction
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long BankAccountId { get; set; }

    public string? ExternalReference { get; set; }

    public DateOnly TransactionDate { get; set; }

    public decimal Amount { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public string? Description { get; set; }

    public bool Reconciled { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual BankAccount BankAccount { get; set; } = null!;

    public virtual ICollection<BankReconciliationLine> BankReconciliationLines { get; set; } = new List<BankReconciliationLine>();

    public virtual Tenant Tenant { get; set; } = null!;
}
