using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class EmployeeDemographic
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long EmployeeId { get; set; }

    public string AttributeCode { get; set; } = null!;

    public string? AttributeValueEncrypted { get; set; }

    public DateTime? ConsentRecordedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Employee Employee { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
