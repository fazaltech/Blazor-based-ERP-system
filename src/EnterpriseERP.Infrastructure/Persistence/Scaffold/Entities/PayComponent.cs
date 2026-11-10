using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class PayComponent
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string ComponentType { get; set; } = null!;

    public bool IsTaxable { get; set; }

    public long? GlaccountId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Glaccount? Glaccount { get; set; }

    public virtual ICollection<PayslipLine> PayslipLines { get; set; } = new List<PayslipLine>();

    public virtual Tenant Tenant { get; set; } = null!;
}
