using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class Student
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public string StudentNo { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateOnly? DateOfBirth { get; set; }

    public string? Email { get; set; }

    public long CampusId { get; set; }

    public DateOnly AdmissionDate { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Admission> Admissions { get; set; } = new List<Admission>();

    public virtual ICollection<AssessmentScore> AssessmentScores { get; set; } = new List<AssessmentScore>();

    public virtual Campus Campus { get; set; } = null!;

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    public virtual ICollection<PortalAccount> PortalAccounts { get; set; } = new List<PortalAccount>();

    public virtual ICollection<StudentAttendance> StudentAttendances { get; set; } = new List<StudentAttendance>();

    public virtual ICollection<StudentFeeInvoice> StudentFeeInvoices { get; set; } = new List<StudentFeeInvoice>();

    public virtual ICollection<StudentGuardian> StudentGuardians { get; set; } = new List<StudentGuardian>();

    public virtual Tenant Tenant { get; set; } = null!;
}
