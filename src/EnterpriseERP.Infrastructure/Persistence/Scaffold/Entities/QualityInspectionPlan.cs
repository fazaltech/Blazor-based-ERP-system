using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class QualityInspectionPlan
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public long? ItemId { get; set; }

    public string InspectionStage { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Item? Item { get; set; }

    public virtual ICollection<QualityInspectionTest> QualityInspectionTests { get; set; } = new List<QualityInspectionTest>();

    public virtual ICollection<QualityInspection> QualityInspections { get; set; } = new List<QualityInspection>();

    public virtual Tenant Tenant { get; set; } = null!;
}
