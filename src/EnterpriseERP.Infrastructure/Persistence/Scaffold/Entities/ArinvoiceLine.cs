using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class ArinvoiceLine
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long ArinvoiceId { get; set; }

    public int LineNumber { get; set; }

    public long? ItemId { get; set; }

    public string Description { get; set; } = null!;

    public long GlaccountId { get; set; }

    public long? TaxCodeId { get; set; }

    public decimal Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal LineTotal { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Arinvoice Arinvoice { get; set; } = null!;

    public virtual Glaccount Glaccount { get; set; } = null!;

    public virtual Item? Item { get; set; }

    public virtual TaxCode? TaxCode { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;
}
