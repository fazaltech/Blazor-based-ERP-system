using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class GoodsReceiptLine
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long GoodsReceiptId { get; set; }

    public long? PurchaseOrderLineId { get; set; }

    public long ItemId { get; set; }

    public long? LocationId { get; set; }

    public long? LotId { get; set; }

    public decimal ReceivedQty { get; set; }

    public decimal AcceptedQty { get; set; }

    public decimal RejectedQty { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<ApinvoiceLine> ApinvoiceLines { get; set; } = new List<ApinvoiceLine>();

    public virtual GoodsReceipt GoodsReceipt { get; set; } = null!;

    public virtual Item Item { get; set; } = null!;

    public virtual WarehouseLocation? Location { get; set; }

    public virtual InventoryLot? Lot { get; set; }

    public virtual PurchaseOrderLine? PurchaseOrderLine { get; set; }

    public virtual ICollection<PurchaseReturnLine> PurchaseReturnLines { get; set; } = new List<PurchaseReturnLine>();

    public virtual Tenant Tenant { get; set; } = null!;
}
