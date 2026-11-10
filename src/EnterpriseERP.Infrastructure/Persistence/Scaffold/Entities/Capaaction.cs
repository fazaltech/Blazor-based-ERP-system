using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class Capaaction
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long NonConformanceId { get; set; }

    public long? AssignedEmployeeId { get; set; }

    public string ActionType { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateOnly? DueDate { get; set; }

    public DateTime? CompletedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Employee? AssignedEmployee { get; set; }

    public virtual NonConformance NonConformance { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
