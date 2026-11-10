using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class PayslipLine
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long PayslipId { get; set; }

    public long PayComponentId { get; set; }

    public decimal Amount { get; set; }

    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual PayComponent PayComponent { get; set; } = null!;

    public virtual Payslip Payslip { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
