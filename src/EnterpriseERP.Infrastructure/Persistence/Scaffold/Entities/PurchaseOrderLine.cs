using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class PurchaseOrderLine
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long PurchaseOrderId { get; set; }

    public int LineNo { get; set; }

    public long ItemId { get; set; }

    public decimal Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public long? TaxCodeId { get; set; }

    public decimal LineTotal { get; set; }

    public long? RequisitionLineId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<GoodsReceiptLine> GoodsReceiptLines { get; set; } = new List<GoodsReceiptLine>();

    public virtual Item Item { get; set; } = null!;

    public virtual PurchaseOrder PurchaseOrder { get; set; } = null!;

    public virtual PurchaseRequisitionLine? RequisitionLine { get; set; }

    public virtual TaxCode? TaxCode { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;
}
