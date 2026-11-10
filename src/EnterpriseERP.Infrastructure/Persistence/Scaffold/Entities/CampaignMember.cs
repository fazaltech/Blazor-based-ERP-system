using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class CampaignMember
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long CampaignId { get; set; }

    public long? LeadId { get; set; }

    public long? CustomerId { get; set; }

    public string ResponseStatus { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual MarketingCampaign Campaign { get; set; } = null!;

    public virtual Customer? Customer { get; set; }

    public virtual Lead? Lead { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;
}
