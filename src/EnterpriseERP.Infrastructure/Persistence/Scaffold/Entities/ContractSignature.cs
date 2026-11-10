using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class ContractSignature
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long ContractId { get; set; }

    public long PartyId { get; set; }

    public string SignerEmail { get; set; } = null!;

    public string Provider { get; set; } = null!;

    public string? ExternalEnvelopeId { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? SignedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Contract Contract { get; set; } = null!;

    public virtual ContractParty Party { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
