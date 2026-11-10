using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class SupportTicket
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public string TicketNo { get; set; } = null!;

    public long? CustomerId { get; set; }

    public long? ContactId { get; set; }

    public string Subject { get; set; } = null!;

    public string? Description { get; set; }

    public string Priority { get; set; } = null!;

    public string Status { get; set; } = null!;

    public long? AssignedEmployeeId { get; set; }

    public DateTime OpenedAt { get; set; }

    public DateTime? ClosedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Employee? AssignedEmployee { get; set; }

    public virtual ICollection<CallCenterCall> CallCenterCalls { get; set; } = new List<CallCenterCall>();

    public virtual CustomerContact? Contact { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<Slaevent> Slaevents { get; set; } = new List<Slaevent>();

    public virtual Tenant Tenant { get; set; } = null!;

    public virtual ICollection<TicketMessage> TicketMessages { get; set; } = new List<TicketMessage>();
}
