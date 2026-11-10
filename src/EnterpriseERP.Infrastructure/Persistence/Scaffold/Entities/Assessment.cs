using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class Assessment
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long SectionId { get; set; }

    public string Name { get; set; } = null!;

    public string AssessmentType { get; set; } = null!;

    public decimal MaxMarks { get; set; }

    public DateOnly AssessmentDate { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<AssessmentScore> AssessmentScores { get; set; } = new List<AssessmentScore>();

    public virtual ClassSection Section { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
