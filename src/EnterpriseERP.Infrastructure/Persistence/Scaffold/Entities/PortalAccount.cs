using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class PortalAccount
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long TenantUserId { get; set; }

    public string PortalType { get; set; } = null!;

    public long? CustomerId { get; set; }

    public long? SupplierId { get; set; }

    public long? EmployeeId { get; set; }

    public long? StudentId { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual ICollection<SelfServiceRequest> SelfServiceRequests { get; set; } = new List<SelfServiceRequest>();

    public virtual Student? Student { get; set; }

    public virtual Supplier? Supplier { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;

    public virtual TenantUser TenantUser { get; set; } = null!;
}
