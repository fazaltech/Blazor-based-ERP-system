using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class LeaveBalance
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long EmployeeId { get; set; }

    public long LeaveTypeId { get; set; }

    public long FiscalYearId { get; set; }

    public decimal OpeningDays { get; set; }

    public decimal AccruedDays { get; set; }

    public decimal UsedDays { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Employee Employee { get; set; } = null!;

    public virtual FiscalYear FiscalYear { get; set; } = null!;

    public virtual LeaveType LeaveType { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
