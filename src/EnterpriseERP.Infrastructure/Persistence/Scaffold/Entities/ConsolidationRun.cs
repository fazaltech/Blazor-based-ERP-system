using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class ConsolidationRun
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long GroupId { get; set; }

    public DateOnly PeriodEnd { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ConsolidationGroup Group { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
