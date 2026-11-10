using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class AppaymentAllocation
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long PaymentId { get; set; }

    public long ApinvoiceId { get; set; }

    public decimal AppliedAmount { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Apinvoice Apinvoice { get; set; } = null!;

    public virtual Appayment Payment { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
