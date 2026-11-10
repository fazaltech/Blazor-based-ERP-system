using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class PayrollPeriod
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public DateOnly PeriodStart { get; set; }

    public DateOnly PeriodEnd { get; set; }

    public DateOnly PayDate { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<PayrollRun> PayrollRuns { get; set; } = new List<PayrollRun>();

    public virtual Tenant Tenant { get; set; } = null!;
}
