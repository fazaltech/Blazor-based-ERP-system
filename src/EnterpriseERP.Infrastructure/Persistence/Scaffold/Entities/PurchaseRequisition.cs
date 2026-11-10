using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class PurchaseRequisition
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public string RequisitionNo { get; set; } = null!;

    public long RequestedByEmployeeId { get; set; }

    public DateOnly RequiredByDate { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<PurchaseRequisitionLine> PurchaseRequisitionLines { get; set; } = new List<PurchaseRequisitionLine>();

    public virtual Employee RequestedByEmployee { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
