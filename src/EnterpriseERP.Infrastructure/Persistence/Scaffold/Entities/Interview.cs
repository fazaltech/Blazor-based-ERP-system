using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class Interview
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long ApplicationId { get; set; }

    public long InterviewerEmployeeId { get; set; }

    public DateTime ScheduledAt { get; set; }

    public int? Score { get; set; }

    public string? Outcome { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual JobApplication Application { get; set; } = null!;

    public virtual Employee InterviewerEmployee { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
