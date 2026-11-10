using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class InventoryTransaction
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long ItemId { get; set; }

    public long WarehouseId { get; set; }

    public long? LocationId { get; set; }

    public long? LotId { get; set; }

    public long? SerialId { get; set; }

    public string TransactionType { get; set; } = null!;

    public string SourceType { get; set; } = null!;

    public long? SourceId { get; set; }

    public decimal Quantity { get; set; }

    public decimal UnitCost { get; set; }

    public DateTime OccurredAt { get; set; }

    public bool Posted { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual WarehouseLocation? Location { get; set; }

    public virtual InventoryLot? Lot { get; set; }

    public virtual ICollection<MaterialIssue> MaterialIssues { get; set; } = new List<MaterialIssue>();

    public virtual ICollection<ProductionReceipt> ProductionReceipts { get; set; } = new List<ProductionReceipt>();

    public virtual InventorySerial? Serial { get; set; }

    public virtual ICollection<StockCountLine> StockCountLines { get; set; } = new List<StockCountLine>();

    public virtual Tenant Tenant { get; set; } = null!;

    public virtual Warehouse Warehouse { get; set; } = null!;
}
