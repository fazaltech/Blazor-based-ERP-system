using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class Arreceipt
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long CustomerId { get; set; }

    public long BankAccountId { get; set; }

    public string ReceiptNo { get; set; } = null!;

    public DateOnly ReceiptDate { get; set; }

    public decimal Amount { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public string Status { get; set; } = null!;

    public long? JournalEntryId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<ArreceiptAllocation> ArreceiptAllocations { get; set; } = new List<ArreceiptAllocation>();

    public virtual BankAccount BankAccount { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;

    public virtual JournalEntry? JournalEntry { get; set; }

    public virtual ICollection<StudentFeePayment> StudentFeePayments { get; set; } = new List<StudentFeePayment>();

    public virtual Tenant Tenant { get; set; } = null!;
}
