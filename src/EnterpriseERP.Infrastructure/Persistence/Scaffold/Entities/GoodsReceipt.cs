using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class GoodsReceipt
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public string ReceiptNo { get; set; } = null!;

    public long? PurchaseOrderId { get; set; }

    public long WarehouseId { get; set; }

    public DateTime ReceivedAt { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<GoodsReceiptLine> GoodsReceiptLines { get; set; } = new List<GoodsReceiptLine>();

    public virtual PurchaseOrder? PurchaseOrder { get; set; }

    public virtual ICollection<PurchaseReturn> PurchaseReturns { get; set; } = new List<PurchaseReturn>();

    public virtual ICollection<SupplierClaim> SupplierClaims { get; set; } = new List<SupplierClaim>();

    public virtual Tenant Tenant { get; set; } = null!;

    public virtual Warehouse Warehouse { get; set; } = null!;
}
