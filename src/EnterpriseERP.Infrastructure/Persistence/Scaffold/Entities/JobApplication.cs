using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class JobApplication
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long RequisitionId { get; set; }

    public long CandidateId { get; set; }

    public DateTime AppliedAt { get; set; }

    public string Stage { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Candidate Candidate { get; set; } = null!;

    public virtual ICollection<Interview> Interviews { get; set; } = new List<Interview>();

    public virtual RecruitmentRequisition Requisition { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
