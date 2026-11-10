using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class CallCenterCall
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long? CustomerId { get; set; }

    public long? TicketId { get; set; }

    public long? AgentEmployeeId { get; set; }

    public DateTime CallStartAt { get; set; }

    public DateTime? CallEndAt { get; set; }

    public string? Disposition { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Employee? AgentEmployee { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;

    public virtual SupportTicket? Ticket { get; set; }
}
