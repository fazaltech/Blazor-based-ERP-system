using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class ProjectTask
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long ProjectId { get; set; }

    public long? Wbsid { get; set; }

    public long? ParentTaskId { get; set; }

    public string Name { get; set; } = null!;

    public DateOnly? StartDate { get; set; }

    public DateOnly? DueDate { get; set; }

    public decimal EstimatedHours { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<ProjectTask> InverseParentTask { get; set; } = new List<ProjectTask>();

    public virtual ProjectTask? ParentTask { get; set; }

    public virtual Project Project { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;

    public virtual ICollection<TimesheetLine> TimesheetLines { get; set; } = new List<TimesheetLine>();

    public virtual ProjectWb? Wbs { get; set; }
}
