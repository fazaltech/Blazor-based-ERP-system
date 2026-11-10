using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class FixedAssetCategory
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public long AssetGlaccountId { get; set; }

    public long DepreciationExpenseGlaccountId { get; set; }

    public long AccumDepGlaccountId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Glaccount AccumDepGlaccount { get; set; } = null!;

    public virtual Glaccount AssetGlaccount { get; set; } = null!;

    public virtual Glaccount DepreciationExpenseGlaccount { get; set; } = null!;

    public virtual ICollection<FixedAsset> FixedAssets { get; set; } = new List<FixedAsset>();

    public virtual Tenant Tenant { get; set; } = null!;
}
