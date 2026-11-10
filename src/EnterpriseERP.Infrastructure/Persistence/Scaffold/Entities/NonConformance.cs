using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class NonConformance
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long? ItemId { get; set; }

    public string SourceType { get; set; } = null!;

    public long? SourceId { get; set; }

    public string Description { get; set; } = null!;

    public string Severity { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime OpenedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Capaaction> Capaactions { get; set; } = new List<Capaaction>();

    public virtual Item? Item { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;
}
