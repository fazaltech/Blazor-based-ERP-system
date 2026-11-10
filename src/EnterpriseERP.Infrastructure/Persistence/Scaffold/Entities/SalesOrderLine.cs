using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class SalesOrderLine
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long SalesOrderId { get; set; }

    public int LineNo { get; set; }

    public long ItemId { get; set; }

    public decimal OrderedQty { get; set; }

    public decimal DeliveredQty { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal DiscountAmount { get; set; }

    public long? TaxCodeId { get; set; }

    public decimal LineTotal { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<InventoryReservation> InventoryReservations { get; set; } = new List<InventoryReservation>();

    public virtual Item Item { get; set; } = null!;

    public virtual SalesOrder SalesOrder { get; set; } = null!;

    public virtual ICollection<SalesReturnLine> SalesReturnLines { get; set; } = new List<SalesReturnLine>();

    public virtual ICollection<ShipmentLine> ShipmentLines { get; set; } = new List<ShipmentLine>();

    public virtual TaxCode? TaxCode { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;
}
