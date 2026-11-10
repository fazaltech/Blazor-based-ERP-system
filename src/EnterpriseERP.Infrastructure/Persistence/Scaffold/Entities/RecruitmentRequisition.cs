using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class RecruitmentRequisition
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long PositionId { get; set; }

    public long? RequestedByEmployeeId { get; set; }

    public int Openings { get; set; }

    public string Status { get; set; } = null!;

    public DateOnly OpenedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<JobApplication> JobApplications { get; set; } = new List<JobApplication>();

    public virtual JobPosition Position { get; set; } = null!;

    public virtual Employee? RequestedByEmployee { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;
}
