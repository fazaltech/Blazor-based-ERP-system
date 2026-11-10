using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class QualityInspectionResult
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long InspectionId { get; set; }

    public long TestId { get; set; }

    public decimal? MeasuredValue { get; set; }

    public bool Pass { get; set; }

    public string? Notes { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual QualityInspection Inspection { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;

    public virtual QualityInspectionTest Test { get; set; } = null!;
}
