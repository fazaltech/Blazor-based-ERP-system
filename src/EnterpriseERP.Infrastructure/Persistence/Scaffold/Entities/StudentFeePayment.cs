using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class StudentFeePayment
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long StudentFeeInvoiceId { get; set; }

    public long? ArreceiptId { get; set; }

    public DateOnly PaymentDate { get; set; }

    public decimal Amount { get; set; }

    public string Method { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Arreceipt? Arreceipt { get; set; }

    public virtual StudentFeeInvoice StudentFeeInvoice { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
