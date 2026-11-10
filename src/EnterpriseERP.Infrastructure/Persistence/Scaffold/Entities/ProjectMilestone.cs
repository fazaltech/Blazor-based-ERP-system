using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class ProjectMilestone
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long ProjectId { get; set; }

    public string Name { get; set; } = null!;

    public DateOnly DueDate { get; set; }

    public DateOnly? CompletedDate { get; set; }

    public decimal? BillingAmount { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Project Project { get; set; } = null!;

    public virtual ICollection<ProjectBilling> ProjectBillings { get; set; } = new List<ProjectBilling>();

    public virtual Tenant Tenant { get; set; } = null!;
}
