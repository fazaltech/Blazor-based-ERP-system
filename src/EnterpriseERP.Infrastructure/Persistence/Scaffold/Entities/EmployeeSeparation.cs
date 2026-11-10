using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class EmployeeSeparation
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long EmployeeId { get; set; }

    public string SeparationType { get; set; } = null!;

    public DateOnly NoticeDate { get; set; }

    public DateOnly LastWorkingDate { get; set; }

    public decimal FinalSettlement { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Employee Employee { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
