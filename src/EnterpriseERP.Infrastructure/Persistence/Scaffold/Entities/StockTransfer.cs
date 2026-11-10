using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class StockTransfer
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public string TransferNo { get; set; } = null!;

    public long FromWarehouseId { get; set; }

    public long ToWarehouseId { get; set; }

    public DateOnly TransferDate { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Warehouse FromWarehouse { get; set; } = null!;

    public virtual ICollection<StockTransferLine> StockTransferLines { get; set; } = new List<StockTransferLine>();

    public virtual Tenant Tenant { get; set; } = null!;

    public virtual Warehouse ToWarehouse { get; set; } = null!;
}
