using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class IntegrationEndpoint
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public string Code { get; set; } = null!;

    public string Provider { get; set; } = null!;

    public string BaseUrl { get; set; } = null!;

    public string? AuthSecretReference { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<IntegrationMessage> IntegrationMessages { get; set; } = new List<IntegrationMessage>();

    public virtual Tenant Tenant { get; set; } = null!;
}
