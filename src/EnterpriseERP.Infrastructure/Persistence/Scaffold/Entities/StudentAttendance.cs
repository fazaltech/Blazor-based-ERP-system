using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class StudentAttendance
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long SessionId { get; set; }

    public long StudentId { get; set; }

    public string Status { get; set; } = null!;

    public string? Remarks { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ClassSession Session { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
