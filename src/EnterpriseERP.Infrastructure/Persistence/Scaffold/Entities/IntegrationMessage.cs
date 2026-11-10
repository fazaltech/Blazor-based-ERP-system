using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class IntegrationMessage
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long EndpointId { get; set; }

    public string Direction { get; set; } = null!;

    public string? ExternalId { get; set; }

    public string EntityType { get; set; } = null!;

    public long? EntityId { get; set; }

    public string PayloadJson { get; set; } = null!;

    public string Status { get; set; } = null!;

    public int AttemptCount { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual IntegrationEndpoint Endpoint { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
