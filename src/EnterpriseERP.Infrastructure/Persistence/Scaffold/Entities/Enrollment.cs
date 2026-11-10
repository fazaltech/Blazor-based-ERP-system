using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class Enrollment
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long StudentId { get; set; }

    public long SectionId { get; set; }

    public DateOnly EnrolledAt { get; set; }

    public string Status { get; set; } = null!;

    public string? FinalGrade { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ClassSection Section { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
