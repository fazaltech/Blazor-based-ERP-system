using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class Department
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long? BranchId { get; set; }

    public long? ParentDepartmentId { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public long? CostCenterId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Branch? Branch { get; set; }

    public virtual CostCenter? CostCenter { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<Department> InverseParentDepartment { get; set; } = new List<Department>();

    public virtual ICollection<JobPosition> JobPositions { get; set; } = new List<JobPosition>();

    public virtual Department? ParentDepartment { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;

    public virtual ICollection<WorkCenter> WorkCenters { get; set; } = new List<WorkCenter>();
}
