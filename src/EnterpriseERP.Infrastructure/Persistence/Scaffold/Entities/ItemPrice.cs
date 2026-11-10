using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class ItemPrice
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long ItemId { get; set; }

    public long PriceListId { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public decimal UnitPrice { get; set; }

    public DateOnly ValidFrom { get; set; }

    public DateOnly? ValidTo { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual PriceList PriceList { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
