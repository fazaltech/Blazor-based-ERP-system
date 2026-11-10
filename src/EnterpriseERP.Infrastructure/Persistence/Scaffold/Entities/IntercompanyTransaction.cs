using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class IntercompanyTransaction
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long FromLegalEntityId { get; set; }

    public long ToLegalEntityId { get; set; }

    public string DocumentType { get; set; } = null!;

    public long DocumentId { get; set; }

    public decimal Amount { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual LegalEntity FromLegalEntity { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;

    public virtual LegalEntity ToLegalEntity { get; set; } = null!;
}
