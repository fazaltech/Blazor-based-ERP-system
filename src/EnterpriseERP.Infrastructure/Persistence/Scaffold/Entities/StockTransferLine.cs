using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class StockTransferLine
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long TransferId { get; set; }

    public long ItemId { get; set; }

    public long? LotId { get; set; }

    public decimal Quantity { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual InventoryLot? Lot { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;

    public virtual StockTransfer Transfer { get; set; } = null!;
}
