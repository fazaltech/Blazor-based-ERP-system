using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class InventoryBalance
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long ItemId { get; set; }

    public long WarehouseId { get; set; }

    public long? LocationId { get; set; }

    public long? LotId { get; set; }

    public decimal OnHand { get; set; }

    public decimal Reserved { get; set; }

    public DateTime LastCalculatedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual WarehouseLocation? Location { get; set; }

    public virtual InventoryLot? Lot { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;

    public virtual Warehouse Warehouse { get; set; } = null!;
}
