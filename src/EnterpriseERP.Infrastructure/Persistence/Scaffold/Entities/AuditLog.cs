using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class AuditLog
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public string EntityType { get; set; } = null!;

    public long? EntityId { get; set; }

    public string Action { get; set; } = null!;

    public long? ActorTenantUserId { get; set; }

    public string? ChangesJson { get; set; }

    public DateTime OccurredAt { get; set; }

    public Guid? CorrelationId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual TenantUser? ActorTenantUser { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;
}
