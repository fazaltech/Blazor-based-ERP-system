using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class WorkCenter
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public long? DepartmentId { get; set; }

    public decimal CapacityHoursPerDay { get; set; }

    public decimal HourlyCostRate { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<CapacityReservation> CapacityReservations { get; set; } = new List<CapacityReservation>();

    public virtual Department? Department { get; set; }

    public virtual ICollection<RoutingOperation> RoutingOperations { get; set; } = new List<RoutingOperation>();

    public virtual Tenant Tenant { get; set; } = null!;
}
