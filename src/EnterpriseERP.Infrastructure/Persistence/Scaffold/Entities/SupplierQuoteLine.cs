using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class SupplierQuoteLine
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long QuoteId { get; set; }

    public long ItemId { get; set; }

    public decimal Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public int? LeadTimeDays { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual SupplierQuote Quote { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
