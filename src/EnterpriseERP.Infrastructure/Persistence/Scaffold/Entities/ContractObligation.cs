using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class ContractObligation
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long ContractId { get; set; }

    public string Description { get; set; } = null!;

    public long? ResponsibleEmployeeId { get; set; }

    public DateOnly? DueDate { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Contract Contract { get; set; } = null!;

    public virtual Employee? ResponsibleEmployee { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;
}
