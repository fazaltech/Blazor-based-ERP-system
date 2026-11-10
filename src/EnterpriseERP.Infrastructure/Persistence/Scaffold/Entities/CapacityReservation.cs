using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class CapacityReservation
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long WorkCenterId { get; set; }

    public long WorkOrderOperationId { get; set; }

    public DateTime StartAt { get; set; }

    public DateTime EndAt { get; set; }

    public decimal ReservedHours { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;

    public virtual WorkCenter WorkCenter { get; set; } = null!;

    public virtual WorkOrderOperation WorkOrderOperation { get; set; } = null!;
}
