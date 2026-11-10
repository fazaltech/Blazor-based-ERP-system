using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class Contract
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public string ContractNo { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string ContractType { get; set; } = null!;

    public long? TemplateId { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public int? RenewalNoticeDays { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public decimal? TotalValue { get; set; }

    public string Status { get; set; } = null!;

    public long? OwnerEmployeeId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<ContractAlert> ContractAlerts { get; set; } = new List<ContractAlert>();

    public virtual ICollection<ContractMilestone> ContractMilestones { get; set; } = new List<ContractMilestone>();

    public virtual ICollection<ContractObligation> ContractObligations { get; set; } = new List<ContractObligation>();

    public virtual ICollection<ContractParty> ContractParties { get; set; } = new List<ContractParty>();

    public virtual ICollection<ContractSignature> ContractSignatures { get; set; } = new List<ContractSignature>();

    public virtual ICollection<ContractVersion> ContractVersions { get; set; } = new List<ContractVersion>();

    public virtual ICollection<EmploymentContract> EmploymentContracts { get; set; } = new List<EmploymentContract>();

    public virtual Employee? OwnerEmployee { get; set; }

    public virtual ICollection<ServiceContract> ServiceContracts { get; set; } = new List<ServiceContract>();

    public virtual ContractTemplate? Template { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;
}
