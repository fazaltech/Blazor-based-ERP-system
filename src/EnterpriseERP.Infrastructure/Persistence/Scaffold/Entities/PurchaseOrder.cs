using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class PurchaseOrder
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public string Ponumber { get; set; } = null!;

    public long SupplierId { get; set; }

    public long? BranchId { get; set; }

    public DateOnly OrderDate { get; set; }

    public DateOnly? ExpectedDate { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public decimal Subtotal { get; set; }

    public decimal TaxAmount { get; set; }

    public decimal Total { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Apinvoice> Apinvoices { get; set; } = new List<Apinvoice>();

    public virtual Branch? Branch { get; set; }

    public virtual ICollection<GoodsReceipt> GoodsReceipts { get; set; } = new List<GoodsReceipt>();

    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; set; } = new List<PurchaseOrderLine>();

    public virtual Supplier Supplier { get; set; } = null!;

    public virtual ICollection<SupplierClaim> SupplierClaims { get; set; } = new List<SupplierClaim>();

    public virtual Tenant Tenant { get; set; } = null!;
}
