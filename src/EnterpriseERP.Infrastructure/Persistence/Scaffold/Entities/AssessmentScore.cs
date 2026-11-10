using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class AssessmentScore
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long AssessmentId { get; set; }

    public long StudentId { get; set; }

    public decimal MarksObtained { get; set; }

    public string? Remarks { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Assessment Assessment { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
