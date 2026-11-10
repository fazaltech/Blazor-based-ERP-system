using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class ProductLifecycleChange
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long ItemId { get; set; }

    public long? RevisionId { get; set; }

    public string ChangeNo { get; set; } = null!;

    public string ChangeType { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string ApprovalStatus { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual EngineeringRevision? Revision { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;
}
