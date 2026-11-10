using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class NumberSequence
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public string DocumentType { get; set; } = null!;

    public string? Prefix { get; set; }

    public long NextNumber { get; set; }

    public int Padding { get; set; }

    public int? FiscalYear { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;
}
