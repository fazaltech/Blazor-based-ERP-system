using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class BankReconciliationLine
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long ReconciliationId { get; set; }

    public long BankTransactionId { get; set; }

    public long? JournalLineId { get; set; }

    public decimal MatchAmount { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual BankTransaction BankTransaction { get; set; } = null!;

    public virtual JournalLine? JournalLine { get; set; }

    public virtual BankReconciliation Reconciliation { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
