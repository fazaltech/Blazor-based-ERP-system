using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class SalesReturnLine
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long ReturnId { get; set; }

    public long? SalesOrderLineId { get; set; }

    public long ItemId { get; set; }

    public decimal ReturnedQty { get; set; }

    public decimal UnitPrice { get; set; }

    public string Disposition { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual SalesReturn Return { get; set; } = null!;

    public virtual SalesOrderLine? SalesOrderLine { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;
}
