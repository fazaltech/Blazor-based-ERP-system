using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class SalesCommission
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long SalesOrderId { get; set; }

    public long EmployeeId { get; set; }

    public decimal CommissionRate { get; set; }

    public decimal CommissionAmount { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Employee Employee { get; set; } = null!;

    public virtual SalesOrder SalesOrder { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
