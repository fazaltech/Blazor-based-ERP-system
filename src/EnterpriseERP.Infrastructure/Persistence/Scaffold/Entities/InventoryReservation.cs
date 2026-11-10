using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class InventoryReservation
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long ItemId { get; set; }

    public long WarehouseId { get; set; }

    public long? SalesOrderLineId { get; set; }

    public long? WorkOrderId { get; set; }

    public decimal Quantity { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual SalesOrderLine? SalesOrderLine { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;

    public virtual Warehouse Warehouse { get; set; } = null!;

    public virtual WorkOrder? WorkOrder { get; set; }
}
