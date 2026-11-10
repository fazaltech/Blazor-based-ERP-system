using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class FixedAsset
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long LegalEntityId { get; set; }

    public long AssetCategoryId { get; set; }

    public string AssetCode { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateOnly AcquisitionDate { get; set; }

    public decimal AcquisitionCost { get; set; }

    public decimal SalvageValue { get; set; }

    public int UsefulLifeMonths { get; set; }

    public long? LocationId { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual FixedAssetCategory AssetCategory { get; set; } = null!;

    public virtual ICollection<AssetDepreciationLine> AssetDepreciationLines { get; set; } = new List<AssetDepreciationLine>();

    public virtual LegalEntity LegalEntity { get; set; } = null!;

    public virtual WarehouseLocation? Location { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;
}
