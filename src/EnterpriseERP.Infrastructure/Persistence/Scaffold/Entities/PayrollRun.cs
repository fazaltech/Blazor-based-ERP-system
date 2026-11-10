using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class PayrollRun
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long PayrollPeriodId { get; set; }

    public int RunNumber { get; set; }

    public string Status { get; set; } = null!;

    public long? JournalEntryId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual JournalEntry? JournalEntry { get; set; }

    public virtual PayrollPeriod PayrollPeriod { get; set; } = null!;

    public virtual ICollection<Payslip> Payslips { get; set; } = new List<Payslip>();

    public virtual Tenant Tenant { get; set; } = null!;
}
