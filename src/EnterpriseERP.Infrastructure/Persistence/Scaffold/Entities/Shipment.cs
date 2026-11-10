using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class Shipment
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public string ShipmentNo { get; set; } = null!;

    public long SalesOrderId { get; set; }

    public long WarehouseId { get; set; }

    public DateOnly? ShipDate { get; set; }

    public string? Carrier { get; set; }

    public string? TrackingNo { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<DeliveryStop> DeliveryStops { get; set; } = new List<DeliveryStop>();

    public virtual SalesOrder SalesOrder { get; set; } = null!;

    public virtual ICollection<ShipmentLine> ShipmentLines { get; set; } = new List<ShipmentLine>();

    public virtual Tenant Tenant { get; set; } = null!;

    public virtual Warehouse Warehouse { get; set; } = null!;
}
