using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class ApprovalRequest
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long WorkflowId { get; set; }

    public string DocumentType { get; set; } = null!;

    public long DocumentId { get; set; }

    public long RequestedByTenantUserId { get; set; }

    public int CurrentStep { get; set; }

    public string Status { get; set; } = null!;

    public DateTime RequestedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<ApprovalAction> ApprovalActions { get; set; } = new List<ApprovalAction>();

    public virtual TenantUser RequestedByTenantUser { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;

    public virtual ApprovalWorkflow Workflow { get; set; } = null!;
}
