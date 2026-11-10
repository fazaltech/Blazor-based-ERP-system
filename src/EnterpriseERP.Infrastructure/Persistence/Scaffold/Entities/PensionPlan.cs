using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class PensionPlan
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public decimal EmployerRate { get; set; }

    public decimal EmployeeRate { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<EmployeePension> EmployeePensions { get; set; } = new List<EmployeePension>();

    public virtual Tenant Tenant { get; set; } = null!;
}
