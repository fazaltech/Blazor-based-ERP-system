using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class ProjectBilling
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long ProjectId { get; set; }

    public long? MilestoneId { get; set; }

    public long? ArinvoiceId { get; set; }

    public DateOnly BillingDate { get; set; }

    public decimal BillableAmount { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Arinvoice? Arinvoice { get; set; }

    public virtual ProjectMilestone? Milestone { get; set; }

    public virtual Project Project { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
