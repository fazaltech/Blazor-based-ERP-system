using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class AcademicTerm
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long AcademicYearId { get; set; }

    public string Code { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual AcademicYear AcademicYear { get; set; } = null!;

    public virtual ICollection<ClassSection> ClassSections { get; set; } = new List<ClassSection>();

    public virtual ICollection<StudentFeeInvoice> StudentFeeInvoices { get; set; } = new List<StudentFeeInvoice>();

    public virtual Tenant Tenant { get; set; } = null!;
}
