using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class ContractVersion
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long ContractId { get; set; }

    public int VersionNumber { get; set; }

    public long DocumentAttachmentId { get; set; }

    public DateTime ChangedAt { get; set; }

    public string? ChangeNotes { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Contract Contract { get; set; } = null!;

    public virtual Attachment DocumentAttachment { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
