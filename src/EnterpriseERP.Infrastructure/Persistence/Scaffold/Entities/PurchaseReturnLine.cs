using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class PurchaseReturnLine
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long ReturnId { get; set; }

    public long GoodsReceiptLineId { get; set; }

    public decimal Quantity { get; set; }

    public decimal UnitCost { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual GoodsReceiptLine GoodsReceiptLine { get; set; } = null!;

    public virtual PurchaseReturn Return { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
