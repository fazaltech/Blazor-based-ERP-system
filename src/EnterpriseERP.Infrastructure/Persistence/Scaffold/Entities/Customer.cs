using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class Customer
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public string CustomerNo { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? TaxId { get; set; }

    public int PaymentTermsDays { get; set; }

    public decimal CreditLimit { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Arinvoice> Arinvoices { get; set; } = new List<Arinvoice>();

    public virtual ICollection<Arreceipt> Arreceipts { get; set; } = new List<Arreceipt>();

    public virtual ICollection<CallCenterCall> CallCenterCalls { get; set; } = new List<CallCenterCall>();

    public virtual ICollection<CampaignMember> CampaignMembers { get; set; } = new List<CampaignMember>();

    public virtual ICollection<ContractParty> ContractParties { get; set; } = new List<ContractParty>();

    public virtual ICollection<CustomerContact> CustomerContacts { get; set; } = new List<CustomerContact>();

    public virtual ICollection<Opportunity> Opportunities { get; set; } = new List<Opportunity>();

    public virtual ICollection<PortalAccount> PortalAccounts { get; set; } = new List<PortalAccount>();

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();

    public virtual ICollection<SalesOrder> SalesOrders { get; set; } = new List<SalesOrder>();

    public virtual ICollection<SalesQuote> SalesQuotes { get; set; } = new List<SalesQuote>();

    public virtual ICollection<SalesReturn> SalesReturns { get; set; } = new List<SalesReturn>();

    public virtual ICollection<ServiceContract> ServiceContracts { get; set; } = new List<ServiceContract>();

    public virtual ICollection<SupportTicket> SupportTickets { get; set; } = new List<SupportTicket>();

    public virtual Tenant Tenant { get; set; } = null!;
}
