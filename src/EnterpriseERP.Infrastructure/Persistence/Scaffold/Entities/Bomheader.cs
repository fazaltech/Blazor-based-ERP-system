using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class Bomheader
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long FinishedItemId { get; set; }

    public string RevisionCode { get; set; } = null!;

    public decimal BaseQty { get; set; }

    public string Status { get; set; } = null!;

    public DateOnly EffectiveFrom { get; set; }

    public DateOnly? EffectiveTo { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Bomline> Bomlines { get; set; } = new List<Bomline>();

    public virtual Item FinishedItem { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;

    public virtual ICollection<WorkOrder> WorkOrders { get; set; } = new List<WorkOrder>();
}
