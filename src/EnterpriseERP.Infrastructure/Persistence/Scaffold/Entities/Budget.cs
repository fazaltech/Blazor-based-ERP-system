using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class Budget
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long LegalEntityId { get; set; }

    public long FiscalYearId { get; set; }

    public string Name { get; set; } = null!;

    public int Version { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<BudgetLine> BudgetLines { get; set; } = new List<BudgetLine>();

    public virtual FiscalYear FiscalYear { get; set; } = null!;

    public virtual LegalEntity LegalEntity { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
