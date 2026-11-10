using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class FiscalYear
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long LegalEntityId { get; set; }

    public string Code { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<AccountingPeriod> AccountingPeriods { get; set; } = new List<AccountingPeriod>();

    public virtual ICollection<Budget> Budgets { get; set; } = new List<Budget>();

    public virtual ICollection<LeaveBalance> LeaveBalances { get; set; } = new List<LeaveBalance>();

    public virtual LegalEntity LegalEntity { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
