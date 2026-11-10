using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class BankReconciliation
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long BankAccountId { get; set; }

    public DateOnly StatementDate { get; set; }

    public decimal StatementClosingBalance { get; set; }

    public decimal GlclosingBalance { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual BankAccount BankAccount { get; set; } = null!;

    public virtual ICollection<BankReconciliationLine> BankReconciliationLines { get; set; } = new List<BankReconciliationLine>();

    public virtual Tenant Tenant { get; set; } = null!;
}
