using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class Appayment
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long SupplierId { get; set; }

    public long BankAccountId { get; set; }

    public string PaymentNo { get; set; } = null!;

    public DateOnly PaymentDate { get; set; }

    public decimal Amount { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public string Status { get; set; } = null!;

    public long? JournalEntryId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<AppaymentAllocation> AppaymentAllocations { get; set; } = new List<AppaymentAllocation>();

    public virtual BankAccount BankAccount { get; set; } = null!;

    public virtual JournalEntry? JournalEntry { get; set; }

    public virtual Supplier Supplier { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
