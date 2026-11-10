using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class Supplier
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public string SupplierNo { get; set; } = null!;

    public string LegalName { get; set; } = null!;

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? TaxId { get; set; }

    public int PaymentTermsDays { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Apinvoice> Apinvoices { get; set; } = new List<Apinvoice>();

    public virtual ICollection<Appayment> Appayments { get; set; } = new List<Appayment>();

    public virtual ICollection<ContractParty> ContractParties { get; set; } = new List<ContractParty>();

    public virtual ICollection<PortalAccount> PortalAccounts { get; set; } = new List<PortalAccount>();

    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();

    public virtual ICollection<PurchaseReturn> PurchaseReturns { get; set; } = new List<PurchaseReturn>();

    public virtual ICollection<ReorderPolicy> ReorderPolicies { get; set; } = new List<ReorderPolicy>();

    public virtual ICollection<SupplierClaim> SupplierClaims { get; set; } = new List<SupplierClaim>();

    public virtual ICollection<SupplierContact> SupplierContacts { get; set; } = new List<SupplierContact>();

    public virtual ICollection<SupplierEvaluation> SupplierEvaluations { get; set; } = new List<SupplierEvaluation>();

    public virtual ICollection<SupplierOnboarding> SupplierOnboardings { get; set; } = new List<SupplierOnboarding>();

    public virtual ICollection<SupplierPerformanceMetric> SupplierPerformanceMetrics { get; set; } = new List<SupplierPerformanceMetric>();

    public virtual ICollection<SupplierQuote> SupplierQuotes { get; set; } = new List<SupplierQuote>();

    public virtual Tenant Tenant { get; set; } = null!;
}
