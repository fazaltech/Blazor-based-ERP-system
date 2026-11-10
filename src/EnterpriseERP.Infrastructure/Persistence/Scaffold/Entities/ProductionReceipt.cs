using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class ProductionReceipt
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long WorkOrderId { get; set; }

    public long ItemId { get; set; }

    public long? InventoryTransactionId { get; set; }

    public decimal GoodQty { get; set; }

    public decimal ScrapQty { get; set; }

    public DateTime ReceivedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual InventoryTransaction? InventoryTransaction { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;

    public virtual WorkOrder WorkOrder { get; set; } = null!;
}
