using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class TaxCode
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string TaxType { get; set; } = null!;

    public decimal Rate { get; set; }

    public long? InputGlaccountId { get; set; }

    public long? OutputGlaccountId { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<ApinvoiceLine> ApinvoiceLines { get; set; } = new List<ApinvoiceLine>();

    public virtual ICollection<ArinvoiceLine> ArinvoiceLines { get; set; } = new List<ArinvoiceLine>();

    public virtual Glaccount? InputGlaccount { get; set; }

    public virtual Glaccount? OutputGlaccount { get; set; }

    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; set; } = new List<PurchaseOrderLine>();

    public virtual ICollection<SalesOrderLine> SalesOrderLines { get; set; } = new List<SalesOrderLine>();

    public virtual ICollection<SalesQuoteLine> SalesQuoteLines { get; set; } = new List<SalesQuoteLine>();

    public virtual Tenant Tenant { get; set; } = null!;
}
