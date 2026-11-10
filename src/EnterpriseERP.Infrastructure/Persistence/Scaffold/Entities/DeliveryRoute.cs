using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class DeliveryRoute
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long BranchId { get; set; }

    public string Name { get; set; } = null!;

    public long? DriverEmployeeId { get; set; }

    public DateOnly RouteDate { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Branch Branch { get; set; } = null!;

    public virtual ICollection<DeliveryStop> DeliveryStops { get; set; } = new List<DeliveryStop>();

    public virtual Employee? DriverEmployee { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;
}
