using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class PurchaseReturn
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long SupplierId { get; set; }

    public long? GoodsReceiptId { get; set; }

    public string ReturnNo { get; set; } = null!;

    public DateOnly ReturnDate { get; set; }

    public string? Reason { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual GoodsReceipt? GoodsReceipt { get; set; }

    public virtual ICollection<PurchaseReturnLine> PurchaseReturnLines { get; set; } = new List<PurchaseReturnLine>();

    public virtual Supplier Supplier { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
