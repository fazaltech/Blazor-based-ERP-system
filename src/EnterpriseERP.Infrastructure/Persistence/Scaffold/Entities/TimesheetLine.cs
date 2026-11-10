using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class TimesheetLine
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long TimesheetId { get; set; }

    public long ProjectTaskId { get; set; }

    public DateOnly WorkDate { get; set; }

    public decimal Hours { get; set; }

    public bool Billable { get; set; }

    public string? Notes { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ProjectTask ProjectTask { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;

    public virtual Timesheet Timesheet { get; set; } = null!;
}
