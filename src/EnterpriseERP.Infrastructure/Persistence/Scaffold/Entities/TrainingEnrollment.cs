using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class TrainingEnrollment
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long EmployeeId { get; set; }

    public long CourseId { get; set; }

    public DateOnly EnrolledAt { get; set; }

    public DateOnly? CompletedAt { get; set; }

    public string? Result { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual TrainingCourse Course { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
