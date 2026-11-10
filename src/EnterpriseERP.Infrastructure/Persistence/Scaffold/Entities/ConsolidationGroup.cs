using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class ConsolidationGroup
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public string Name { get; set; } = null!;

    public string ReportingCurrency { get; set; } = null!;

    public long? ParentGroupId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<ConsolidationMember> ConsolidationMembers { get; set; } = new List<ConsolidationMember>();

    public virtual ICollection<ConsolidationRun> ConsolidationRuns { get; set; } = new List<ConsolidationRun>();

    public virtual ICollection<ConsolidationGroup> InverseParentGroup { get; set; } = new List<ConsolidationGroup>();

    public virtual ConsolidationGroup? ParentGroup { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;
}
