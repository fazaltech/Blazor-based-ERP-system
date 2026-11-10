using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class ProjectWb
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long ProjectId { get; set; }

    public long? ParentWbsid { get; set; }

    public string Wbscode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public decimal BudgetAmount { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<ProjectWb> InverseParentWbs { get; set; } = new List<ProjectWb>();

    public virtual ProjectWb? ParentWbs { get; set; }

    public virtual Project Project { get; set; } = null!;

    public virtual ICollection<ProjectTask> ProjectTasks { get; set; } = new List<ProjectTask>();

    public virtual Tenant Tenant { get; set; } = null!;
}
