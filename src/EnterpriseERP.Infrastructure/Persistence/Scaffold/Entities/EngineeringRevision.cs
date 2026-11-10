using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class EngineeringRevision
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long ItemId { get; set; }

    public string RevisionCode { get; set; } = null!;

    public DateOnly EffectiveFrom { get; set; }

    public DateOnly? EffectiveTo { get; set; }

    public string Status { get; set; } = null!;

    public long? DrawingAttachmentId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Attachment? DrawingAttachment { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual ICollection<ProductLifecycleChange> ProductLifecycleChanges { get; set; } = new List<ProductLifecycleChange>();

    public virtual Tenant Tenant { get; set; } = null!;
}
