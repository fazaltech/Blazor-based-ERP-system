using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class ShipmentLine
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long ShipmentId { get; set; }

    public long SalesOrderLineId { get; set; }

    public long ItemId { get; set; }

    public decimal ShippedQty { get; set; }

    public long? LotId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual InventoryLot? Lot { get; set; }

    public virtual SalesOrderLine SalesOrderLine { get; set; } = null!;

    public virtual Shipment Shipment { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
