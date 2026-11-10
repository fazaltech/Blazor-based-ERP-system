using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class UnitsOfMeasure
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Dimension { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();

    public virtual Tenant Tenant { get; set; } = null!;

    public virtual ICollection<Uomconversion> UomconversionFromUoms { get; set; } = new List<Uomconversion>();

    public virtual ICollection<Uomconversion> UomconversionToUoms { get; set; } = new List<Uomconversion>();
}
