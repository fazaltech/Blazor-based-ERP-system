using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class ConsolidationMember
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long GroupId { get; set; }

    public long LegalEntityId { get; set; }

    public decimal OwnershipPercent { get; set; }

    public DateOnly EffectiveFrom { get; set; }

    public DateOnly? EffectiveTo { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ConsolidationGroup Group { get; set; } = null!;

    public virtual LegalEntity LegalEntity { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
