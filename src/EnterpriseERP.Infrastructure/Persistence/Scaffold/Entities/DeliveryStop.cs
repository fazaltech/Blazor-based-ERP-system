using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class DeliveryStop
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long RouteId { get; set; }

    public long ShipmentId { get; set; }

    public int StopNumber { get; set; }

    public string DeliveryStatus { get; set; } = null!;

    public DateTime? DeliveredAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual DeliveryRoute Route { get; set; } = null!;

    public virtual Shipment Shipment { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
