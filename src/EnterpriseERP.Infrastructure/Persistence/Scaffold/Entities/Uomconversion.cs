using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class Uomconversion
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long FromUomid { get; set; }

    public long ToUomid { get; set; }

    public decimal ConversionFactor { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual UnitsOfMeasure FromUom { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;

    public virtual UnitsOfMeasure ToUom { get; set; } = null!;
}
