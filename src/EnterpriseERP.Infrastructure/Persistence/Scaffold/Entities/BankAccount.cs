using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class BankAccount
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long LegalEntityId { get; set; }

    public long GlaccountId { get; set; }

    public string BankName { get; set; } = null!;

    public string AccountName { get; set; } = null!;

    public string AccountNumberMasked { get; set; } = null!;

    public string? Iban { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Appayment> Appayments { get; set; } = new List<Appayment>();

    public virtual ICollection<Arreceipt> Arreceipts { get; set; } = new List<Arreceipt>();

    public virtual ICollection<BankReconciliation> BankReconciliations { get; set; } = new List<BankReconciliation>();

    public virtual ICollection<BankTransaction> BankTransactions { get; set; } = new List<BankTransaction>();

    public virtual Glaccount Glaccount { get; set; } = null!;

    public virtual LegalEntity LegalEntity { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
