using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class QualityInspection
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long PlanId { get; set; }

    public string SourceType { get; set; } = null!;

    public long SourceId { get; set; }

    public DateTime InspectedAt { get; set; }

    public long InspectorEmployeeId { get; set; }

    public string Result { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Employee InspectorEmployee { get; set; } = null!;

    public virtual QualityInspectionPlan Plan { get; set; } = null!;

    public virtual ICollection<QualityInspectionResult> QualityInspectionResults { get; set; } = new List<QualityInspectionResult>();

    public virtual Tenant Tenant { get; set; } = null!;
}
