using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class OpportunityActivity
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long OpportunityId { get; set; }

    public long? EmployeeId { get; set; }

    public string ActivityType { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public DateTime? DueAt { get; set; }

    public DateTime? CompletedAt { get; set; }

    public string? Notes { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual Opportunity Opportunity { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
