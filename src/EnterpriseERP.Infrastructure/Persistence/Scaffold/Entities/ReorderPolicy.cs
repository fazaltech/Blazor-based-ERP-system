using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class ReorderPolicy
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long ItemId { get; set; }

    public long WarehouseId { get; set; }

    public decimal MinQty { get; set; }

    public decimal MaxQty { get; set; }

    public decimal ReorderPoint { get; set; }

    public long? PreferredSupplierId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual Supplier? PreferredSupplier { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;

    public virtual Warehouse Warehouse { get; set; } = null!;
}
