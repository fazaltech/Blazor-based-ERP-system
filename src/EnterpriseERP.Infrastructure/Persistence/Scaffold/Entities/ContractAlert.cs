using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class ContractAlert
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long ContractId { get; set; }

    public long? MilestoneId { get; set; }

    public string AlertType { get; set; } = null!;

    public DateTime TriggerAt { get; set; }

    public DateTime? SentAt { get; set; }

    public long RecipientTenantUserId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Contract Contract { get; set; } = null!;

    public virtual ContractMilestone? Milestone { get; set; }

    public virtual TenantUser RecipientTenantUser { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
