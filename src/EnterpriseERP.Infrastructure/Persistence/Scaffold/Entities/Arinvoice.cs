using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class Arinvoice
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long CustomerId { get; set; }

    public long? SalesOrderId { get; set; }

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

    public virtual ICollection<ArinvoiceLine> ArinvoiceLines { get; set; } = new List<ArinvoiceLine>();

    public virtual ICollection<ArreceiptAllocation> ArreceiptAllocations { get; set; } = new List<ArreceiptAllocation>();

    public virtual Customer Customer { get; set; } = null!;

    public virtual JournalEntry? JournalEntry { get; set; }

    public virtual ICollection<ProjectBilling> ProjectBillings { get; set; } = new List<ProjectBilling>();

    public virtual SalesOrder? SalesOrder { get; set; }

    public virtual ICollection<StudentFeeInvoice> StudentFeeInvoices { get; set; } = new List<StudentFeeInvoice>();

    public virtual Tenant Tenant { get; set; } = null!;
}
