using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class Campus
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long? BranchId { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Address { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<AcademicProgram> AcademicPrograms { get; set; } = new List<AcademicProgram>();

    public virtual ICollection<AcademicYear> AcademicYears { get; set; } = new List<AcademicYear>();

    public virtual Branch? Branch { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    public virtual Tenant Tenant { get; set; } = null!;
}
