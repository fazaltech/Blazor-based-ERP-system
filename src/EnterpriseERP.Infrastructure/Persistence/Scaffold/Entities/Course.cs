using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class Course
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long ProgramId { get; set; }

    public string Code { get; set; } = null!;

    public string Title { get; set; } = null!;

    public decimal CreditHours { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<ClassSection> ClassSections { get; set; } = new List<ClassSection>();

    public virtual AcademicProgram Program { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
