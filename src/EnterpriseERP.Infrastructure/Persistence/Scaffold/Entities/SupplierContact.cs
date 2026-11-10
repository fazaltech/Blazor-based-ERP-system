using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class SupplierContact
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long SupplierId { get; set; }

    public string Name { get; set; } = null!;

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public bool IsPrimary { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Supplier Supplier { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
