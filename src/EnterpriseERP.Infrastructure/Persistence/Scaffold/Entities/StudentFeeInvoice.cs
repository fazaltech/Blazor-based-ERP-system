using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class StudentFeeInvoice
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long StudentId { get; set; }

    public long TermId { get; set; }

    public long? ArinvoiceId { get; set; }

    public string InvoiceNo { get; set; } = null!;

    public DateOnly DueDate { get; set; }

    public decimal Total { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Arinvoice? Arinvoice { get; set; }

    public virtual Student Student { get; set; } = null!;

    public virtual ICollection<StudentFeePayment> StudentFeePayments { get; set; } = new List<StudentFeePayment>();

    public virtual Tenant Tenant { get; set; } = null!;

    public virtual AcademicTerm Term { get; set; } = null!;
}
