using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class ApprovalStep
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long WorkflowId { get; set; }

    public int StepNumber { get; set; }

    public long? ApproverRoleId { get; set; }

    public int MinApprovals { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<ApprovalAction> ApprovalActions { get; set; } = new List<ApprovalAction>();

    public virtual Role? ApproverRole { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;

    public virtual ApprovalWorkflow Workflow { get; set; } = null!;
}
