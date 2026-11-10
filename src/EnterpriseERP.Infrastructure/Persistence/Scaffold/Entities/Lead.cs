using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class Lead
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public string FullName { get; set; } = null!;

    public string? CompanyName { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Source { get; set; }

    public string Status { get; set; } = null!;

    public long? OwnerEmployeeId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<CampaignMember> CampaignMembers { get; set; } = new List<CampaignMember>();

    public virtual ICollection<Opportunity> Opportunities { get; set; } = new List<Opportunity>();

    public virtual Employee? OwnerEmployee { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;
}
