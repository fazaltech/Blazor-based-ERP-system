using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class Admission
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long StudentId { get; set; }

    public long ProgramId { get; set; }

    public long AcademicYearId { get; set; }

    public DateOnly ApplicationDate { get; set; }

    public string Decision { get; set; } = null!;

    public DateOnly? DecisionDate { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual AcademicYear AcademicYear { get; set; } = null!;

    public virtual AcademicProgram Program { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
