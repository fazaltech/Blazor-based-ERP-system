using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class WorkOrderOperation
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long WorkOrderId { get; set; }

    public long RoutingOperationId { get; set; }

    public DateTime? PlannedStart { get; set; }

    public DateTime? ActualStart { get; set; }

    public DateTime? ActualEnd { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<CapacityReservation> CapacityReservations { get; set; } = new List<CapacityReservation>();

    public virtual RoutingOperation RoutingOperation { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;

    public virtual WorkOrder WorkOrder { get; set; } = null!;
}
