using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class ContractMilestone
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long ContractId { get; set; }

    public string Name { get; set; } = null!;

    public DateOnly DueDate { get; set; }

    public decimal? Amount { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? CompletedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Contract Contract { get; set; } = null!;

    public virtual ICollection<ContractAlert> ContractAlerts { get; set; } = new List<ContractAlert>();

    public virtual Tenant Tenant { get; set; } = null!;
}
