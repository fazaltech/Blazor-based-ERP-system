using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class AssetDepreciationLine
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long RunId { get; set; }

    public long FixedAssetId { get; set; }

    public decimal DepreciationAmount { get; set; }

    public decimal AccumulatedAmount { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual FixedAsset FixedAsset { get; set; } = null!;

    public virtual AssetDepreciationRun Run { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
