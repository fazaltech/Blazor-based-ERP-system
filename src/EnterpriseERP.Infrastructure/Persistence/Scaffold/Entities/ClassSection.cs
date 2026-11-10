using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class ClassSection
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long CourseId { get; set; }

    public long TermId { get; set; }

    public string SectionCode { get; set; } = null!;

    public long? TeacherEmployeeId { get; set; }

    public int Capacity { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Assessment> Assessments { get; set; } = new List<Assessment>();

    public virtual ICollection<ClassSession> ClassSessions { get; set; } = new List<ClassSession>();

    public virtual Course Course { get; set; } = null!;

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    public virtual Employee? TeacherEmployee { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;

    public virtual AcademicTerm Term { get; set; } = null!;
}
