using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class AcademicProgram
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long CampusId { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string ProgramLevel { get; set; } = null!;

    public int DurationTerms { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Admission> Admissions { get; set; } = new List<Admission>();

    public virtual Campus Campus { get; set; } = null!;

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    public virtual ICollection<FeeStructure> FeeStructures { get; set; } = new List<FeeStructure>();

    public virtual Tenant Tenant { get; set; } = null!;
}
