using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class ArreceiptAllocation
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long ReceiptId { get; set; }

    public long ArinvoiceId { get; set; }

    public decimal AppliedAmount { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Arinvoice Arinvoice { get; set; } = null!;

    public virtual Arreceipt Receipt { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
