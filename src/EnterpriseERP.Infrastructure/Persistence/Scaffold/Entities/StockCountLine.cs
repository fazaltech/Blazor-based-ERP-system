using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class StockCountLine
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long CountId { get; set; }

    public long ItemId { get; set; }

    public long? LocationId { get; set; }

    public decimal ExpectedQty { get; set; }

    public decimal CountedQty { get; set; }

    public long? AdjustmentTransactionId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual InventoryTransaction? AdjustmentTransaction { get; set; }

    public virtual StockCount Count { get; set; } = null!;

    public virtual Item Item { get; set; } = null!;

    public virtual WarehouseLocation? Location { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;
}
