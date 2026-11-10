using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class FeeStructure
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long ProgramId { get; set; }

    public long AcademicYearId { get; set; }

    public string FeeType { get; set; } = null!;

    public decimal Amount { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual AcademicYear AcademicYear { get; set; } = null!;

    public virtual AcademicProgram Program { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
