using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class LegalEntity
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string CountryCode { get; set; } = null!;

    public string? TaxRegistration { get; set; }

    public string FunctionalCurrency { get; set; } = null!;

    public long? ParentLegalEntityId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<BankAccount> BankAccounts { get; set; } = new List<BankAccount>();

    public virtual ICollection<Branch> Branches { get; set; } = new List<Branch>();

    public virtual ICollection<Budget> Budgets { get; set; } = new List<Budget>();

    public virtual ICollection<ConsolidationMember> ConsolidationMembers { get; set; } = new List<ConsolidationMember>();

    public virtual ICollection<ContractParty> ContractParties { get; set; } = new List<ContractParty>();

    public virtual ICollection<CostCenter> CostCenters { get; set; } = new List<CostCenter>();

    public virtual ICollection<FiscalYear> FiscalYears { get; set; } = new List<FiscalYear>();

    public virtual ICollection<FixedAsset> FixedAssets { get; set; } = new List<FixedAsset>();

    public virtual ICollection<Glaccount> Glaccounts { get; set; } = new List<Glaccount>();

    public virtual ICollection<IntercompanyTransaction> IntercompanyTransactionFromLegalEntities { get; set; } = new List<IntercompanyTransaction>();

    public virtual ICollection<IntercompanyTransaction> IntercompanyTransactionToLegalEntities { get; set; } = new List<IntercompanyTransaction>();

    public virtual ICollection<LegalEntity> InverseParentLegalEntity { get; set; } = new List<LegalEntity>();

    public virtual ICollection<JournalBatch> JournalBatches { get; set; } = new List<JournalBatch>();

    public virtual LegalEntity? ParentLegalEntity { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;
}
