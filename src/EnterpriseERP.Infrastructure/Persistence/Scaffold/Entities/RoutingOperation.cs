using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class RoutingOperation
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long RoutingId { get; set; }

    public int OperationNo { get; set; }

    public long WorkCenterId { get; set; }

    public string Description { get; set; } = null!;

    public decimal SetupMinutes { get; set; }

    public decimal RunMinutesPerUnit { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Bomline> Bomlines { get; set; } = new List<Bomline>();

    public virtual Routing Routing { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;

    public virtual WorkCenter WorkCenter { get; set; } = null!;

    public virtual ICollection<WorkOrderOperation> WorkOrderOperations { get; set; } = new List<WorkOrderOperation>();
}
