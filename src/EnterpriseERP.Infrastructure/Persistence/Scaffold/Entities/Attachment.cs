using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class Attachment
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public string EntityType { get; set; } = null!;

    public long EntityId { get; set; }

    public string FileName { get; set; } = null!;

    public string StorageKey { get; set; } = null!;

    public string MimeType { get; set; } = null!;

    public long SizeBytes { get; set; }

    public long? UploadedByTenantUserId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Candidate> Candidates { get; set; } = new List<Candidate>();

    public virtual ICollection<ContractVersion> ContractVersions { get; set; } = new List<ContractVersion>();

    public virtual ICollection<EngineeringRevision> EngineeringRevisions { get; set; } = new List<EngineeringRevision>();

    public virtual Tenant Tenant { get; set; } = null!;

    public virtual TenantUser? UploadedByTenantUser { get; set; }
}
