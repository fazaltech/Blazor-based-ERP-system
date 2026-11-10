using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class ItemCategory
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long? ParentCategoryId { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<ItemCategory> InverseParentCategory { get; set; } = new List<ItemCategory>();

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();

    public virtual ItemCategory? ParentCategory { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;
}
