using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class Tenant
{
    public long Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? LegalName { get; set; }

    public string? TaxNumber { get; set; }

    public string BaseCurrencyCode { get; set; } = null!;

    public string TimeZone { get; set; } = null!;

    public string CountryCode { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<AcademicProgram> AcademicPrograms { get; set; } = new List<AcademicProgram>();

    public virtual ICollection<AcademicTerm> AcademicTerms { get; set; } = new List<AcademicTerm>();

    public virtual ICollection<AcademicYear> AcademicYears { get; set; } = new List<AcademicYear>();

    public virtual ICollection<AccountType> AccountTypes { get; set; } = new List<AccountType>();

    public virtual ICollection<AccountingPeriod> AccountingPeriods { get; set; } = new List<AccountingPeriod>();

    public virtual ICollection<ActivityDriverUsage> ActivityDriverUsages { get; set; } = new List<ActivityDriverUsage>();

    public virtual ICollection<ActivityPool> ActivityPools { get; set; } = new List<ActivityPool>();

    public virtual ICollection<Admission> Admissions { get; set; } = new List<Admission>();

    public virtual ICollection<ApinvoiceLine> ApinvoiceLines { get; set; } = new List<ApinvoiceLine>();

    public virtual ICollection<Apinvoice> Apinvoices { get; set; } = new List<Apinvoice>();

    public virtual ICollection<AppaymentAllocation> AppaymentAllocations { get; set; } = new List<AppaymentAllocation>();

    public virtual ICollection<Appayment> Appayments { get; set; } = new List<Appayment>();

    public virtual ICollection<ApprovalAction> ApprovalActions { get; set; } = new List<ApprovalAction>();

    public virtual ICollection<ApprovalRequest> ApprovalRequests { get; set; } = new List<ApprovalRequest>();

    public virtual ICollection<ApprovalStep> ApprovalSteps { get; set; } = new List<ApprovalStep>();

    public virtual ICollection<ApprovalWorkflow> ApprovalWorkflows { get; set; } = new List<ApprovalWorkflow>();

    public virtual ICollection<ArinvoiceLine> ArinvoiceLines { get; set; } = new List<ArinvoiceLine>();

    public virtual ICollection<Arinvoice> Arinvoices { get; set; } = new List<Arinvoice>();

    public virtual ICollection<ArreceiptAllocation> ArreceiptAllocations { get; set; } = new List<ArreceiptAllocation>();

    public virtual ICollection<Arreceipt> Arreceipts { get; set; } = new List<Arreceipt>();

    public virtual ICollection<AssessmentScore> AssessmentScores { get; set; } = new List<AssessmentScore>();

    public virtual ICollection<Assessment> Assessments { get; set; } = new List<Assessment>();

    public virtual ICollection<AssetDepreciationLine> AssetDepreciationLines { get; set; } = new List<AssetDepreciationLine>();

    public virtual ICollection<AssetDepreciationRun> AssetDepreciationRuns { get; set; } = new List<AssetDepreciationRun>();

    public virtual ICollection<Attachment> Attachments { get; set; } = new List<Attachment>();

    public virtual ICollection<AttendanceRecord> AttendanceRecords { get; set; } = new List<AttendanceRecord>();

    public virtual ICollection<AuditLog> AuditLogs { get; set; } = new List<AuditLog>();

    public virtual ICollection<BankAccount> BankAccounts { get; set; } = new List<BankAccount>();

    public virtual ICollection<BankReconciliationLine> BankReconciliationLines { get; set; } = new List<BankReconciliationLine>();

    public virtual ICollection<BankReconciliation> BankReconciliations { get; set; } = new List<BankReconciliation>();

    public virtual ICollection<BankTransaction> BankTransactions { get; set; } = new List<BankTransaction>();

    public virtual ICollection<BenefitPlan> BenefitPlans { get; set; } = new List<BenefitPlan>();

    public virtual ICollection<Bomheader> Bomheaders { get; set; } = new List<Bomheader>();

    public virtual ICollection<Bomline> Bomlines { get; set; } = new List<Bomline>();

    public virtual ICollection<Branch> Branches { get; set; } = new List<Branch>();

    public virtual ICollection<BudgetLine> BudgetLines { get; set; } = new List<BudgetLine>();

    public virtual ICollection<Budget> Budgets { get; set; } = new List<Budget>();

    public virtual ICollection<CallCenterCall> CallCenterCalls { get; set; } = new List<CallCenterCall>();

    public virtual ICollection<CampaignMember> CampaignMembers { get; set; } = new List<CampaignMember>();

    public virtual ICollection<Campus> Campuses { get; set; } = new List<Campus>();

    public virtual ICollection<Candidate> Candidates { get; set; } = new List<Candidate>();

    public virtual ICollection<Capaaction> Capaactions { get; set; } = new List<Capaaction>();

    public virtual ICollection<CapacityReservation> CapacityReservations { get; set; } = new List<CapacityReservation>();

    public virtual ICollection<ClassSection> ClassSections { get; set; } = new List<ClassSection>();

    public virtual ICollection<ClassSession> ClassSessions { get; set; } = new List<ClassSession>();

    public virtual ICollection<ConsolidationGroup> ConsolidationGroups { get; set; } = new List<ConsolidationGroup>();

    public virtual ICollection<ConsolidationMember> ConsolidationMembers { get; set; } = new List<ConsolidationMember>();

    public virtual ICollection<ConsolidationRun> ConsolidationRuns { get; set; } = new List<ConsolidationRun>();

    public virtual ICollection<ContractAlert> ContractAlerts { get; set; } = new List<ContractAlert>();

    public virtual ICollection<ContractMilestone> ContractMilestones { get; set; } = new List<ContractMilestone>();

    public virtual ICollection<ContractObligation> ContractObligations { get; set; } = new List<ContractObligation>();

    public virtual ICollection<ContractParty> ContractParties { get; set; } = new List<ContractParty>();

    public virtual ICollection<ContractSignature> ContractSignatures { get; set; } = new List<ContractSignature>();

    public virtual ICollection<ContractTemplate> ContractTemplates { get; set; } = new List<ContractTemplate>();

    public virtual ICollection<ContractVersion> ContractVersions { get; set; } = new List<ContractVersion>();

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    public virtual ICollection<CostAllocation> CostAllocations { get; set; } = new List<CostAllocation>();

    public virtual ICollection<CostCenter> CostCenters { get; set; } = new List<CostCenter>();

    public virtual ICollection<CostDriver> CostDrivers { get; set; } = new List<CostDriver>();

    public virtual ICollection<CostObject> CostObjects { get; set; } = new List<CostObject>();

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    public virtual ICollection<CreditCheck> CreditChecks { get; set; } = new List<CreditCheck>();

    public virtual ICollection<CustomerContact> CustomerContacts { get; set; } = new List<CustomerContact>();

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual ICollection<DeliveryRoute> DeliveryRoutes { get; set; } = new List<DeliveryRoute>();

    public virtual ICollection<DeliveryStop> DeliveryStops { get; set; } = new List<DeliveryStop>();

    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    public virtual ICollection<EmployeeBenefit> EmployeeBenefits { get; set; } = new List<EmployeeBenefit>();

    public virtual ICollection<EmployeeDemographic> EmployeeDemographics { get; set; } = new List<EmployeeDemographic>();

    public virtual ICollection<EmployeePension> EmployeePensions { get; set; } = new List<EmployeePension>();

    public virtual ICollection<EmployeeSeparation> EmployeeSeparations { get; set; } = new List<EmployeeSeparation>();

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<EmploymentContract> EmploymentContracts { get; set; } = new List<EmploymentContract>();

    public virtual ICollection<EngineeringRevision> EngineeringRevisions { get; set; } = new List<EngineeringRevision>();

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    public virtual ICollection<ExchangeRate> ExchangeRates { get; set; } = new List<ExchangeRate>();

    public virtual ICollection<FeeStructure> FeeStructures { get; set; } = new List<FeeStructure>();

    public virtual ICollection<FiscalYear> FiscalYears { get; set; } = new List<FiscalYear>();

    public virtual ICollection<FixedAssetCategory> FixedAssetCategories { get; set; } = new List<FixedAssetCategory>();

    public virtual ICollection<FixedAsset> FixedAssets { get; set; } = new List<FixedAsset>();

    public virtual ICollection<Glaccount> Glaccounts { get; set; } = new List<Glaccount>();

    public virtual ICollection<GoodsReceiptLine> GoodsReceiptLines { get; set; } = new List<GoodsReceiptLine>();

    public virtual ICollection<GoodsReceipt> GoodsReceipts { get; set; } = new List<GoodsReceipt>();

    public virtual ICollection<IntegrationEndpoint> IntegrationEndpoints { get; set; } = new List<IntegrationEndpoint>();

    public virtual ICollection<IntegrationMessage> IntegrationMessages { get; set; } = new List<IntegrationMessage>();

    public virtual ICollection<IntercompanyTransaction> IntercompanyTransactions { get; set; } = new List<IntercompanyTransaction>();

    public virtual ICollection<Interview> Interviews { get; set; } = new List<Interview>();

    public virtual ICollection<InventoryBalance> InventoryBalances { get; set; } = new List<InventoryBalance>();

    public virtual ICollection<InventoryLot> InventoryLots { get; set; } = new List<InventoryLot>();

    public virtual ICollection<InventoryReservation> InventoryReservations { get; set; } = new List<InventoryReservation>();

    public virtual ICollection<InventorySerial> InventorySerials { get; set; } = new List<InventorySerial>();

    public virtual ICollection<InventoryTransaction> InventoryTransactions { get; set; } = new List<InventoryTransaction>();

    public virtual ICollection<ItemCategory> ItemCategories { get; set; } = new List<ItemCategory>();

    public virtual ICollection<ItemPrice> ItemPrices { get; set; } = new List<ItemPrice>();

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();

    public virtual ICollection<JobApplication> JobApplications { get; set; } = new List<JobApplication>();

    public virtual ICollection<JobPosition> JobPositions { get; set; } = new List<JobPosition>();

    public virtual ICollection<JournalBatch> JournalBatches { get; set; } = new List<JournalBatch>();

    public virtual ICollection<JournalEntry> JournalEntries { get; set; } = new List<JournalEntry>();

    public virtual ICollection<JournalLine> JournalLines { get; set; } = new List<JournalLine>();

    public virtual ICollection<Kpivalue> Kpivalues { get; set; } = new List<Kpivalue>();

    public virtual ICollection<Lead> Leads { get; set; } = new List<Lead>();

    public virtual ICollection<LeaveBalance> LeaveBalances { get; set; } = new List<LeaveBalance>();

    public virtual ICollection<LeaveRequest> LeaveRequests { get; set; } = new List<LeaveRequest>();

    public virtual ICollection<LeaveType> LeaveTypes { get; set; } = new List<LeaveType>();

    public virtual ICollection<LegalEntity> LegalEntities { get; set; } = new List<LegalEntity>();

    public virtual ICollection<ManagementKpi> ManagementKpis { get; set; } = new List<ManagementKpi>();

    public virtual ICollection<MarketingCampaign> MarketingCampaigns { get; set; } = new List<MarketingCampaign>();

    public virtual ICollection<MaterialIssue> MaterialIssues { get; set; } = new List<MaterialIssue>();

    public virtual ICollection<NonConformance> NonConformances { get; set; } = new List<NonConformance>();

    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();

    public virtual ICollection<NumberSequence> NumberSequences { get; set; } = new List<NumberSequence>();

    public virtual ICollection<Opportunity> Opportunities { get; set; } = new List<Opportunity>();

    public virtual ICollection<OpportunityActivity> OpportunityActivities { get; set; } = new List<OpportunityActivity>();

    public virtual ICollection<PayComponent> PayComponents { get; set; } = new List<PayComponent>();

    public virtual ICollection<PayGrade> PayGrades { get; set; } = new List<PayGrade>();

    public virtual ICollection<PayrollPeriod> PayrollPeriods { get; set; } = new List<PayrollPeriod>();

    public virtual ICollection<PayrollRun> PayrollRuns { get; set; } = new List<PayrollRun>();

    public virtual ICollection<PayslipLine> PayslipLines { get; set; } = new List<PayslipLine>();

    public virtual ICollection<Payslip> Payslips { get; set; } = new List<Payslip>();

    public virtual ICollection<PensionPlan> PensionPlans { get; set; } = new List<PensionPlan>();

    public virtual ICollection<PerformanceReview> PerformanceReviews { get; set; } = new List<PerformanceReview>();

    public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();

    public virtual ICollection<PortalAccount> PortalAccounts { get; set; } = new List<PortalAccount>();

    public virtual ICollection<PriceList> PriceLists { get; set; } = new List<PriceList>();

    public virtual ICollection<ProductLifecycleChange> ProductLifecycleChanges { get; set; } = new List<ProductLifecycleChange>();

    public virtual ICollection<ProductionPlanLine> ProductionPlanLines { get; set; } = new List<ProductionPlanLine>();

    public virtual ICollection<ProductionPlan> ProductionPlans { get; set; } = new List<ProductionPlan>();

    public virtual ICollection<ProductionReceipt> ProductionReceipts { get; set; } = new List<ProductionReceipt>();

    public virtual ICollection<ProjectBilling> ProjectBillings { get; set; } = new List<ProjectBilling>();

    public virtual ICollection<ProjectExpense> ProjectExpenses { get; set; } = new List<ProjectExpense>();

    public virtual ICollection<ProjectMilestone> ProjectMilestones { get; set; } = new List<ProjectMilestone>();

    public virtual ICollection<ProjectResource> ProjectResources { get; set; } = new List<ProjectResource>();

    public virtual ICollection<ProjectRiskRegister> ProjectRiskRegisters { get; set; } = new List<ProjectRiskRegister>();

    public virtual ICollection<ProjectTask> ProjectTasks { get; set; } = new List<ProjectTask>();

    public virtual ICollection<ProjectWb> ProjectWbs { get; set; } = new List<ProjectWb>();

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();

    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; set; } = new List<PurchaseOrderLine>();

    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();

    public virtual ICollection<PurchaseRequisitionLine> PurchaseRequisitionLines { get; set; } = new List<PurchaseRequisitionLine>();

    public virtual ICollection<PurchaseRequisition> PurchaseRequisitions { get; set; } = new List<PurchaseRequisition>();

    public virtual ICollection<PurchaseReturnLine> PurchaseReturnLines { get; set; } = new List<PurchaseReturnLine>();

    public virtual ICollection<PurchaseReturn> PurchaseReturns { get; set; } = new List<PurchaseReturn>();

    public virtual ICollection<QualityInspectionPlan> QualityInspectionPlans { get; set; } = new List<QualityInspectionPlan>();

    public virtual ICollection<QualityInspectionResult> QualityInspectionResults { get; set; } = new List<QualityInspectionResult>();

    public virtual ICollection<QualityInspectionTest> QualityInspectionTests { get; set; } = new List<QualityInspectionTest>();

    public virtual ICollection<QualityInspection> QualityInspections { get; set; } = new List<QualityInspection>();

    public virtual ICollection<RecruitmentRequisition> RecruitmentRequisitions { get; set; } = new List<RecruitmentRequisition>();

    public virtual ICollection<ReorderPolicy> ReorderPolicies { get; set; } = new List<ReorderPolicy>();

    public virtual ICollection<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();

    public virtual ICollection<RoutingOperation> RoutingOperations { get; set; } = new List<RoutingOperation>();

    public virtual ICollection<Routing> Routings { get; set; } = new List<Routing>();

    public virtual ICollection<SalesCommission> SalesCommissions { get; set; } = new List<SalesCommission>();

    public virtual ICollection<SalesOrderLine> SalesOrderLines { get; set; } = new List<SalesOrderLine>();

    public virtual ICollection<SalesOrder> SalesOrders { get; set; } = new List<SalesOrder>();

    public virtual ICollection<SalesQuoteLine> SalesQuoteLines { get; set; } = new List<SalesQuoteLine>();

    public virtual ICollection<SalesQuote> SalesQuotes { get; set; } = new List<SalesQuote>();

    public virtual ICollection<SalesReturnLine> SalesReturnLines { get; set; } = new List<SalesReturnLine>();

    public virtual ICollection<SalesReturn> SalesReturns { get; set; } = new List<SalesReturn>();

    public virtual ICollection<SelfServiceRequest> SelfServiceRequests { get; set; } = new List<SelfServiceRequest>();

    public virtual ICollection<ServiceContract> ServiceContracts { get; set; } = new List<ServiceContract>();

    public virtual ICollection<ShiftAssignment> ShiftAssignments { get; set; } = new List<ShiftAssignment>();

    public virtual ICollection<Shift> Shifts { get; set; } = new List<Shift>();

    public virtual ICollection<ShipmentLine> ShipmentLines { get; set; } = new List<ShipmentLine>();

    public virtual ICollection<Shipment> Shipments { get; set; } = new List<Shipment>();

    public virtual ICollection<Slaevent> Slaevents { get; set; } = new List<Slaevent>();

    public virtual ICollection<StockCountLine> StockCountLines { get; set; } = new List<StockCountLine>();

    public virtual ICollection<StockCount> StockCounts { get; set; } = new List<StockCount>();

    public virtual ICollection<StockTransferLine> StockTransferLines { get; set; } = new List<StockTransferLine>();

    public virtual ICollection<StockTransfer> StockTransfers { get; set; } = new List<StockTransfer>();

    public virtual ICollection<StudentAttendance> StudentAttendances { get; set; } = new List<StudentAttendance>();

    public virtual ICollection<StudentFeeInvoice> StudentFeeInvoices { get; set; } = new List<StudentFeeInvoice>();

    public virtual ICollection<StudentFeePayment> StudentFeePayments { get; set; } = new List<StudentFeePayment>();

    public virtual ICollection<StudentGuardian> StudentGuardians { get; set; } = new List<StudentGuardian>();

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    public virtual ICollection<SupplierClaim> SupplierClaims { get; set; } = new List<SupplierClaim>();

    public virtual ICollection<SupplierContact> SupplierContacts { get; set; } = new List<SupplierContact>();

    public virtual ICollection<SupplierEvaluation> SupplierEvaluations { get; set; } = new List<SupplierEvaluation>();

    public virtual ICollection<SupplierOnboarding> SupplierOnboardings { get; set; } = new List<SupplierOnboarding>();

    public virtual ICollection<SupplierPerformanceMetric> SupplierPerformanceMetrics { get; set; } = new List<SupplierPerformanceMetric>();

    public virtual ICollection<SupplierQuoteLine> SupplierQuoteLines { get; set; } = new List<SupplierQuoteLine>();

    public virtual ICollection<SupplierQuote> SupplierQuotes { get; set; } = new List<SupplierQuote>();

    public virtual ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();

    public virtual ICollection<SupportTicket> SupportTickets { get; set; } = new List<SupportTicket>();

    public virtual ICollection<TaxCode> TaxCodes { get; set; } = new List<TaxCode>();

    public virtual ICollection<TenantUser> TenantUsers { get; set; } = new List<TenantUser>();

    public virtual ICollection<TicketMessage> TicketMessages { get; set; } = new List<TicketMessage>();

    public virtual ICollection<TimesheetLine> TimesheetLines { get; set; } = new List<TimesheetLine>();

    public virtual ICollection<Timesheet> Timesheets { get; set; } = new List<Timesheet>();

    public virtual ICollection<TrainingCourse> TrainingCourses { get; set; } = new List<TrainingCourse>();

    public virtual ICollection<TrainingEnrollment> TrainingEnrollments { get; set; } = new List<TrainingEnrollment>();

    public virtual ICollection<UnitsOfMeasure> UnitsOfMeasures { get; set; } = new List<UnitsOfMeasure>();

    public virtual ICollection<Uomconversion> Uomconversions { get; set; } = new List<Uomconversion>();

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();

    public virtual ICollection<WarehouseLocation> WarehouseLocations { get; set; } = new List<WarehouseLocation>();

    public virtual ICollection<Warehouse> Warehouses { get; set; } = new List<Warehouse>();

    public virtual ICollection<WorkCenter> WorkCenters { get; set; } = new List<WorkCenter>();

    public virtual ICollection<WorkOrderOperation> WorkOrderOperations { get; set; } = new List<WorkOrderOperation>();

    public virtual ICollection<WorkOrder> WorkOrders { get; set; } = new List<WorkOrder>();
}
