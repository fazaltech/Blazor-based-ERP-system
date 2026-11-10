using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class Glaccount
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long LegalEntityId { get; set; }

    public long AccountTypeId { get; set; }

    public long? ParentAccountId { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public bool AllowPosting { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual AccountType AccountType { get; set; } = null!;

    public virtual ICollection<ActivityPool> ActivityPools { get; set; } = new List<ActivityPool>();

    public virtual ICollection<ApinvoiceLine> ApinvoiceLines { get; set; } = new List<ApinvoiceLine>();

    public virtual ICollection<ArinvoiceLine> ArinvoiceLines { get; set; } = new List<ArinvoiceLine>();

    public virtual ICollection<BankAccount> BankAccounts { get; set; } = new List<BankAccount>();

    public virtual ICollection<BudgetLine> BudgetLines { get; set; } = new List<BudgetLine>();

    public virtual ICollection<FixedAssetCategory> FixedAssetCategoryAccumDepGlaccounts { get; set; } = new List<FixedAssetCategory>();

    public virtual ICollection<FixedAssetCategory> FixedAssetCategoryAssetGlaccounts { get; set; } = new List<FixedAssetCategory>();

    public virtual ICollection<FixedAssetCategory> FixedAssetCategoryDepreciationExpenseGlaccounts { get; set; } = new List<FixedAssetCategory>();

    public virtual ICollection<Glaccount> InverseParentAccount { get; set; } = new List<Glaccount>();

    public virtual ICollection<JournalLine> JournalLines { get; set; } = new List<JournalLine>();

    public virtual LegalEntity LegalEntity { get; set; } = null!;

    public virtual Glaccount? ParentAccount { get; set; }

    public virtual ICollection<PayComponent> PayComponents { get; set; } = new List<PayComponent>();

    public virtual ICollection<TaxCode> TaxCodeInputGlaccounts { get; set; } = new List<TaxCode>();

    public virtual ICollection<TaxCode> TaxCodeOutputGlaccounts { get; set; } = new List<TaxCode>();

    public virtual Tenant Tenant { get; set; } = null!;
}
