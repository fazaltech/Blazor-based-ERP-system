using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class ServiceContract
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long CustomerId { get; set; }

    public long ContractId { get; set; }

    public string Slatier { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Contract Contract { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
