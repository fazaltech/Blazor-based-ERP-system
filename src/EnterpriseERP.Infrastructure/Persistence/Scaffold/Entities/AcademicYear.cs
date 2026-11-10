using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class AcademicYear
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long CampusId { get; set; }

    public string Code { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<AcademicTerm> AcademicTerms { get; set; } = new List<AcademicTerm>();

    public virtual ICollection<Admission> Admissions { get; set; } = new List<Admission>();

    public virtual Campus Campus { get; set; } = null!;

    public virtual ICollection<FeeStructure> FeeStructures { get; set; } = new List<FeeStructure>();

    public virtual Tenant Tenant { get; set; } = null!;
}
