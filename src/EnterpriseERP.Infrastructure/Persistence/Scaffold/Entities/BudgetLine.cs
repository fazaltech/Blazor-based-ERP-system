using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class BudgetLine
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long BudgetId { get; set; }

    public long PeriodId { get; set; }

    public long GlaccountId { get; set; }

    public long? CostCenterId { get; set; }

    public decimal Amount { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Budget Budget { get; set; } = null!;

    public virtual CostCenter? CostCenter { get; set; }

    public virtual Glaccount Glaccount { get; set; } = null!;

    public virtual AccountingPeriod Period { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
