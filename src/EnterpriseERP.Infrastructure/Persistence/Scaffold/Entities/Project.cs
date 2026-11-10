using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class Project
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public string ProjectCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public long? CustomerId { get; set; }

    public long? ManagerEmployeeId { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public decimal BudgetAmount { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<CostObject> CostObjects { get; set; } = new List<CostObject>();

    public virtual Customer? Customer { get; set; }

    public virtual Employee? ManagerEmployee { get; set; }

    public virtual ICollection<ProjectBilling> ProjectBillings { get; set; } = new List<ProjectBilling>();

    public virtual ICollection<ProjectExpense> ProjectExpenses { get; set; } = new List<ProjectExpense>();

    public virtual ICollection<ProjectMilestone> ProjectMilestones { get; set; } = new List<ProjectMilestone>();

    public virtual ICollection<ProjectResource> ProjectResources { get; set; } = new List<ProjectResource>();

    public virtual ICollection<ProjectRiskRegister> ProjectRiskRegisters { get; set; } = new List<ProjectRiskRegister>();

    public virtual ICollection<ProjectTask> ProjectTasks { get; set; } = new List<ProjectTask>();

    public virtual ICollection<ProjectWb> ProjectWbs { get; set; } = new List<ProjectWb>();

    public virtual Tenant Tenant { get; set; } = null!;
}
