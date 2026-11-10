using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class Bomline
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long Bomid { get; set; }

    public int LineNo { get; set; }

    public long ComponentItemId { get; set; }

    public decimal QuantityPer { get; set; }

    public decimal ScrapPercent { get; set; }

    public long? OperationId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Bomheader Bom { get; set; } = null!;

    public virtual Item ComponentItem { get; set; } = null!;

    public virtual RoutingOperation? Operation { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;
}
