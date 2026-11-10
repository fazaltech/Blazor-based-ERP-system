using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class SelfServiceRequest
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long PortalAccountId { get; set; }

    public string RequestType { get; set; } = null!;

    public string PayloadJson { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime SubmittedAt { get; set; }

    public DateTime? ResolvedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual PortalAccount PortalAccount { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
