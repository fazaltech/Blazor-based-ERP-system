using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class SalesOrder
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public string OrderNo { get; set; } = null!;

    public long CustomerId { get; set; }

    public long? BranchId { get; set; }

    public DateOnly OrderDate { get; set; }

    public DateOnly? RequestedShipDate { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public decimal Subtotal { get; set; }

    public decimal DiscountAmount { get; set; }

    public decimal TaxAmount { get; set; }

    public decimal Total { get; set; }

    public string Status { get; set; } = null!;

    public long? SalespersonEmployeeId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Arinvoice> Arinvoices { get; set; } = new List<Arinvoice>();

    public virtual Branch? Branch { get; set; }

    public virtual ICollection<CreditCheck> CreditChecks { get; set; } = new List<CreditCheck>();

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<SalesCommission> SalesCommissions { get; set; } = new List<SalesCommission>();

    public virtual ICollection<SalesOrderLine> SalesOrderLines { get; set; } = new List<SalesOrderLine>();

    public virtual ICollection<SalesReturn> SalesReturns { get; set; } = new List<SalesReturn>();

    public virtual Employee? SalespersonEmployee { get; set; }

    public virtual ICollection<Shipment> Shipments { get; set; } = new List<Shipment>();

    public virtual Tenant Tenant { get; set; } = null!;
}
