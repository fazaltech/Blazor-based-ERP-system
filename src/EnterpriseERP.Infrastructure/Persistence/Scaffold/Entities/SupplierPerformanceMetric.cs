using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class SupplierPerformanceMetric
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long SupplierId { get; set; }

    public string MetricCode { get; set; } = null!;

    public DateOnly PeriodStart { get; set; }

    public DateOnly PeriodEnd { get; set; }

    public decimal MetricValue { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Supplier Supplier { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
