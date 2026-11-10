using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class ApprovalAction
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long RequestId { get; set; }

    public long StepId { get; set; }

    public long ActorTenantUserId { get; set; }

    public string Action { get; set; } = null!;

    public string? Comment { get; set; }

    public DateTime ActionAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual TenantUser ActorTenantUser { get; set; } = null!;

    public virtual ApprovalRequest Request { get; set; } = null!;

    public virtual ApprovalStep Step { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
