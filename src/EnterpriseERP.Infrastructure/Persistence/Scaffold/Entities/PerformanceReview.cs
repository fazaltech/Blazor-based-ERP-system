using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class PerformanceReview
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long EmployeeId { get; set; }

    public long ReviewerEmployeeId { get; set; }

    public DateOnly ReviewPeriodStart { get; set; }

    public DateOnly ReviewPeriodEnd { get; set; }

    public decimal? Rating { get; set; }

    public string? Notes { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Employee Employee { get; set; } = null!;

    public virtual Employee ReviewerEmployee { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
