using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class StudentGuardian
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long StudentId { get; set; }

    public string FullName { get; set; } = null!;

    public string Relationship { get; set; } = null!;

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public bool IsPrimary { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Student Student { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
