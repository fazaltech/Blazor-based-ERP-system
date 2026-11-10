using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class QualityInspectionTest
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long PlanId { get; set; }

    public string TestCode { get; set; } = null!;

    public string ParameterName { get; set; } = null!;

    public decimal? LowerLimit { get; set; }

    public decimal? UpperLimit { get; set; }

    public string? Unit { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual QualityInspectionPlan Plan { get; set; } = null!;

    public virtual ICollection<QualityInspectionResult> QualityInspectionResults { get; set; } = new List<QualityInspectionResult>();

    public virtual Tenant Tenant { get; set; } = null!;
}
