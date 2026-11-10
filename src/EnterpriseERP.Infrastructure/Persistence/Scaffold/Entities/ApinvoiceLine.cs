using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class ApinvoiceLine
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long ApinvoiceId { get; set; }

    public int LineNumber { get; set; }

    public string Description { get; set; } = null!;

    public long? PurchaseReceiptLineId { get; set; }

    public long GlaccountId { get; set; }

    public long? TaxCodeId { get; set; }

    public decimal Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal LineTotal { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Apinvoice Apinvoice { get; set; } = null!;

    public virtual Glaccount Glaccount { get; set; } = null!;

    public virtual GoodsReceiptLine? PurchaseReceiptLine { get; set; }

    public virtual TaxCode? TaxCode { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;
}
