using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class PurchaseRequisitionLine
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long RequisitionId { get; set; }

    public long ItemId { get; set; }

    public decimal Quantity { get; set; }

    public decimal EstimatedUnitCost { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; set; } = new List<PurchaseOrderLine>();

    public virtual PurchaseRequisition Requisition { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
