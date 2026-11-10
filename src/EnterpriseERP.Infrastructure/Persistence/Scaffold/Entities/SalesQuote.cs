using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class SalesQuote
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public string QuoteNo { get; set; } = null!;

    public long CustomerId { get; set; }

    public DateOnly QuoteDate { get; set; }

    public DateOnly? ValidUntil { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<SalesQuoteLine> SalesQuoteLines { get; set; } = new List<SalesQuoteLine>();

    public virtual Tenant Tenant { get; set; } = null!;
}
