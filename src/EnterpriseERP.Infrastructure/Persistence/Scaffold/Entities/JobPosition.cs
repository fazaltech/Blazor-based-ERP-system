using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class JobPosition
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long DepartmentId { get; set; }

    public string Code { get; set; } = null!;

    public string Title { get; set; } = null!;

    public long? GradeId { get; set; }

    public long? ReportsToPositionId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Department Department { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual PayGrade? Grade { get; set; }

    public virtual ICollection<JobPosition> InverseReportsToPosition { get; set; } = new List<JobPosition>();

    public virtual ICollection<RecruitmentRequisition> RecruitmentRequisitions { get; set; } = new List<RecruitmentRequisition>();

    public virtual JobPosition? ReportsToPosition { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;
}
