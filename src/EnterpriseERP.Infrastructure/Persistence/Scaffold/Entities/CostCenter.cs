using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class CostCenter
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public long LegalEntityId { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public long? ParentCostCenterId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<BudgetLine> BudgetLines { get; set; } = new List<BudgetLine>();

    public virtual ICollection<CostAllocation> CostAllocationDestinationCostCenters { get; set; } = new List<CostAllocation>();

    public virtual ICollection<CostAllocation> CostAllocationSourceCostCenters { get; set; } = new List<CostAllocation>();

    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    public virtual ICollection<CostCenter> InverseParentCostCenter { get; set; } = new List<CostCenter>();

    public virtual ICollection<JournalLine> JournalLines { get; set; } = new List<JournalLine>();

    public virtual LegalEntity LegalEntity { get; set; } = null!;

    public virtual CostCenter? ParentCostCenter { get; set; }

    public virtual Tenant Tenant { get; set; } = null!;
}
