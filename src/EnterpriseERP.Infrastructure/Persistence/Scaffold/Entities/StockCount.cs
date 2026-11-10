using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class StockCount
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long WarehouseId { get; set; }

    public DateOnly CountDate { get; set; }

    public string Status { get; set; } = null!;

    public long? ApprovedByTenantUserId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual TenantUser? ApprovedByTenantUser { get; set; }

    public virtual ICollection<StockCountLine> StockCountLines { get; set; } = new List<StockCountLine>();

    public virtual Tenant Tenant { get; set; } = null!;

    public virtual Warehouse Warehouse { get; set; } = null!;
}
