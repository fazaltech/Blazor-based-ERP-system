using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class ContractParty
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long ContractId { get; set; }

    public string PartyType { get; set; } = null!;

    public long? CustomerId { get; set; }

    public long? SupplierId { get; set; }

    public long? LegalEntityId { get; set; }

    public string? SignatoryName { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Contract Contract { get; set; } = null!;

    public virtual ICollection<ContractSignature> ContractSignatures { get; set; } = new List<ContractSignature>();

    public virtual Customer? Customer { get; set; }

    public virtual LegalEntity? LegalEntity { get; set; }

    public virtual Supplier? Supplier { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;
}
