using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class Opportunity
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long? LeadId { get; set; }

    public long? CustomerId { get; set; }

    public string Name { get; set; } = null!;

    public string Stage { get; set; } = null!;

    public decimal ExpectedValue { get; set; }

    public decimal ProbabilityPercent { get; set; }

    public DateOnly? ExpectedCloseDate { get; set; }

    public long? OwnerEmployeeId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Lead? Lead { get; set; }

    public virtual ICollection<OpportunityActivity> OpportunityActivities { get; set; } = new List<OpportunityActivity>();

    public virtual Employee? OwnerEmployee { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;
}
