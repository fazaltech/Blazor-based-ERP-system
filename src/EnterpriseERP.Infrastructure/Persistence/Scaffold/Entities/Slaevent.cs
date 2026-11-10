using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class Slaevent
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long TicketId { get; set; }

    public string Metric { get; set; } = null!;

    public DateTime TargetAt { get; set; }

    public DateTime? ActualAt { get; set; }

    public bool Breached { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;

    public virtual SupportTicket Ticket { get; set; } = null!;
}
