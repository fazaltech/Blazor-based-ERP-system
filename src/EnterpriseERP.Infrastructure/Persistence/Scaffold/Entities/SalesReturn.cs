using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class SalesReturn
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long CustomerId { get; set; }

    public long? SalesOrderId { get; set; }

    public string ReturnNo { get; set; } = null!;

    public DateOnly ReturnDate { get; set; }

    public string Status { get; set; } = null!;

    public string? Reason { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual SalesOrder? SalesOrder { get; set; }

    public virtual ICollection<SalesReturnLine> SalesReturnLines { get; set; } = new List<SalesReturnLine>();

    public virtual Tenant Tenant { get; set; } = null!;
}
