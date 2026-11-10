using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class Payslip
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long PayrollRunId { get; set; }

    public long EmployeeId { get; set; }

    public decimal GrossPay { get; set; }

    public decimal TotalDeductions { get; set; }

    public decimal NetPay { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Employee Employee { get; set; } = null!;

    public virtual PayrollRun PayrollRun { get; set; } = null!;

    public virtual ICollection<PayslipLine> PayslipLines { get; set; } = new List<PayslipLine>();

    public virtual Tenant Tenant { get; set; } = null!;
}
