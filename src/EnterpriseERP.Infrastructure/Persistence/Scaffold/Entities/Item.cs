using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class Item
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public string Sku { get; set; } = null!;

    public string Name { get; set; } = null!;

    public long? CategoryId { get; set; }

    public long BaseUomid { get; set; }

    public string ItemType { get; set; } = null!;

    public string CostMethod { get; set; } = null!;

    public decimal StandardCost { get; set; }

    public bool IsActive { get; set; }

    public bool TrackLots { get; set; }

    public bool TrackSerials { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<ArinvoiceLine> ArinvoiceLines { get; set; } = new List<ArinvoiceLine>();

    public virtual UnitsOfMeasure BaseUom { get; set; } = null!;

    public virtual ICollection<Bomheader> Bomheaders { get; set; } = new List<Bomheader>();

    public virtual ICollection<Bomline> Bomlines { get; set; } = new List<Bomline>();

    public virtual ItemCategory? Category { get; set; }

    public virtual ICollection<EngineeringRevision> EngineeringRevisions { get; set; } = new List<EngineeringRevision>();

    public virtual ICollection<GoodsReceiptLine> GoodsReceiptLines { get; set; } = new List<GoodsReceiptLine>();

    public virtual ICollection<InventoryBalance> InventoryBalances { get; set; } = new List<InventoryBalance>();

    public virtual ICollection<InventoryLot> InventoryLots { get; set; } = new List<InventoryLot>();

    public virtual ICollection<InventoryReservation> InventoryReservations { get; set; } = new List<InventoryReservation>();

    public virtual ICollection<InventorySerial> InventorySerials { get; set; } = new List<InventorySerial>();

    public virtual ICollection<InventoryTransaction> InventoryTransactions { get; set; } = new List<InventoryTransaction>();

    public virtual ICollection<ItemPrice> ItemPrices { get; set; } = new List<ItemPrice>();

    public virtual ICollection<MaterialIssue> MaterialIssues { get; set; } = new List<MaterialIssue>();

    public virtual ICollection<NonConformance> NonConformances { get; set; } = new List<NonConformance>();

    public virtual ICollection<ProductLifecycleChange> ProductLifecycleChanges { get; set; } = new List<ProductLifecycleChange>();

    public virtual ICollection<ProductionPlanLine> ProductionPlanLines { get; set; } = new List<ProductionPlanLine>();

    public virtual ICollection<ProductionReceipt> ProductionReceipts { get; set; } = new List<ProductionReceipt>();

    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; set; } = new List<PurchaseOrderLine>();

    public virtual ICollection<PurchaseRequisitionLine> PurchaseRequisitionLines { get; set; } = new List<PurchaseRequisitionLine>();

    public virtual ICollection<QualityInspectionPlan> QualityInspectionPlans { get; set; } = new List<QualityInspectionPlan>();

    public virtual ICollection<ReorderPolicy> ReorderPolicies { get; set; } = new List<ReorderPolicy>();

    public virtual ICollection<Routing> Routings { get; set; } = new List<Routing>();

    public virtual ICollection<SalesOrderLine> SalesOrderLines { get; set; } = new List<SalesOrderLine>();

    public virtual ICollection<SalesQuoteLine> SalesQuoteLines { get; set; } = new List<SalesQuoteLine>();

    public virtual ICollection<SalesReturnLine> SalesReturnLines { get; set; } = new List<SalesReturnLine>();

    public virtual ICollection<ShipmentLine> ShipmentLines { get; set; } = new List<ShipmentLine>();

    public virtual ICollection<StockCountLine> StockCountLines { get; set; } = new List<StockCountLine>();

    public virtual ICollection<StockTransferLine> StockTransferLines { get; set; } = new List<StockTransferLine>();

    public virtual ICollection<SupplierQuoteLine> SupplierQuoteLines { get; set; } = new List<SupplierQuoteLine>();

    public virtual Tenant Tenant { get; set; } = null!;

    public virtual ICollection<WorkOrder> WorkOrders { get; set; } = new List<WorkOrder>();
}
