using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class Apinvoice
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long SupplierId { get; set; }

    public long? PurchaseOrderId { get; set; }

    public string InvoiceNo { get; set; } = null!;

    public DateOnly InvoiceDate { get; set; }

    public DateOnly DueDate { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public decimal ExchangeRate { get; set; }

    public decimal Subtotal { get; set; }

    public decimal TaxAmount { get; set; }

    public decimal Total { get; set; }

    public string Status { get; set; } = null!;

    public long? JournalEntryId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<ApinvoiceLine> ApinvoiceLines { get; set; } = new List<ApinvoiceLine>();

    public virtual ICollection<AppaymentAllocation> AppaymentAllocations { get; set; } = new List<AppaymentAllocation>();

    public virtual JournalEntry? JournalEntry { get; set; }

    public virtual PurchaseOrder? PurchaseOrder { get; set; }

    public virtual Supplier Supplier { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
