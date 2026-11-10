using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class TicketMessage
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long TicketId { get; set; }

    public long? SenderTenantUserId { get; set; }

    public string Body { get; set; } = null!;

    public bool IsInternal { get; set; }

    public DateTime SentAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual TenantUser? SenderTenantUser { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;

    public virtual SupportTicket Ticket { get; set; } = null!;
}
