using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class SupplierQuote
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long SupplierId { get; set; }

    public string QuoteNo { get; set; } = null!;

    public DateOnly QuoteDate { get; set; }

    public DateOnly? ValidUntil { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Supplier Supplier { get; set; } = null!;

    public virtual ICollection<SupplierQuoteLine> SupplierQuoteLines { get; set; } = new List<SupplierQuoteLine>();

    public virtual Tenant Tenant { get; set; } = null!;
}
