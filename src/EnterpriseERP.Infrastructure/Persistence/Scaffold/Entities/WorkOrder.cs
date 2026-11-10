using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class WorkOrder
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public string WorkOrderNo { get; set; } = null!;

    public long ItemId { get; set; }

    public long? Bomid { get; set; }

    public long? RoutingId { get; set; }

    public long WarehouseId { get; set; }

    public decimal PlannedQty { get; set; }

    public decimal CompletedQty { get; set; }

    public DateTime PlannedStart { get; set; }

    public DateTime? PlannedEnd { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Bomheader? Bom { get; set; }

    public virtual ICollection<InventoryReservation> InventoryReservations { get; set; } = new List<InventoryReservation>();

    public virtual Item Item { get; set; } = null!;

    public virtual ICollection<MaterialIssue> MaterialIssues { get; set; } = new List<MaterialIssue>();

    public virtual ICollection<ProductionReceipt> ProductionReceipts { get; set; } = new List<ProductionReceipt>();

    public virtual Routing? Routing { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;

    public virtual Warehouse Warehouse { get; set; } = null!;

    public virtual ICollection<WorkOrderOperation> WorkOrderOperations { get; set; } = new List<WorkOrderOperation>();
}
