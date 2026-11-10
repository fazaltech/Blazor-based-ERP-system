using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class Notification
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long TenantUserId { get; set; }

    public string Title { get; set; } = null!;

    public string Body { get; set; } = null!;

    public string Channel { get; set; } = null!;

    public DateTime? ReadAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;

    public virtual TenantUser TenantUser { get; set; } = null!;
}
