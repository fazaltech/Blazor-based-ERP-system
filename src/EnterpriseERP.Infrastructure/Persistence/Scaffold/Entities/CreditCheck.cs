using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class CreditCheck
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long SalesOrderId { get; set; }

    public DateTime CheckedAt { get; set; }

    public decimal ExposureAmount { get; set; }

    public decimal CreditLimit { get; set; }

    public string Decision { get; set; } = null!;

    public long? CheckedByTenantUserId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual TenantUser? CheckedByTenantUser { get; set; }

    public virtual SalesOrder SalesOrder { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
