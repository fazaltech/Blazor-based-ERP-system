using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class SalesQuoteLine
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long QuoteId { get; set; }

    public int LineNo { get; set; }

    public long ItemId { get; set; }

    public decimal Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal DiscountAmount { get; set; }

    public long? TaxCodeId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual SalesQuote Quote { get; set; } = null!;

    public virtual TaxCode? TaxCode { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;
}
