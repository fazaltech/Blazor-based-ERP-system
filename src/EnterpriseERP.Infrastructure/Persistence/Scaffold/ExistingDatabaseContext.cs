using System;
using System.Collections.Generic;
using EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;
using Microsoft.EntityFrameworkCore;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold;

public partial class ERPDbContext : DbContext
{
    public ERPDbContext(DbContextOptions<ERPDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AcademicProgram> AcademicPrograms { get; set; }

    public virtual DbSet<AcademicTerm> AcademicTerms { get; set; }

    public virtual DbSet<AcademicYear> AcademicYears { get; set; }

    public virtual DbSet<AccountType> AccountTypes { get; set; }

    public virtual DbSet<AccountingPeriod> AccountingPeriods { get; set; }

    public virtual DbSet<ActivityDriverUsage> ActivityDriverUsages { get; set; }

    public virtual DbSet<ActivityPool> ActivityPools { get; set; }

    public virtual DbSet<Admission> Admissions { get; set; }

    public virtual DbSet<Apinvoice> Apinvoices { get; set; }

    public virtual DbSet<ApinvoiceLine> ApinvoiceLines { get; set; }

    public virtual DbSet<Appayment> Appayments { get; set; }

    public virtual DbSet<AppaymentAllocation> AppaymentAllocations { get; set; }

    public virtual DbSet<ApprovalAction> ApprovalActions { get; set; }

    public virtual DbSet<ApprovalRequest> ApprovalRequests { get; set; }

    public virtual DbSet<ApprovalStep> ApprovalSteps { get; set; }

    public virtual DbSet<ApprovalWorkflow> ApprovalWorkflows { get; set; }

    public virtual DbSet<Arinvoice> Arinvoices { get; set; }

    public virtual DbSet<ArinvoiceLine> ArinvoiceLines { get; set; }

    public virtual DbSet<Arreceipt> Arreceipts { get; set; }

    public virtual DbSet<ArreceiptAllocation> ArreceiptAllocations { get; set; }

    public virtual DbSet<Assessment> Assessments { get; set; }

    public virtual DbSet<AssessmentScore> AssessmentScores { get; set; }

    public virtual DbSet<AssetDepreciationLine> AssetDepreciationLines { get; set; }

    public virtual DbSet<AssetDepreciationRun> AssetDepreciationRuns { get; set; }

    public virtual DbSet<Attachment> Attachments { get; set; }

    public virtual DbSet<AttendanceRecord> AttendanceRecords { get; set; }

    public virtual DbSet<AuditLog> AuditLogs { get; set; }

    public virtual DbSet<BankAccount> BankAccounts { get; set; }

    public virtual DbSet<BankReconciliation> BankReconciliations { get; set; }

    public virtual DbSet<BankReconciliationLine> BankReconciliationLines { get; set; }

    public virtual DbSet<BankTransaction> BankTransactions { get; set; }

    public virtual DbSet<BenefitPlan> BenefitPlans { get; set; }

    public virtual DbSet<Bomheader> Bomheaders { get; set; }

    public virtual DbSet<Bomline> Bomlines { get; set; }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<Budget> Budgets { get; set; }

    public virtual DbSet<BudgetLine> BudgetLines { get; set; }

    public virtual DbSet<CallCenterCall> CallCenterCalls { get; set; }

    public virtual DbSet<CampaignMember> CampaignMembers { get; set; }

    public virtual DbSet<Campus> Campuses { get; set; }

    public virtual DbSet<Candidate> Candidates { get; set; }

    public virtual DbSet<Capaaction> Capaactions { get; set; }

    public virtual DbSet<CapacityReservation> CapacityReservations { get; set; }

    public virtual DbSet<ClassSection> ClassSections { get; set; }

    public virtual DbSet<ClassSession> ClassSessions { get; set; }

    public virtual DbSet<ConsolidationGroup> ConsolidationGroups { get; set; }

    public virtual DbSet<ConsolidationMember> ConsolidationMembers { get; set; }

    public virtual DbSet<ConsolidationRun> ConsolidationRuns { get; set; }

    public virtual DbSet<Contract> Contracts { get; set; }

    public virtual DbSet<ContractAlert> ContractAlerts { get; set; }

    public virtual DbSet<ContractMilestone> ContractMilestones { get; set; }

    public virtual DbSet<ContractObligation> ContractObligations { get; set; }

    public virtual DbSet<ContractParty> ContractParties { get; set; }

    public virtual DbSet<ContractSignature> ContractSignatures { get; set; }

    public virtual DbSet<ContractTemplate> ContractTemplates { get; set; }

    public virtual DbSet<ContractVersion> ContractVersions { get; set; }

    public virtual DbSet<CostAllocation> CostAllocations { get; set; }

    public virtual DbSet<CostCenter> CostCenters { get; set; }

    public virtual DbSet<CostDriver> CostDrivers { get; set; }

    public virtual DbSet<CostObject> CostObjects { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<CreditCheck> CreditChecks { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerContact> CustomerContacts { get; set; }

    public virtual DbSet<DeliveryRoute> DeliveryRoutes { get; set; }

    public virtual DbSet<DeliveryStop> DeliveryStops { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeBenefit> EmployeeBenefits { get; set; }

    public virtual DbSet<EmployeeDemographic> EmployeeDemographics { get; set; }

    public virtual DbSet<EmployeePension> EmployeePensions { get; set; }

    public virtual DbSet<EmployeeSeparation> EmployeeSeparations { get; set; }

    public virtual DbSet<EmploymentContract> EmploymentContracts { get; set; }

    public virtual DbSet<EngineeringRevision> EngineeringRevisions { get; set; }

    public virtual DbSet<Enrollment> Enrollments { get; set; }

    public virtual DbSet<ExchangeRate> ExchangeRates { get; set; }

    public virtual DbSet<FeeStructure> FeeStructures { get; set; }

    public virtual DbSet<FiscalYear> FiscalYears { get; set; }

    public virtual DbSet<FixedAsset> FixedAssets { get; set; }

    public virtual DbSet<FixedAssetCategory> FixedAssetCategories { get; set; }

    public virtual DbSet<Glaccount> Glaccounts { get; set; }

    public virtual DbSet<GoodsReceipt> GoodsReceipts { get; set; }

    public virtual DbSet<GoodsReceiptLine> GoodsReceiptLines { get; set; }

    public virtual DbSet<IntegrationEndpoint> IntegrationEndpoints { get; set; }

    public virtual DbSet<IntegrationMessage> IntegrationMessages { get; set; }

    public virtual DbSet<IntercompanyTransaction> IntercompanyTransactions { get; set; }

    public virtual DbSet<Interview> Interviews { get; set; }

    public virtual DbSet<InventoryBalance> InventoryBalances { get; set; }

    public virtual DbSet<InventoryLot> InventoryLots { get; set; }

    public virtual DbSet<InventoryReservation> InventoryReservations { get; set; }

    public virtual DbSet<InventorySerial> InventorySerials { get; set; }

    public virtual DbSet<InventoryTransaction> InventoryTransactions { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<ItemCategory> ItemCategories { get; set; }

    public virtual DbSet<ItemPrice> ItemPrices { get; set; }

    public virtual DbSet<JobApplication> JobApplications { get; set; }

    public virtual DbSet<JobPosition> JobPositions { get; set; }

    public virtual DbSet<JournalBatch> JournalBatches { get; set; }

    public virtual DbSet<JournalEntry> JournalEntries { get; set; }

    public virtual DbSet<JournalLine> JournalLines { get; set; }

    public virtual DbSet<Kpivalue> Kpivalues { get; set; }

    public virtual DbSet<Lead> Leads { get; set; }

    public virtual DbSet<LeaveBalance> LeaveBalances { get; set; }

    public virtual DbSet<LeaveRequest> LeaveRequests { get; set; }

    public virtual DbSet<LeaveType> LeaveTypes { get; set; }

    public virtual DbSet<LegalEntity> LegalEntities { get; set; }

    public virtual DbSet<ManagementKpi> ManagementKpis { get; set; }

    public virtual DbSet<MarketingCampaign> MarketingCampaigns { get; set; }

    public virtual DbSet<MaterialIssue> MaterialIssues { get; set; }

    public virtual DbSet<NonConformance> NonConformances { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<NumberSequence> NumberSequences { get; set; }

    public virtual DbSet<Opportunity> Opportunities { get; set; }

    public virtual DbSet<OpportunityActivity> OpportunityActivities { get; set; }

    public virtual DbSet<PayComponent> PayComponents { get; set; }

    public virtual DbSet<PayGrade> PayGrades { get; set; }

    public virtual DbSet<PayrollPeriod> PayrollPeriods { get; set; }

    public virtual DbSet<PayrollRun> PayrollRuns { get; set; }

    public virtual DbSet<Payslip> Payslips { get; set; }

    public virtual DbSet<PayslipLine> PayslipLines { get; set; }

    public virtual DbSet<PensionPlan> PensionPlans { get; set; }

    public virtual DbSet<PerformanceReview> PerformanceReviews { get; set; }

    public virtual DbSet<Permission> Permissions { get; set; }

    public virtual DbSet<PortalAccount> PortalAccounts { get; set; }

    public virtual DbSet<PriceList> PriceLists { get; set; }

    public virtual DbSet<ProductLifecycleChange> ProductLifecycleChanges { get; set; }

    public virtual DbSet<ProductionPlan> ProductionPlans { get; set; }

    public virtual DbSet<ProductionPlanLine> ProductionPlanLines { get; set; }

    public virtual DbSet<ProductionReceipt> ProductionReceipts { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<ProjectBilling> ProjectBillings { get; set; }

    public virtual DbSet<ProjectExpense> ProjectExpenses { get; set; }

    public virtual DbSet<ProjectMilestone> ProjectMilestones { get; set; }

    public virtual DbSet<ProjectResource> ProjectResources { get; set; }

    public virtual DbSet<ProjectRiskRegister> ProjectRiskRegisters { get; set; }

    public virtual DbSet<ProjectTask> ProjectTasks { get; set; }

    public virtual DbSet<ProjectWb> ProjectWbs { get; set; }

    public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }

    public virtual DbSet<PurchaseOrderLine> PurchaseOrderLines { get; set; }

    public virtual DbSet<PurchaseRequisition> PurchaseRequisitions { get; set; }

    public virtual DbSet<PurchaseRequisitionLine> PurchaseRequisitionLines { get; set; }

    public virtual DbSet<PurchaseReturn> PurchaseReturns { get; set; }

    public virtual DbSet<PurchaseReturnLine> PurchaseReturnLines { get; set; }

    public virtual DbSet<QualityInspection> QualityInspections { get; set; }

    public virtual DbSet<QualityInspectionPlan> QualityInspectionPlans { get; set; }

    public virtual DbSet<QualityInspectionResult> QualityInspectionResults { get; set; }

    public virtual DbSet<QualityInspectionTest> QualityInspectionTests { get; set; }

    public virtual DbSet<RecruitmentRequisition> RecruitmentRequisitions { get; set; }

    public virtual DbSet<ReorderPolicy> ReorderPolicies { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RolePermission> RolePermissions { get; set; }

    public virtual DbSet<Routing> Routings { get; set; }

    public virtual DbSet<RoutingOperation> RoutingOperations { get; set; }

    public virtual DbSet<SalesCommission> SalesCommissions { get; set; }

    public virtual DbSet<SalesOrder> SalesOrders { get; set; }

    public virtual DbSet<SalesOrderLine> SalesOrderLines { get; set; }

    public virtual DbSet<SalesQuote> SalesQuotes { get; set; }

    public virtual DbSet<SalesQuoteLine> SalesQuoteLines { get; set; }

    public virtual DbSet<SalesReturn> SalesReturns { get; set; }

    public virtual DbSet<SalesReturnLine> SalesReturnLines { get; set; }

    public virtual DbSet<SelfServiceRequest> SelfServiceRequests { get; set; }

    public virtual DbSet<ServiceContract> ServiceContracts { get; set; }

    public virtual DbSet<Shift> Shifts { get; set; }

    public virtual DbSet<ShiftAssignment> ShiftAssignments { get; set; }

    public virtual DbSet<Shipment> Shipments { get; set; }

    public virtual DbSet<ShipmentLine> ShipmentLines { get; set; }

    public virtual DbSet<Slaevent> Slaevents { get; set; }

    public virtual DbSet<StockCount> StockCounts { get; set; }

    public virtual DbSet<StockCountLine> StockCountLines { get; set; }

    public virtual DbSet<StockTransfer> StockTransfers { get; set; }

    public virtual DbSet<StockTransferLine> StockTransferLines { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentAttendance> StudentAttendances { get; set; }

    public virtual DbSet<StudentFeeInvoice> StudentFeeInvoices { get; set; }

    public virtual DbSet<StudentFeePayment> StudentFeePayments { get; set; }

    public virtual DbSet<StudentGuardian> StudentGuardians { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<SupplierClaim> SupplierClaims { get; set; }

    public virtual DbSet<SupplierContact> SupplierContacts { get; set; }

    public virtual DbSet<SupplierEvaluation> SupplierEvaluations { get; set; }

    public virtual DbSet<SupplierOnboarding> SupplierOnboardings { get; set; }

    public virtual DbSet<SupplierPerformanceMetric> SupplierPerformanceMetrics { get; set; }

    public virtual DbSet<SupplierQuote> SupplierQuotes { get; set; }

    public virtual DbSet<SupplierQuoteLine> SupplierQuoteLines { get; set; }

    public virtual DbSet<SupportTicket> SupportTickets { get; set; }

    public virtual DbSet<TaxCode> TaxCodes { get; set; }

    public virtual DbSet<Tenant> Tenants { get; set; }

    public virtual DbSet<TenantUser> TenantUsers { get; set; }

    public virtual DbSet<TicketMessage> TicketMessages { get; set; }

    public virtual DbSet<Timesheet> Timesheets { get; set; }

    public virtual DbSet<TimesheetLine> TimesheetLines { get; set; }

    public virtual DbSet<TrainingCourse> TrainingCourses { get; set; }

    public virtual DbSet<TrainingEnrollment> TrainingEnrollments { get; set; }

    public virtual DbSet<UnitsOfMeasure> UnitsOfMeasures { get; set; }

    public virtual DbSet<Uomconversion> Uomconversions { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    public virtual DbSet<Warehouse> Warehouses { get; set; }

    public virtual DbSet<WarehouseLocation> WarehouseLocations { get; set; }

    public virtual DbSet<WorkCenter> WorkCenters { get; set; }

    public virtual DbSet<WorkOrder> WorkOrders { get; set; }

    public virtual DbSet<WorkOrderOperation> WorkOrderOperations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AcademicProgram>(entity =>
        {
            entity.ToTable("AcademicPrograms", "erp_education");

            entity.HasIndex(e => e.TenantId, "IX_AcademicPrograms_TenantId");

            entity.Property(e => e.Code).HasMaxLength(40);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Name).HasMaxLength(160);
            entity.Property(e => e.ProgramLevel).HasMaxLength(30);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Campus).WithMany(p => p.AcademicPrograms)
                .HasForeignKey(d => d.CampusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AcademicPrograms_CampusId_Campuses");

            entity.HasOne(d => d.Tenant).WithMany(p => p.AcademicPrograms)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AcademicPrograms_TenantId_Tenants");
        });

        modelBuilder.Entity<AcademicTerm>(entity =>
        {
            entity.ToTable("AcademicTerms", "erp_education");

            entity.HasIndex(e => e.TenantId, "IX_AcademicTerms_TenantId");

            entity.Property(e => e.Code).HasMaxLength(30);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.AcademicYear).WithMany(p => p.AcademicTerms)
                .HasForeignKey(d => d.AcademicYearId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AcademicTerms_AcademicYearId_AcademicYears");

            entity.HasOne(d => d.Tenant).WithMany(p => p.AcademicTerms)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AcademicTerms_TenantId_Tenants");
        });

        modelBuilder.Entity<AcademicYear>(entity =>
        {
            entity.ToTable("AcademicYears", "erp_education");

            entity.HasIndex(e => e.TenantId, "IX_AcademicYears_TenantId");

            entity.Property(e => e.Code).HasMaxLength(30);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Campus).WithMany(p => p.AcademicYears)
                .HasForeignKey(d => d.CampusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AcademicYears_CampusId_Campuses");

            entity.HasOne(d => d.Tenant).WithMany(p => p.AcademicYears)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AcademicYears_TenantId_Tenants");
        });

        modelBuilder.Entity<AccountType>(entity =>
        {
            entity.ToTable("AccountTypes", "erp_finance");

            entity.HasIndex(e => e.TenantId, "IX_AccountTypes_TenantId");

            entity.Property(e => e.Code).HasMaxLength(30);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Name).HasMaxLength(80);
            entity.Property(e => e.NormalBalance).HasMaxLength(6);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Tenant).WithMany(p => p.AccountTypes)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountTypes_TenantId_Tenants");
        });

        modelBuilder.Entity<AccountingPeriod>(entity =>
        {
            entity.ToTable("AccountingPeriods", "erp_finance");

            entity.HasIndex(e => e.TenantId, "IX_AccountingPeriods_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.FiscalYear).WithMany(p => p.AccountingPeriods)
                .HasForeignKey(d => d.FiscalYearId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountingPeriods_FiscalYearId_FiscalYears");

            entity.HasOne(d => d.Tenant).WithMany(p => p.AccountingPeriods)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountingPeriods_TenantId_Tenants");
        });

        modelBuilder.Entity<ActivityDriverUsage>(entity =>
        {
            entity.ToTable("ActivityDriverUsage", "erp_management");

            entity.HasIndex(e => e.TenantId, "IX_ActivityDriverUsage_TenantId");

            entity.Property(e => e.AllocatedCost).HasPrecision(19, 4);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.DriverQuantity).HasPrecision(19, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.ActivityPool).WithMany(p => p.ActivityDriverUsages)
                .HasForeignKey(d => d.ActivityPoolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ActivityDriverUsage_ActivityPoolId_ActivityPools");

            entity.HasOne(d => d.CostDriver).WithMany(p => p.ActivityDriverUsages)
                .HasForeignKey(d => d.CostDriverId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ActivityDriverUsage_CostDriverId_CostDrivers");

            entity.HasOne(d => d.CostObject).WithMany(p => p.ActivityDriverUsages)
                .HasForeignKey(d => d.CostObjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ActivityDriverUsage_CostObjectId_CostObjects");

            entity.HasOne(d => d.Period).WithMany(p => p.ActivityDriverUsages)
                .HasForeignKey(d => d.PeriodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ActivityDriverUsage_PeriodId_AccountingPeriods");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ActivityDriverUsages)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ActivityDriverUsage_TenantId_Tenants");
        });

        modelBuilder.Entity<ActivityPool>(entity =>
        {
            entity.ToTable("ActivityPools", "erp_management");

            entity.HasIndex(e => e.TenantId, "IX_ActivityPools_TenantId");

            entity.Property(e => e.Code).HasMaxLength(40);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.GlaccountId).HasColumnName("GLAccountId");
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Glaccount).WithMany(p => p.ActivityPools)
                .HasForeignKey(d => d.GlaccountId)
                .HasConstraintName("FK_ActivityPools_GLAccountId_GLAccounts");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ActivityPools)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ActivityPools_TenantId_Tenants");
        });

        modelBuilder.Entity<Admission>(entity =>
        {
            entity.ToTable("Admissions", "erp_education");

            entity.HasIndex(e => e.TenantId, "IX_Admissions_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Decision).HasMaxLength(30);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.AcademicYear).WithMany(p => p.Admissions)
                .HasForeignKey(d => d.AcademicYearId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Admissions_AcademicYearId_AcademicYears");

            entity.HasOne(d => d.Program).WithMany(p => p.Admissions)
                .HasForeignKey(d => d.ProgramId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Admissions_ProgramId_AcademicPrograms");

            entity.HasOne(d => d.Student).WithMany(p => p.Admissions)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Admissions_StudentId_Students");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Admissions)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Admissions_TenantId_Tenants");
        });

        modelBuilder.Entity<Apinvoice>(entity =>
        {
            entity.ToTable("APInvoices", "erp_finance");

            entity.HasIndex(e => e.TenantId, "IX_APInvoices_TenantId");

            entity.HasIndex(e => new { e.TenantId, e.SupplierId, e.InvoiceNo }, "UX_APInvoices_SupplierId_InvoiceNo").IsUnique();

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.ExchangeRate).HasPrecision(20, 10);
            entity.Property(e => e.InvoiceNo).HasMaxLength(80);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.Subtotal).HasPrecision(19, 4);
            entity.Property(e => e.TaxAmount).HasPrecision(19, 4);
            entity.Property(e => e.Total).HasPrecision(19, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.JournalEntry).WithMany(p => p.Apinvoices)
                .HasForeignKey(d => d.JournalEntryId)
                .HasConstraintName("FK_APInvoices_JournalEntryId_JournalEntries");

            entity.HasOne(d => d.PurchaseOrder).WithMany(p => p.Apinvoices)
                .HasForeignKey(d => d.PurchaseOrderId)
                .HasConstraintName("FK_APInvoices_PurchaseOrderId_PurchaseOrders");

            entity.HasOne(d => d.Supplier).WithMany(p => p.Apinvoices)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APInvoices_SupplierId_Suppliers");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Apinvoices)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APInvoices_TenantId_Tenants");
        });

        modelBuilder.Entity<ApinvoiceLine>(entity =>
        {
            entity.ToTable("APInvoiceLines", "erp_finance");

            entity.HasIndex(e => e.TenantId, "IX_APInvoiceLines_TenantId");

            entity.Property(e => e.ApinvoiceId).HasColumnName("APInvoiceId");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Description).HasMaxLength(300);
            entity.Property(e => e.GlaccountId).HasColumnName("GLAccountId");
            entity.Property(e => e.LineTotal).HasPrecision(19, 4);
            entity.Property(e => e.Quantity).HasPrecision(19, 4);
            entity.Property(e => e.UnitPrice).HasPrecision(19, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Apinvoice).WithMany(p => p.ApinvoiceLines)
                .HasForeignKey(d => d.ApinvoiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APInvoiceLines_APInvoiceId_APInvoices");

            entity.HasOne(d => d.Glaccount).WithMany(p => p.ApinvoiceLines)
                .HasForeignKey(d => d.GlaccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APInvoiceLines_GLAccountId_GLAccounts");

            entity.HasOne(d => d.PurchaseReceiptLine).WithMany(p => p.ApinvoiceLines)
                .HasForeignKey(d => d.PurchaseReceiptLineId)
                .HasConstraintName("FK_APInvoiceLines_PurchaseReceiptLineId_GoodsReceiptLines");

            entity.HasOne(d => d.TaxCode).WithMany(p => p.ApinvoiceLines)
                .HasForeignKey(d => d.TaxCodeId)
                .HasConstraintName("FK_APInvoiceLines_TaxCodeId_TaxCodes");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ApinvoiceLines)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APInvoiceLines_TenantId_Tenants");
        });

        modelBuilder.Entity<Appayment>(entity =>
        {
            entity.ToTable("APPayments", "erp_finance");

            entity.HasIndex(e => e.TenantId, "IX_APPayments_TenantId");

            entity.Property(e => e.Amount).HasPrecision(19, 4);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.PaymentNo).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.BankAccount).WithMany(p => p.Appayments)
                .HasForeignKey(d => d.BankAccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APPayments_BankAccountId_BankAccounts");

            entity.HasOne(d => d.JournalEntry).WithMany(p => p.Appayments)
                .HasForeignKey(d => d.JournalEntryId)
                .HasConstraintName("FK_APPayments_JournalEntryId_JournalEntries");

            entity.HasOne(d => d.Supplier).WithMany(p => p.Appayments)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APPayments_SupplierId_Suppliers");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Appayments)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APPayments_TenantId_Tenants");
        });

        modelBuilder.Entity<AppaymentAllocation>(entity =>
        {
            entity.ToTable("APPaymentAllocations", "erp_finance");

            entity.HasIndex(e => e.TenantId, "IX_APPaymentAllocations_TenantId");

            entity.Property(e => e.ApinvoiceId).HasColumnName("APInvoiceId");
            entity.Property(e => e.AppliedAmount).HasPrecision(19, 4);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Apinvoice).WithMany(p => p.AppaymentAllocations)
                .HasForeignKey(d => d.ApinvoiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APPaymentAllocations_APInvoiceId_APInvoices");

            entity.HasOne(d => d.Payment).WithMany(p => p.AppaymentAllocations)
                .HasForeignKey(d => d.PaymentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APPaymentAllocations_PaymentId_APPayments");

            entity.HasOne(d => d.Tenant).WithMany(p => p.AppaymentAllocations)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APPaymentAllocations_TenantId_Tenants");
        });

        modelBuilder.Entity<ApprovalAction>(entity =>
        {
            entity.ToTable("ApprovalActions", "erp_core");

            entity.HasIndex(e => e.TenantId, "IX_ApprovalActions_TenantId");

            entity.Property(e => e.Action).HasMaxLength(24);
            entity.Property(e => e.ActionAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Comment).HasMaxLength(1000);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.ActorTenantUser).WithMany(p => p.ApprovalActions)
                .HasForeignKey(d => d.ActorTenantUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApprovalActions_ActorTenantUserId_TenantUsers");

            entity.HasOne(d => d.Request).WithMany(p => p.ApprovalActions)
                .HasForeignKey(d => d.RequestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApprovalActions_RequestId_ApprovalRequests");

            entity.HasOne(d => d.Step).WithMany(p => p.ApprovalActions)
                .HasForeignKey(d => d.StepId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApprovalActions_StepId_ApprovalSteps");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ApprovalActions)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApprovalActions_TenantId_Tenants");
        });

        modelBuilder.Entity<ApprovalRequest>(entity =>
        {
            entity.ToTable("ApprovalRequests", "erp_core");

            entity.HasIndex(e => e.TenantId, "IX_ApprovalRequests_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.DocumentType).HasMaxLength(80);
            entity.Property(e => e.RequestedAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.RequestedByTenantUser).WithMany(p => p.ApprovalRequests)
                .HasForeignKey(d => d.RequestedByTenantUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApprovalRequests_RequestedByTenantUserId_TenantUsers");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ApprovalRequests)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApprovalRequests_TenantId_Tenants");

            entity.HasOne(d => d.Workflow).WithMany(p => p.ApprovalRequests)
                .HasForeignKey(d => d.WorkflowId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApprovalRequests_WorkflowId_ApprovalWorkflows");
        });

        modelBuilder.Entity<ApprovalStep>(entity =>
        {
            entity.ToTable("ApprovalSteps", "erp_core");

            entity.HasIndex(e => e.TenantId, "IX_ApprovalSteps_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.ApproverRole).WithMany(p => p.ApprovalSteps)
                .HasForeignKey(d => d.ApproverRoleId)
                .HasConstraintName("FK_ApprovalSteps_ApproverRoleId_Roles");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ApprovalSteps)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApprovalSteps_TenantId_Tenants");

            entity.HasOne(d => d.Workflow).WithMany(p => p.ApprovalSteps)
                .HasForeignKey(d => d.WorkflowId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApprovalSteps_WorkflowId_ApprovalWorkflows");
        });

        modelBuilder.Entity<ApprovalWorkflow>(entity =>
        {
            entity.ToTable("ApprovalWorkflows", "erp_core");

            entity.HasIndex(e => e.TenantId, "IX_ApprovalWorkflows_TenantId");

            entity.Property(e => e.Code).HasMaxLength(60);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.DocumentType).HasMaxLength(80);
            entity.Property(e => e.Name).HasMaxLength(160);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ApprovalWorkflows)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApprovalWorkflows_TenantId_Tenants");
        });

        modelBuilder.Entity<Arinvoice>(entity =>
        {
            entity.ToTable("ARInvoices", "erp_finance");

            entity.HasIndex(e => e.TenantId, "IX_ARInvoices_TenantId");

            entity.HasIndex(e => new { e.TenantId, e.InvoiceNo }, "UX_ARInvoices_InvoiceNo").IsUnique();

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.ExchangeRate).HasPrecision(20, 10);
            entity.Property(e => e.InvoiceNo).HasMaxLength(80);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.Subtotal).HasPrecision(19, 4);
            entity.Property(e => e.TaxAmount).HasPrecision(19, 4);
            entity.Property(e => e.Total).HasPrecision(19, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Customer).WithMany(p => p.Arinvoices)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARInvoices_CustomerId_Customers");

            entity.HasOne(d => d.JournalEntry).WithMany(p => p.Arinvoices)
                .HasForeignKey(d => d.JournalEntryId)
                .HasConstraintName("FK_ARInvoices_JournalEntryId_JournalEntries");

            entity.HasOne(d => d.SalesOrder).WithMany(p => p.Arinvoices)
                .HasForeignKey(d => d.SalesOrderId)
                .HasConstraintName("FK_ARInvoices_SalesOrderId_SalesOrders");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Arinvoices)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARInvoices_TenantId_Tenants");
        });

        modelBuilder.Entity<ArinvoiceLine>(entity =>
        {
            entity.ToTable("ARInvoiceLines", "erp_finance");

            entity.HasIndex(e => e.TenantId, "IX_ARInvoiceLines_TenantId");

            entity.Property(e => e.ArinvoiceId).HasColumnName("ARInvoiceId");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Description).HasMaxLength(300);
            entity.Property(e => e.GlaccountId).HasColumnName("GLAccountId");
            entity.Property(e => e.LineTotal).HasPrecision(19, 4);
            entity.Property(e => e.Quantity).HasPrecision(19, 4);
            entity.Property(e => e.UnitPrice).HasPrecision(19, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Arinvoice).WithMany(p => p.ArinvoiceLines)
                .HasForeignKey(d => d.ArinvoiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARInvoiceLines_ARInvoiceId_ARInvoices");

            entity.HasOne(d => d.Glaccount).WithMany(p => p.ArinvoiceLines)
                .HasForeignKey(d => d.GlaccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARInvoiceLines_GLAccountId_GLAccounts");

            entity.HasOne(d => d.Item).WithMany(p => p.ArinvoiceLines)
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("FK_ARInvoiceLines_ItemId_Items");

            entity.HasOne(d => d.TaxCode).WithMany(p => p.ArinvoiceLines)
                .HasForeignKey(d => d.TaxCodeId)
                .HasConstraintName("FK_ARInvoiceLines_TaxCodeId_TaxCodes");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ArinvoiceLines)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARInvoiceLines_TenantId_Tenants");
        });

        modelBuilder.Entity<Arreceipt>(entity =>
        {
            entity.ToTable("ARReceipts", "erp_finance");

            entity.HasIndex(e => e.TenantId, "IX_ARReceipts_TenantId");

            entity.Property(e => e.Amount).HasPrecision(19, 4);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.ReceiptNo).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.BankAccount).WithMany(p => p.Arreceipts)
                .HasForeignKey(d => d.BankAccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARReceipts_BankAccountId_BankAccounts");

            entity.HasOne(d => d.Customer).WithMany(p => p.Arreceipts)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARReceipts_CustomerId_Customers");

            entity.HasOne(d => d.JournalEntry).WithMany(p => p.Arreceipts)
                .HasForeignKey(d => d.JournalEntryId)
                .HasConstraintName("FK_ARReceipts_JournalEntryId_JournalEntries");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Arreceipts)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARReceipts_TenantId_Tenants");
        });

        modelBuilder.Entity<ArreceiptAllocation>(entity =>
        {
            entity.ToTable("ARReceiptAllocations", "erp_finance");

            entity.HasIndex(e => e.TenantId, "IX_ARReceiptAllocations_TenantId");

            entity.Property(e => e.AppliedAmount).HasPrecision(19, 4);
            entity.Property(e => e.ArinvoiceId).HasColumnName("ARInvoiceId");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Arinvoice).WithMany(p => p.ArreceiptAllocations)
                .HasForeignKey(d => d.ArinvoiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARReceiptAllocations_ARInvoiceId_ARInvoices");

            entity.HasOne(d => d.Receipt).WithMany(p => p.ArreceiptAllocations)
                .HasForeignKey(d => d.ReceiptId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARReceiptAllocations_ReceiptId_ARReceipts");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ArreceiptAllocations)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ARReceiptAllocations_TenantId_Tenants");
        });

        modelBuilder.Entity<Assessment>(entity =>
        {
            entity.ToTable("Assessments", "erp_education");

            entity.HasIndex(e => e.TenantId, "IX_Assessments_TenantId");

            entity.Property(e => e.AssessmentType).HasMaxLength(30);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.MaxMarks).HasPrecision(19, 4);
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Section).WithMany(p => p.Assessments)
                .HasForeignKey(d => d.SectionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Assessments_SectionId_ClassSections");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Assessments)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Assessments_TenantId_Tenants");
        });

        modelBuilder.Entity<AssessmentScore>(entity =>
        {
            entity.ToTable("AssessmentScores", "erp_education");

            entity.HasIndex(e => e.TenantId, "IX_AssessmentScores_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.MarksObtained).HasPrecision(19, 4);
            entity.Property(e => e.Remarks).HasMaxLength(300);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Assessment).WithMany(p => p.AssessmentScores)
                .HasForeignKey(d => d.AssessmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssessmentScores_AssessmentId_Assessments");

            entity.HasOne(d => d.Student).WithMany(p => p.AssessmentScores)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssessmentScores_StudentId_Students");

            entity.HasOne(d => d.Tenant).WithMany(p => p.AssessmentScores)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssessmentScores_TenantId_Tenants");
        });

        modelBuilder.Entity<AssetDepreciationLine>(entity =>
        {
            entity.ToTable("AssetDepreciationLines", "erp_finance");

            entity.HasIndex(e => e.TenantId, "IX_AssetDepreciationLines_TenantId");

            entity.Property(e => e.AccumulatedAmount).HasPrecision(19, 4);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.DepreciationAmount).HasPrecision(19, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.FixedAsset).WithMany(p => p.AssetDepreciationLines)
                .HasForeignKey(d => d.FixedAssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetDepreciationLines_FixedAssetId_FixedAssets");

            entity.HasOne(d => d.Run).WithMany(p => p.AssetDepreciationLines)
                .HasForeignKey(d => d.RunId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetDepreciationLines_RunId_AssetDepreciationRuns");

            entity.HasOne(d => d.Tenant).WithMany(p => p.AssetDepreciationLines)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetDepreciationLines_TenantId_Tenants");
        });

        modelBuilder.Entity<AssetDepreciationRun>(entity =>
        {
            entity.ToTable("AssetDepreciationRuns", "erp_finance");

            entity.HasIndex(e => e.TenantId, "IX_AssetDepreciationRuns_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.JournalEntry).WithMany(p => p.AssetDepreciationRuns)
                .HasForeignKey(d => d.JournalEntryId)
                .HasConstraintName("FK_AssetDepreciationRuns_JournalEntryId_JournalEntries");

            entity.HasOne(d => d.Period).WithMany(p => p.AssetDepreciationRuns)
                .HasForeignKey(d => d.PeriodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetDepreciationRuns_PeriodId_AccountingPeriods");

            entity.HasOne(d => d.Tenant).WithMany(p => p.AssetDepreciationRuns)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AssetDepreciationRuns_TenantId_Tenants");
        });

        modelBuilder.Entity<Attachment>(entity =>
        {
            entity.ToTable("Attachments", "erp_core");

            entity.HasIndex(e => e.TenantId, "IX_Attachments_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.EntityType).HasMaxLength(80);
            entity.Property(e => e.FileName).HasMaxLength(255);
            entity.Property(e => e.MimeType).HasMaxLength(120);
            entity.Property(e => e.StorageKey).HasMaxLength(500);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Attachments)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Attachments_TenantId_Tenants");

            entity.HasOne(d => d.UploadedByTenantUser).WithMany(p => p.Attachments)
                .HasForeignKey(d => d.UploadedByTenantUserId)
                .HasConstraintName("FK_Attachments_UploadedByTenantUserId_TenantUsers");
        });

        modelBuilder.Entity<AttendanceRecord>(entity =>
        {
            entity.ToTable("AttendanceRecords", "erp_hr");

            entity.HasIndex(e => e.TenantId, "IX_AttendanceRecords_TenantId");

            entity.Property(e => e.ClockInAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.ClockOutAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Source).HasMaxLength(30);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Employee).WithMany(p => p.AttendanceRecords)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AttendanceRecords_EmployeeId_Employees");

            entity.HasOne(d => d.Tenant).WithMany(p => p.AttendanceRecords)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AttendanceRecords_TenantId_Tenants");
        });

        modelBuilder.Entity<AuditLog>(entity =>
        {
            entity.ToTable("AuditLogs", "erp_core");

            entity.HasIndex(e => e.TenantId, "IX_AuditLogs_TenantId");

            entity.Property(e => e.Action).HasMaxLength(40);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.EntityType).HasMaxLength(80);
            entity.Property(e => e.OccurredAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.ActorTenantUser).WithMany(p => p.AuditLogs)
                .HasForeignKey(d => d.ActorTenantUserId)
                .HasConstraintName("FK_AuditLogs_ActorTenantUserId_TenantUsers");

            entity.HasOne(d => d.Tenant).WithMany(p => p.AuditLogs)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AuditLogs_TenantId_Tenants");
        });

        modelBuilder.Entity<BankAccount>(entity =>
        {
            entity.ToTable("BankAccounts", "erp_finance");

            entity.HasIndex(e => e.TenantId, "IX_BankAccounts_TenantId");

            entity.Property(e => e.AccountName).HasMaxLength(160);
            entity.Property(e => e.AccountNumberMasked).HasMaxLength(60);
            entity.Property(e => e.BankName).HasMaxLength(160);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.GlaccountId).HasColumnName("GLAccountId");
            entity.Property(e => e.Iban)
                .HasMaxLength(60)
                .HasColumnName("IBAN");
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Glaccount).WithMany(p => p.BankAccounts)
                .HasForeignKey(d => d.GlaccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BankAccounts_GLAccountId_GLAccounts");

            entity.HasOne(d => d.LegalEntity).WithMany(p => p.BankAccounts)
                .HasForeignKey(d => d.LegalEntityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BankAccounts_LegalEntityId_LegalEntities");

            entity.HasOne(d => d.Tenant).WithMany(p => p.BankAccounts)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BankAccounts_TenantId_Tenants");
        });

        modelBuilder.Entity<BankReconciliation>(entity =>
        {
            entity.ToTable("BankReconciliations", "erp_finance");

            entity.HasIndex(e => e.TenantId, "IX_BankReconciliations_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.GlclosingBalance)
                .HasPrecision(19, 4)
                .HasColumnName("GLClosingBalance");
            entity.Property(e => e.StatementClosingBalance).HasPrecision(19, 4);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.BankAccount).WithMany(p => p.BankReconciliations)
                .HasForeignKey(d => d.BankAccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BankReconciliations_BankAccountId_BankAccounts");

            entity.HasOne(d => d.Tenant).WithMany(p => p.BankReconciliations)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BankReconciliations_TenantId_Tenants");
        });

        modelBuilder.Entity<BankReconciliationLine>(entity =>
        {
            entity.ToTable("BankReconciliationLines", "erp_finance");

            entity.HasIndex(e => e.TenantId, "IX_BankReconciliationLines_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.MatchAmount).HasPrecision(19, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.BankTransaction).WithMany(p => p.BankReconciliationLines)
                .HasForeignKey(d => d.BankTransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BankReconciliationLines_BankTransactionId_BankTransactions");

            entity.HasOne(d => d.JournalLine).WithMany(p => p.BankReconciliationLines)
                .HasForeignKey(d => d.JournalLineId)
                .HasConstraintName("FK_BankReconciliationLines_JournalLineId_JournalLines");

            entity.HasOne(d => d.Reconciliation).WithMany(p => p.BankReconciliationLines)
                .HasForeignKey(d => d.ReconciliationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BankReconciliationLines_ReconciliationId_BankReconciliations");

            entity.HasOne(d => d.Tenant).WithMany(p => p.BankReconciliationLines)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BankReconciliationLines_TenantId_Tenants");
        });

        modelBuilder.Entity<BankTransaction>(entity =>
        {
            entity.ToTable("BankTransactions", "erp_finance");

            entity.HasIndex(e => e.TenantId, "IX_BankTransactions_TenantId");

            entity.Property(e => e.Amount).HasPrecision(19, 4);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.ExternalReference).HasMaxLength(100);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.BankAccount).WithMany(p => p.BankTransactions)
                .HasForeignKey(d => d.BankAccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BankTransactions_BankAccountId_BankAccounts");

            entity.HasOne(d => d.Tenant).WithMany(p => p.BankTransactions)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BankTransactions_TenantId_Tenants");
        });

        modelBuilder.Entity<BenefitPlan>(entity =>
        {
            entity.ToTable("BenefitPlans", "erp_hr");

            entity.HasIndex(e => e.TenantId, "IX_BenefitPlans_TenantId");

            entity.Property(e => e.BenefitType).HasMaxLength(40);
            entity.Property(e => e.Code).HasMaxLength(40);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.EmployeeContribution).HasPrecision(19, 4);
            entity.Property(e => e.EmployerContribution).HasPrecision(19, 4);
            entity.Property(e => e.Name).HasMaxLength(140);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Tenant).WithMany(p => p.BenefitPlans)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BenefitPlans_TenantId_Tenants");
        });

        modelBuilder.Entity<Bomheader>(entity =>
        {
            entity.ToTable("BOMHeaders", "erp_manufacturing");

            entity.HasIndex(e => e.TenantId, "IX_BOMHeaders_TenantId");

            entity.Property(e => e.BaseQty).HasPrecision(19, 4);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.RevisionCode).HasMaxLength(30);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.FinishedItem).WithMany(p => p.Bomheaders)
                .HasForeignKey(d => d.FinishedItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BOMHeaders_FinishedItemId_Items");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Bomheaders)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BOMHeaders_TenantId_Tenants");
        });

        modelBuilder.Entity<Bomline>(entity =>
        {
            entity.ToTable("BOMLines", "erp_manufacturing");

            entity.HasIndex(e => e.TenantId, "IX_BOMLines_TenantId");

            entity.Property(e => e.Bomid).HasColumnName("BOMId");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.QuantityPer).HasPrecision(19, 4);
            entity.Property(e => e.ScrapPercent).HasPrecision(9, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Bom).WithMany(p => p.Bomlines)
                .HasForeignKey(d => d.Bomid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BOMLines_BOMId_BOMHeaders");

            entity.HasOne(d => d.ComponentItem).WithMany(p => p.Bomlines)
                .HasForeignKey(d => d.ComponentItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BOMLines_ComponentItemId_Items");

            entity.HasOne(d => d.Operation).WithMany(p => p.Bomlines)
                .HasForeignKey(d => d.OperationId)
                .HasConstraintName("FK_BOMLines_OperationId_RoutingOperations");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Bomlines)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BOMLines_TenantId_Tenants");
        });

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.ToTable("Branches", "erp_core");

            entity.HasIndex(e => e.TenantId, "IX_Branches_TenantId");

            entity.HasIndex(e => new { e.TenantId, e.Code }, "UX_Branches_Code").IsUnique();

            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.Code).HasMaxLength(30);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Name).HasMaxLength(160);
            entity.Property(e => e.Phone).HasMaxLength(40);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.LegalEntity).WithMany(p => p.Branches)
                .HasForeignKey(d => d.LegalEntityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Branches_LegalEntityId_LegalEntities");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Branches)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Branches_TenantId_Tenants");
        });

        modelBuilder.Entity<Budget>(entity =>
        {
            entity.ToTable("Budgets", "erp_management");

            entity.HasIndex(e => e.TenantId, "IX_Budgets_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.FiscalYear).WithMany(p => p.Budgets)
                .HasForeignKey(d => d.FiscalYearId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Budgets_FiscalYearId_FiscalYears");

            entity.HasOne(d => d.LegalEntity).WithMany(p => p.Budgets)
                .HasForeignKey(d => d.LegalEntityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Budgets_LegalEntityId_LegalEntities");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Budgets)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Budgets_TenantId_Tenants");
        });

        modelBuilder.Entity<BudgetLine>(entity =>
        {
            entity.ToTable("BudgetLines", "erp_management");

            entity.HasIndex(e => e.TenantId, "IX_BudgetLines_TenantId");

            entity.Property(e => e.Amount).HasPrecision(19, 4);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.GlaccountId).HasColumnName("GLAccountId");
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Budget).WithMany(p => p.BudgetLines)
                .HasForeignKey(d => d.BudgetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BudgetLines_BudgetId_Budgets");

            entity.HasOne(d => d.CostCenter).WithMany(p => p.BudgetLines)
                .HasForeignKey(d => d.CostCenterId)
                .HasConstraintName("FK_BudgetLines_CostCenterId_CostCenters");

            entity.HasOne(d => d.Glaccount).WithMany(p => p.BudgetLines)
                .HasForeignKey(d => d.GlaccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BudgetLines_GLAccountId_GLAccounts");

            entity.HasOne(d => d.Period).WithMany(p => p.BudgetLines)
                .HasForeignKey(d => d.PeriodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BudgetLines_PeriodId_AccountingPeriods");

            entity.HasOne(d => d.Tenant).WithMany(p => p.BudgetLines)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BudgetLines_TenantId_Tenants");
        });

        modelBuilder.Entity<CallCenterCall>(entity =>
        {
            entity.ToTable("CallCenterCalls", "erp_crm");

            entity.HasIndex(e => e.TenantId, "IX_CallCenterCalls_TenantId");

            entity.Property(e => e.CallEndAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CallStartAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Disposition).HasMaxLength(60);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.AgentEmployee).WithMany(p => p.CallCenterCalls)
                .HasForeignKey(d => d.AgentEmployeeId)
                .HasConstraintName("FK_CallCenterCalls_AgentEmployeeId_Employees");

            entity.HasOne(d => d.Customer).WithMany(p => p.CallCenterCalls)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_CallCenterCalls_CustomerId_Customers");

            entity.HasOne(d => d.Tenant).WithMany(p => p.CallCenterCalls)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CallCenterCalls_TenantId_Tenants");

            entity.HasOne(d => d.Ticket).WithMany(p => p.CallCenterCalls)
                .HasForeignKey(d => d.TicketId)
                .HasConstraintName("FK_CallCenterCalls_TicketId_SupportTickets");
        });

        modelBuilder.Entity<CampaignMember>(entity =>
        {
            entity.ToTable("CampaignMembers", "erp_crm");

            entity.HasIndex(e => e.TenantId, "IX_CampaignMembers_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.ResponseStatus).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Campaign).WithMany(p => p.CampaignMembers)
                .HasForeignKey(d => d.CampaignId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CampaignMembers_CampaignId_MarketingCampaigns");

            entity.HasOne(d => d.Customer).WithMany(p => p.CampaignMembers)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_CampaignMembers_CustomerId_Customers");

            entity.HasOne(d => d.Lead).WithMany(p => p.CampaignMembers)
                .HasForeignKey(d => d.LeadId)
                .HasConstraintName("FK_CampaignMembers_LeadId_Leads");

            entity.HasOne(d => d.Tenant).WithMany(p => p.CampaignMembers)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CampaignMembers_TenantId_Tenants");
        });

        modelBuilder.Entity<Campus>(entity =>
        {
            entity.ToTable("Campuses", "erp_education");

            entity.HasIndex(e => e.TenantId, "IX_Campuses_TenantId");

            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.Code).HasMaxLength(30);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Name).HasMaxLength(160);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Branch).WithMany(p => p.Campuses)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK_Campuses_BranchId_Branches");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Campuses)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Campuses_TenantId_Tenants");
        });

        modelBuilder.Entity<Candidate>(entity =>
        {
            entity.ToTable("Candidates", "erp_hr");

            entity.HasIndex(e => e.TenantId, "IX_Candidates_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Email).HasMaxLength(254);
            entity.Property(e => e.FullName).HasMaxLength(160);
            entity.Property(e => e.Phone).HasMaxLength(40);
            entity.Property(e => e.Source).HasMaxLength(80);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.ResumeAttachment).WithMany(p => p.Candidates)
                .HasForeignKey(d => d.ResumeAttachmentId)
                .HasConstraintName("FK_Candidates_ResumeAttachmentId_Attachments");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Candidates)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Candidates_TenantId_Tenants");
        });

        modelBuilder.Entity<Capaaction>(entity =>
        {
            entity.ToTable("CAPAActions", "erp_manufacturing");

            entity.HasIndex(e => e.TenantId, "IX_CAPAActions_TenantId");

            entity.Property(e => e.ActionType).HasMaxLength(30);
            entity.Property(e => e.CompletedAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.AssignedEmployee).WithMany(p => p.Capaactions)
                .HasForeignKey(d => d.AssignedEmployeeId)
                .HasConstraintName("FK_CAPAActions_AssignedEmployeeId_Employees");

            entity.HasOne(d => d.NonConformance).WithMany(p => p.Capaactions)
                .HasForeignKey(d => d.NonConformanceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CAPAActions_NonConformanceId_NonConformances");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Capaactions)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CAPAActions_TenantId_Tenants");
        });

        modelBuilder.Entity<CapacityReservation>(entity =>
        {
            entity.ToTable("CapacityReservations", "erp_manufacturing");

            entity.HasIndex(e => e.TenantId, "IX_CapacityReservations_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.EndAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.ReservedHours).HasPrecision(19, 4);
            entity.Property(e => e.StartAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Tenant).WithMany(p => p.CapacityReservations)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CapacityReservations_TenantId_Tenants");

            entity.HasOne(d => d.WorkCenter).WithMany(p => p.CapacityReservations)
                .HasForeignKey(d => d.WorkCenterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CapacityReservations_WorkCenterId_WorkCenters");

            entity.HasOne(d => d.WorkOrderOperation).WithMany(p => p.CapacityReservations)
                .HasForeignKey(d => d.WorkOrderOperationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CapacityReservations_WorkOrderOperationId_WorkOrde_41aa50aeb");
        });

        modelBuilder.Entity<ClassSection>(entity =>
        {
            entity.ToTable("ClassSections", "erp_education");

            entity.HasIndex(e => e.TenantId, "IX_ClassSections_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.SectionCode).HasMaxLength(30);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Course).WithMany(p => p.ClassSections)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClassSections_CourseId_Courses");

            entity.HasOne(d => d.TeacherEmployee).WithMany(p => p.ClassSections)
                .HasForeignKey(d => d.TeacherEmployeeId)
                .HasConstraintName("FK_ClassSections_TeacherEmployeeId_Employees");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ClassSections)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClassSections_TenantId_Tenants");

            entity.HasOne(d => d.Term).WithMany(p => p.ClassSections)
                .HasForeignKey(d => d.TermId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClassSections_TermId_AcademicTerms");
        });

        modelBuilder.Entity<ClassSession>(entity =>
        {
            entity.ToTable("ClassSessions", "erp_education");

            entity.HasIndex(e => e.TenantId, "IX_ClassSessions_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.EndTime).HasPrecision(0);
            entity.Property(e => e.Room).HasMaxLength(50);
            entity.Property(e => e.StartTime).HasPrecision(0);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Section).WithMany(p => p.ClassSessions)
                .HasForeignKey(d => d.SectionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClassSessions_SectionId_ClassSections");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ClassSessions)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClassSessions_TenantId_Tenants");
        });

        modelBuilder.Entity<ConsolidationGroup>(entity =>
        {
            entity.ToTable("ConsolidationGroups", "erp_finance");

            entity.HasIndex(e => e.TenantId, "IX_ConsolidationGroups_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.ReportingCurrency)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.ParentGroup).WithMany(p => p.InverseParentGroup)
                .HasForeignKey(d => d.ParentGroupId)
                .HasConstraintName("FK_ConsolidationGroups_ParentGroupId_ConsolidationGroups");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ConsolidationGroups)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConsolidationGroups_TenantId_Tenants");
        });

        modelBuilder.Entity<ConsolidationMember>(entity =>
        {
            entity.ToTable("ConsolidationMembers", "erp_finance");

            entity.HasIndex(e => e.TenantId, "IX_ConsolidationMembers_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.OwnershipPercent).HasPrecision(9, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Group).WithMany(p => p.ConsolidationMembers)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConsolidationMembers_GroupId_ConsolidationGroups");

            entity.HasOne(d => d.LegalEntity).WithMany(p => p.ConsolidationMembers)
                .HasForeignKey(d => d.LegalEntityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConsolidationMembers_LegalEntityId_LegalEntities");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ConsolidationMembers)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConsolidationMembers_TenantId_Tenants");
        });

        modelBuilder.Entity<ConsolidationRun>(entity =>
        {
            entity.ToTable("ConsolidationRuns", "erp_finance");

            entity.HasIndex(e => e.TenantId, "IX_ConsolidationRuns_TenantId");

            entity.Property(e => e.CreatedAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Group).WithMany(p => p.ConsolidationRuns)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConsolidationRuns_GroupId_ConsolidationGroups");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ConsolidationRuns)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConsolidationRuns_TenantId_Tenants");
        });

        modelBuilder.Entity<Contract>(entity =>
        {
            entity.ToTable("Contracts", "erp_contracts");

            entity.HasIndex(e => e.TenantId, "IX_Contracts_TenantId");

            entity.HasIndex(e => new { e.TenantId, e.ContractNo }, "UX_Contracts_ContractNo").IsUnique();

            entity.Property(e => e.ContractNo).HasMaxLength(60);
            entity.Property(e => e.ContractType).HasMaxLength(40);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.Title).HasMaxLength(200);
            entity.Property(e => e.TotalValue).HasPrecision(19, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.OwnerEmployee).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.OwnerEmployeeId)
                .HasConstraintName("FK_Contracts_OwnerEmployeeId_Employees");

            entity.HasOne(d => d.Template).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.TemplateId)
                .HasConstraintName("FK_Contracts_TemplateId_ContractTemplates");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Contracts_TenantId_Tenants");
        });

        modelBuilder.Entity<ContractAlert>(entity =>
        {
            entity.ToTable("ContractAlerts", "erp_contracts");

            entity.HasIndex(e => e.TenantId, "IX_ContractAlerts_TenantId");

            entity.Property(e => e.AlertType).HasMaxLength(40);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.SentAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.TriggerAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Contract).WithMany(p => p.ContractAlerts)
                .HasForeignKey(d => d.ContractId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContractAlerts_ContractId_Contracts");

            entity.HasOne(d => d.Milestone).WithMany(p => p.ContractAlerts)
                .HasForeignKey(d => d.MilestoneId)
                .HasConstraintName("FK_ContractAlerts_MilestoneId_ContractMilestones");

            entity.HasOne(d => d.RecipientTenantUser).WithMany(p => p.ContractAlerts)
                .HasForeignKey(d => d.RecipientTenantUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContractAlerts_RecipientTenantUserId_TenantUsers");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ContractAlerts)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContractAlerts_TenantId_Tenants");
        });

        modelBuilder.Entity<ContractMilestone>(entity =>
        {
            entity.ToTable("ContractMilestones", "erp_contracts");

            entity.HasIndex(e => e.TenantId, "IX_ContractMilestones_TenantId");

            entity.Property(e => e.Amount).HasPrecision(19, 4);
            entity.Property(e => e.CompletedAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Name).HasMaxLength(160);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Contract).WithMany(p => p.ContractMilestones)
                .HasForeignKey(d => d.ContractId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContractMilestones_ContractId_Contracts");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ContractMilestones)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContractMilestones_TenantId_Tenants");
        });

        modelBuilder.Entity<ContractObligation>(entity =>
        {
            entity.ToTable("ContractObligations", "erp_contracts");

            entity.HasIndex(e => e.TenantId, "IX_ContractObligations_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Contract).WithMany(p => p.ContractObligations)
                .HasForeignKey(d => d.ContractId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContractObligations_ContractId_Contracts");

            entity.HasOne(d => d.ResponsibleEmployee).WithMany(p => p.ContractObligations)
                .HasForeignKey(d => d.ResponsibleEmployeeId)
                .HasConstraintName("FK_ContractObligations_ResponsibleEmployeeId_Employees");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ContractObligations)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContractObligations_TenantId_Tenants");
        });

        modelBuilder.Entity<ContractParty>(entity =>
        {
            entity.ToTable("ContractParties", "erp_contracts");

            entity.HasIndex(e => e.TenantId, "IX_ContractParties_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.PartyType).HasMaxLength(30);
            entity.Property(e => e.SignatoryName).HasMaxLength(160);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Contract).WithMany(p => p.ContractParties)
                .HasForeignKey(d => d.ContractId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContractParties_ContractId_Contracts");

            entity.HasOne(d => d.Customer).WithMany(p => p.ContractParties)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_ContractParties_CustomerId_Customers");

            entity.HasOne(d => d.LegalEntity).WithMany(p => p.ContractParties)
                .HasForeignKey(d => d.LegalEntityId)
                .HasConstraintName("FK_ContractParties_LegalEntityId_LegalEntities");

            entity.HasOne(d => d.Supplier).WithMany(p => p.ContractParties)
                .HasForeignKey(d => d.SupplierId)
                .HasConstraintName("FK_ContractParties_SupplierId_Suppliers");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ContractParties)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContractParties_TenantId_Tenants");
        });

        modelBuilder.Entity<ContractSignature>(entity =>
        {
            entity.ToTable("ContractSignatures", "erp_contracts");

            entity.HasIndex(e => e.TenantId, "IX_ContractSignatures_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.ExternalEnvelopeId).HasMaxLength(150);
            entity.Property(e => e.Provider).HasMaxLength(60);
            entity.Property(e => e.SignedAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.SignerEmail).HasMaxLength(254);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Contract).WithMany(p => p.ContractSignatures)
                .HasForeignKey(d => d.ContractId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContractSignatures_ContractId_Contracts");

            entity.HasOne(d => d.Party).WithMany(p => p.ContractSignatures)
                .HasForeignKey(d => d.PartyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContractSignatures_PartyId_ContractParties");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ContractSignatures)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContractSignatures_TenantId_Tenants");
        });

        modelBuilder.Entity<ContractTemplate>(entity =>
        {
            entity.ToTable("ContractTemplates", "erp_contracts");

            entity.HasIndex(e => e.TenantId, "IX_ContractTemplates_TenantId");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.TemplateStorageKey).HasMaxLength(500);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ContractTemplates)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContractTemplates_TenantId_Tenants");
        });

        modelBuilder.Entity<ContractVersion>(entity =>
        {
            entity.ToTable("ContractVersions", "erp_contracts");

            entity.HasIndex(e => e.TenantId, "IX_ContractVersions_TenantId");

            entity.Property(e => e.ChangeNotes).HasMaxLength(500);
            entity.Property(e => e.ChangedAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Contract).WithMany(p => p.ContractVersions)
                .HasForeignKey(d => d.ContractId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContractVersions_ContractId_Contracts");

            entity.HasOne(d => d.DocumentAttachment).WithMany(p => p.ContractVersions)
                .HasForeignKey(d => d.DocumentAttachmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContractVersions_DocumentAttachmentId_Attachments");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ContractVersions)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContractVersions_TenantId_Tenants");
        });

        modelBuilder.Entity<CostAllocation>(entity =>
        {
            entity.ToTable("CostAllocations", "erp_management");

            entity.HasIndex(e => e.TenantId, "IX_CostAllocations_TenantId");

            entity.Property(e => e.AllocationMethod).HasMaxLength(40);
            entity.Property(e => e.Amount).HasPrecision(19, 4);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.DestinationCostCenter).WithMany(p => p.CostAllocationDestinationCostCenters)
                .HasForeignKey(d => d.DestinationCostCenterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CostAllocations_DestinationCostCenterId_CostCenters");

            entity.HasOne(d => d.JournalEntry).WithMany(p => p.CostAllocations)
                .HasForeignKey(d => d.JournalEntryId)
                .HasConstraintName("FK_CostAllocations_JournalEntryId_JournalEntries");

            entity.HasOne(d => d.Period).WithMany(p => p.CostAllocations)
                .HasForeignKey(d => d.PeriodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CostAllocations_PeriodId_AccountingPeriods");

            entity.HasOne(d => d.SourceCostCenter).WithMany(p => p.CostAllocationSourceCostCenters)
                .HasForeignKey(d => d.SourceCostCenterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CostAllocations_SourceCostCenterId_CostCenters");

            entity.HasOne(d => d.Tenant).WithMany(p => p.CostAllocations)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CostAllocations_TenantId_Tenants");
        });

        modelBuilder.Entity<CostCenter>(entity =>
        {
            entity.ToTable("CostCenters", "erp_finance");

            entity.HasIndex(e => e.TenantId, "IX_CostCenters_TenantId");

            entity.Property(e => e.Code).HasMaxLength(30);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Name).HasMaxLength(140);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.LegalEntity).WithMany(p => p.CostCenters)
                .HasForeignKey(d => d.LegalEntityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CostCenters_LegalEntityId_LegalEntities");

            entity.HasOne(d => d.ParentCostCenter).WithMany(p => p.InverseParentCostCenter)
                .HasForeignKey(d => d.ParentCostCenterId)
                .HasConstraintName("FK_CostCenters_ParentCostCenterId_CostCenters");

            entity.HasOne(d => d.Tenant).WithMany(p => p.CostCenters)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CostCenters_TenantId_Tenants");
        });

        modelBuilder.Entity<CostDriver>(entity =>
        {
            entity.ToTable("CostDrivers", "erp_management");

            entity.HasIndex(e => e.TenantId, "IX_CostDrivers_TenantId");

            entity.Property(e => e.Code).HasMaxLength(40);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.Unit).HasMaxLength(30);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Tenant).WithMany(p => p.CostDrivers)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CostDrivers_TenantId_Tenants");
        });

        modelBuilder.Entity<CostObject>(entity =>
        {
            entity.ToTable("CostObjects", "erp_management");

            entity.HasIndex(e => e.TenantId, "IX_CostObjects_TenantId");

            entity.Property(e => e.Code).HasMaxLength(40);
            entity.Property(e => e.CostObjectType).HasMaxLength(30);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Project).WithMany(p => p.CostObjects)
                .HasForeignKey(d => d.ProjectId)
                .HasConstraintName("FK_CostObjects_ProjectId_Projects");

            entity.HasOne(d => d.Tenant).WithMany(p => p.CostObjects)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CostObjects_TenantId_Tenants");
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.ToTable("Courses", "erp_education");

            entity.HasIndex(e => e.TenantId, "IX_Courses_TenantId");

            entity.Property(e => e.Code).HasMaxLength(40);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CreditHours).HasPrecision(19, 4);
            entity.Property(e => e.Title).HasMaxLength(160);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Program).WithMany(p => p.Courses)
                .HasForeignKey(d => d.ProgramId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Courses_ProgramId_AcademicPrograms");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Courses)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Courses_TenantId_Tenants");
        });

        modelBuilder.Entity<CreditCheck>(entity =>
        {
            entity.ToTable("CreditChecks", "erp_sales");

            entity.HasIndex(e => e.TenantId, "IX_CreditChecks_TenantId");

            entity.Property(e => e.CheckedAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CreditLimit).HasPrecision(19, 4);
            entity.Property(e => e.Decision).HasMaxLength(24);
            entity.Property(e => e.ExposureAmount).HasPrecision(19, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.CheckedByTenantUser).WithMany(p => p.CreditChecks)
                .HasForeignKey(d => d.CheckedByTenantUserId)
                .HasConstraintName("FK_CreditChecks_CheckedByTenantUserId_TenantUsers");

            entity.HasOne(d => d.SalesOrder).WithMany(p => p.CreditChecks)
                .HasForeignKey(d => d.SalesOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CreditChecks_SalesOrderId_SalesOrders");

            entity.HasOne(d => d.Tenant).WithMany(p => p.CreditChecks)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CreditChecks_TenantId_Tenants");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customers", "erp_sales");

            entity.HasIndex(e => e.TenantId, "IX_Customers_TenantId");

            entity.HasIndex(e => new { e.TenantId, e.CustomerNo }, "UX_Customers_CustomerNo").IsUnique();

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CreditLimit).HasPrecision(19, 4);
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.CustomerNo).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(254);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Phone).HasMaxLength(40);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.TaxId).HasMaxLength(80);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Customers)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Customers_TenantId_Tenants");
        });

        modelBuilder.Entity<CustomerContact>(entity =>
        {
            entity.ToTable("CustomerContacts", "erp_sales");

            entity.HasIndex(e => e.TenantId, "IX_CustomerContacts_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Email).HasMaxLength(254);
            entity.Property(e => e.Name).HasMaxLength(140);
            entity.Property(e => e.Phone).HasMaxLength(40);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerContacts)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerContacts_CustomerId_Customers");

            entity.HasOne(d => d.Tenant).WithMany(p => p.CustomerContacts)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CustomerContacts_TenantId_Tenants");
        });

        modelBuilder.Entity<DeliveryRoute>(entity =>
        {
            entity.ToTable("DeliveryRoutes", "erp_sales");

            entity.HasIndex(e => e.TenantId, "IX_DeliveryRoutes_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Branch).WithMany(p => p.DeliveryRoutes)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DeliveryRoutes_BranchId_Branches");

            entity.HasOne(d => d.DriverEmployee).WithMany(p => p.DeliveryRoutes)
                .HasForeignKey(d => d.DriverEmployeeId)
                .HasConstraintName("FK_DeliveryRoutes_DriverEmployeeId_Employees");

            entity.HasOne(d => d.Tenant).WithMany(p => p.DeliveryRoutes)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DeliveryRoutes_TenantId_Tenants");
        });

        modelBuilder.Entity<DeliveryStop>(entity =>
        {
            entity.ToTable("DeliveryStops", "erp_sales");

            entity.HasIndex(e => e.TenantId, "IX_DeliveryStops_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.DeliveredAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.DeliveryStatus).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Route).WithMany(p => p.DeliveryStops)
                .HasForeignKey(d => d.RouteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DeliveryStops_RouteId_DeliveryRoutes");

            entity.HasOne(d => d.Shipment).WithMany(p => p.DeliveryStops)
                .HasForeignKey(d => d.ShipmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DeliveryStops_ShipmentId_Shipments");

            entity.HasOne(d => d.Tenant).WithMany(p => p.DeliveryStops)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DeliveryStops_TenantId_Tenants");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.ToTable("Departments", "erp_core");

            entity.HasIndex(e => e.TenantId, "IX_Departments_TenantId");

            entity.Property(e => e.Code).HasMaxLength(30);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Branch).WithMany(p => p.Departments)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK_Departments_BranchId_Branches");

            entity.HasOne(d => d.CostCenter).WithMany(p => p.Departments)
                .HasForeignKey(d => d.CostCenterId)
                .HasConstraintName("FK_Departments_CostCenterId_CostCenters");

            entity.HasOne(d => d.ParentDepartment).WithMany(p => p.InverseParentDepartment)
                .HasForeignKey(d => d.ParentDepartmentId)
                .HasConstraintName("FK_Departments_ParentDepartmentId_Departments");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Departments)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Departments_TenantId_Tenants");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.ToTable("Employees", "erp_hr");

            entity.HasIndex(e => e.TenantId, "IX_Employees_TenantId");

            entity.HasIndex(e => new { e.TenantId, e.EmployeeNo }, "UX_Employees_EmployeeNo").IsUnique();

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.EmployeeNo).HasMaxLength(50);
            entity.Property(e => e.EmploymentStatus).HasMaxLength(30);
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.WorkEmail).HasMaxLength(254);

            entity.HasOne(d => d.Department).WithMany(p => p.Employees)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Employees_DepartmentId_Departments");

            entity.HasOne(d => d.ManagerEmployee).WithMany(p => p.InverseManagerEmployee)
                .HasForeignKey(d => d.ManagerEmployeeId)
                .HasConstraintName("FK_Employees_ManagerEmployeeId_Employees");

            entity.HasOne(d => d.Position).WithMany(p => p.Employees)
                .HasForeignKey(d => d.PositionId)
                .HasConstraintName("FK_Employees_PositionId_JobPositions");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Employees)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Employees_TenantId_Tenants");
        });

        modelBuilder.Entity<EmployeeBenefit>(entity =>
        {
            entity.ToTable("EmployeeBenefits", "erp_hr");

            entity.HasIndex(e => e.TenantId, "IX_EmployeeBenefits_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.BenefitPlan).WithMany(p => p.EmployeeBenefits)
                .HasForeignKey(d => d.BenefitPlanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeBenefits_BenefitPlanId_BenefitPlans");

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeBenefits)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeBenefits_EmployeeId_Employees");

            entity.HasOne(d => d.Tenant).WithMany(p => p.EmployeeBenefits)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeBenefits_TenantId_Tenants");
        });

        modelBuilder.Entity<EmployeeDemographic>(entity =>
        {
            entity.ToTable("EmployeeDemographics", "erp_hr");

            entity.HasIndex(e => e.TenantId, "IX_EmployeeDemographics_TenantId");

            entity.Property(e => e.AttributeCode).HasMaxLength(40);
            entity.Property(e => e.AttributeValueEncrypted).HasMaxLength(500);
            entity.Property(e => e.ConsentRecordedAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeDemographics)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeDemographics_EmployeeId_Employees");

            entity.HasOne(d => d.Tenant).WithMany(p => p.EmployeeDemographics)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeDemographics_TenantId_Tenants");
        });

        modelBuilder.Entity<EmployeePension>(entity =>
        {
            entity.ToTable("EmployeePensions", "erp_hr");

            entity.HasIndex(e => e.TenantId, "IX_EmployeePensions_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeePensions)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeePensions_EmployeeId_Employees");

            entity.HasOne(d => d.PensionPlan).WithMany(p => p.EmployeePensions)
                .HasForeignKey(d => d.PensionPlanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeePensions_PensionPlanId_PensionPlans");

            entity.HasOne(d => d.Tenant).WithMany(p => p.EmployeePensions)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeePensions_TenantId_Tenants");
        });

        modelBuilder.Entity<EmployeeSeparation>(entity =>
        {
            entity.ToTable("EmployeeSeparations", "erp_hr");

            entity.HasIndex(e => e.TenantId, "IX_EmployeeSeparations_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.FinalSettlement).HasPrecision(19, 4);
            entity.Property(e => e.SeparationType).HasMaxLength(40);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeSeparations)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeSeparations_EmployeeId_Employees");

            entity.HasOne(d => d.Tenant).WithMany(p => p.EmployeeSeparations)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeSeparations_TenantId_Tenants");
        });

        modelBuilder.Entity<EmploymentContract>(entity =>
        {
            entity.ToTable("EmploymentContracts", "erp_hr");

            entity.HasIndex(e => e.TenantId, "IX_EmploymentContracts_TenantId");

            entity.Property(e => e.BaseSalary).HasPrecision(19, 4);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.EmploymentType).HasMaxLength(30);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Contract).WithMany(p => p.EmploymentContracts)
                .HasForeignKey(d => d.ContractId)
                .HasConstraintName("FK_EmploymentContracts_ContractId_Contracts");

            entity.HasOne(d => d.Employee).WithMany(p => p.EmploymentContracts)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmploymentContracts_EmployeeId_Employees");

            entity.HasOne(d => d.Tenant).WithMany(p => p.EmploymentContracts)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmploymentContracts_TenantId_Tenants");
        });

        modelBuilder.Entity<EngineeringRevision>(entity =>
        {
            entity.ToTable("EngineeringRevisions", "erp_manufacturing");

            entity.HasIndex(e => e.TenantId, "IX_EngineeringRevisions_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.RevisionCode).HasMaxLength(30);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.DrawingAttachment).WithMany(p => p.EngineeringRevisions)
                .HasForeignKey(d => d.DrawingAttachmentId)
                .HasConstraintName("FK_EngineeringRevisions_DrawingAttachmentId_Attachments");

            entity.HasOne(d => d.Item).WithMany(p => p.EngineeringRevisions)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EngineeringRevisions_ItemId_Items");

            entity.HasOne(d => d.Tenant).WithMany(p => p.EngineeringRevisions)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EngineeringRevisions_TenantId_Tenants");
        });

        modelBuilder.Entity<Enrollment>(entity =>
        {
            entity.ToTable("Enrollments", "erp_education");

            entity.HasIndex(e => e.TenantId, "IX_Enrollments_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.FinalGrade).HasMaxLength(10);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Section).WithMany(p => p.Enrollments)
                .HasForeignKey(d => d.SectionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Enrollments_SectionId_ClassSections");

            entity.HasOne(d => d.Student).WithMany(p => p.Enrollments)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Enrollments_StudentId_Students");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Enrollments)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Enrollments_TenantId_Tenants");
        });

        modelBuilder.Entity<ExchangeRate>(entity =>
        {
            entity.ToTable("ExchangeRates", "erp_core");

            entity.HasIndex(e => e.TenantId, "IX_ExchangeRates_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.FromCurrency)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.Rate).HasPrecision(20, 10);
            entity.Property(e => e.Source).HasMaxLength(80);
            entity.Property(e => e.ToCurrency)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ExchangeRates)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExchangeRates_TenantId_Tenants");
        });

        modelBuilder.Entity<FeeStructure>(entity =>
        {
            entity.ToTable("FeeStructures", "erp_education");

            entity.HasIndex(e => e.TenantId, "IX_FeeStructures_TenantId");

            entity.Property(e => e.Amount).HasPrecision(19, 4);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.FeeType).HasMaxLength(40);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.AcademicYear).WithMany(p => p.FeeStructures)
                .HasForeignKey(d => d.AcademicYearId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FeeStructures_AcademicYearId_AcademicYears");

            entity.HasOne(d => d.Program).WithMany(p => p.FeeStructures)
                .HasForeignKey(d => d.ProgramId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FeeStructures_ProgramId_AcademicPrograms");

            entity.HasOne(d => d.Tenant).WithMany(p => p.FeeStructures)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FeeStructures_TenantId_Tenants");
        });

        modelBuilder.Entity<FiscalYear>(entity =>
        {
            entity.ToTable("FiscalYears", "erp_finance");

            entity.HasIndex(e => e.TenantId, "IX_FiscalYears_TenantId");

            entity.Property(e => e.Code).HasMaxLength(20);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.LegalEntity).WithMany(p => p.FiscalYears)
                .HasForeignKey(d => d.LegalEntityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FiscalYears_LegalEntityId_LegalEntities");

            entity.HasOne(d => d.Tenant).WithMany(p => p.FiscalYears)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FiscalYears_TenantId_Tenants");
        });

        modelBuilder.Entity<FixedAsset>(entity =>
        {
            entity.ToTable("FixedAssets", "erp_finance");

            entity.HasIndex(e => e.TenantId, "IX_FixedAssets_TenantId");

            entity.Property(e => e.AcquisitionCost).HasPrecision(19, 4);
            entity.Property(e => e.AssetCode).HasMaxLength(50);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.SalvageValue).HasPrecision(19, 4);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.AssetCategory).WithMany(p => p.FixedAssets)
                .HasForeignKey(d => d.AssetCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FixedAssets_AssetCategoryId_FixedAssetCategories");

            entity.HasOne(d => d.LegalEntity).WithMany(p => p.FixedAssets)
                .HasForeignKey(d => d.LegalEntityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FixedAssets_LegalEntityId_LegalEntities");

            entity.HasOne(d => d.Location).WithMany(p => p.FixedAssets)
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("FK_FixedAssets_LocationId_WarehouseLocations");

            entity.HasOne(d => d.Tenant).WithMany(p => p.FixedAssets)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FixedAssets_TenantId_Tenants");
        });

        modelBuilder.Entity<FixedAssetCategory>(entity =>
        {
            entity.ToTable("FixedAssetCategories", "erp_finance");

            entity.HasIndex(e => e.TenantId, "IX_FixedAssetCategories_TenantId");

            entity.Property(e => e.AccumDepGlaccountId).HasColumnName("AccumDepGLAccountId");
            entity.Property(e => e.AssetGlaccountId).HasColumnName("AssetGLAccountId");
            entity.Property(e => e.Code).HasMaxLength(30);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.DepreciationExpenseGlaccountId).HasColumnName("DepreciationExpenseGLAccountId");
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.AccumDepGlaccount).WithMany(p => p.FixedAssetCategoryAccumDepGlaccounts)
                .HasForeignKey(d => d.AccumDepGlaccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FixedAssetCategories_AccumDepGLAccountId_GLAccounts");

            entity.HasOne(d => d.AssetGlaccount).WithMany(p => p.FixedAssetCategoryAssetGlaccounts)
                .HasForeignKey(d => d.AssetGlaccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FixedAssetCategories_AssetGLAccountId_GLAccounts");

            entity.HasOne(d => d.DepreciationExpenseGlaccount).WithMany(p => p.FixedAssetCategoryDepreciationExpenseGlaccounts)
                .HasForeignKey(d => d.DepreciationExpenseGlaccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FixedAssetCategories_DepreciationExpenseGLAccountI_3e4fd2b6a");

            entity.HasOne(d => d.Tenant).WithMany(p => p.FixedAssetCategories)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FixedAssetCategories_TenantId_Tenants");
        });

        modelBuilder.Entity<Glaccount>(entity =>
        {
            entity.ToTable("GLAccounts", "erp_finance");

            entity.HasIndex(e => e.TenantId, "IX_GLAccounts_TenantId");

            entity.HasIndex(e => new { e.TenantId, e.LegalEntityId, e.Code }, "UX_GLAccounts_LegalEntityId_Code").IsUnique();

            entity.Property(e => e.Code).HasMaxLength(40);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Name).HasMaxLength(160);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.AccountType).WithMany(p => p.Glaccounts)
                .HasForeignKey(d => d.AccountTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GLAccounts_AccountTypeId_AccountTypes");

            entity.HasOne(d => d.LegalEntity).WithMany(p => p.Glaccounts)
                .HasForeignKey(d => d.LegalEntityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GLAccounts_LegalEntityId_LegalEntities");

            entity.HasOne(d => d.ParentAccount).WithMany(p => p.InverseParentAccount)
                .HasForeignKey(d => d.ParentAccountId)
                .HasConstraintName("FK_GLAccounts_ParentAccountId_GLAccounts");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Glaccounts)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GLAccounts_TenantId_Tenants");
        });

        modelBuilder.Entity<GoodsReceipt>(entity =>
        {
            entity.ToTable("GoodsReceipts", "erp_procurement");

            entity.HasIndex(e => e.TenantId, "IX_GoodsReceipts_TenantId");

            entity.HasIndex(e => new { e.TenantId, e.ReceiptNo }, "UX_GoodsReceipts_ReceiptNo").IsUnique();

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.ReceiptNo).HasMaxLength(60);
            entity.Property(e => e.ReceivedAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.PurchaseOrder).WithMany(p => p.GoodsReceipts)
                .HasForeignKey(d => d.PurchaseOrderId)
                .HasConstraintName("FK_GoodsReceipts_PurchaseOrderId_PurchaseOrders");

            entity.HasOne(d => d.Tenant).WithMany(p => p.GoodsReceipts)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GoodsReceipts_TenantId_Tenants");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.GoodsReceipts)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GoodsReceipts_WarehouseId_Warehouses");
        });

        modelBuilder.Entity<GoodsReceiptLine>(entity =>
        {
            entity.ToTable("GoodsReceiptLines", "erp_procurement");

            entity.HasIndex(e => e.TenantId, "IX_GoodsReceiptLines_TenantId");

            entity.Property(e => e.AcceptedQty).HasPrecision(19, 4);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.ReceivedQty).HasPrecision(19, 4);
            entity.Property(e => e.RejectedQty).HasPrecision(19, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.GoodsReceipt).WithMany(p => p.GoodsReceiptLines)
                .HasForeignKey(d => d.GoodsReceiptId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GoodsReceiptLines_GoodsReceiptId_GoodsReceipts");

            entity.HasOne(d => d.Item).WithMany(p => p.GoodsReceiptLines)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GoodsReceiptLines_ItemId_Items");

            entity.HasOne(d => d.Location).WithMany(p => p.GoodsReceiptLines)
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("FK_GoodsReceiptLines_LocationId_WarehouseLocations");

            entity.HasOne(d => d.Lot).WithMany(p => p.GoodsReceiptLines)
                .HasForeignKey(d => d.LotId)
                .HasConstraintName("FK_GoodsReceiptLines_LotId_InventoryLots");

            entity.HasOne(d => d.PurchaseOrderLine).WithMany(p => p.GoodsReceiptLines)
                .HasForeignKey(d => d.PurchaseOrderLineId)
                .HasConstraintName("FK_GoodsReceiptLines_PurchaseOrderLineId_PurchaseOrderLines");

            entity.HasOne(d => d.Tenant).WithMany(p => p.GoodsReceiptLines)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GoodsReceiptLines_TenantId_Tenants");
        });

        modelBuilder.Entity<IntegrationEndpoint>(entity =>
        {
            entity.ToTable("IntegrationEndpoints", "erp_portal");

            entity.HasIndex(e => e.TenantId, "IX_IntegrationEndpoints_TenantId");

            entity.Property(e => e.AuthSecretReference).HasMaxLength(250);
            entity.Property(e => e.BaseUrl).HasMaxLength(500);
            entity.Property(e => e.Code).HasMaxLength(60);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Provider).HasMaxLength(100);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Tenant).WithMany(p => p.IntegrationEndpoints)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IntegrationEndpoints_TenantId_Tenants");
        });

        modelBuilder.Entity<IntegrationMessage>(entity =>
        {
            entity.ToTable("IntegrationMessages", "erp_portal");

            entity.HasIndex(e => e.TenantId, "IX_IntegrationMessages_TenantId");

            entity.Property(e => e.CreatedAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Direction).HasMaxLength(10);
            entity.Property(e => e.EntityType).HasMaxLength(50);
            entity.Property(e => e.ExternalId).HasMaxLength(150);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Endpoint).WithMany(p => p.IntegrationMessages)
                .HasForeignKey(d => d.EndpointId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IntegrationMessages_EndpointId_IntegrationEndpoints");

            entity.HasOne(d => d.Tenant).WithMany(p => p.IntegrationMessages)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IntegrationMessages_TenantId_Tenants");
        });

        modelBuilder.Entity<IntercompanyTransaction>(entity =>
        {
            entity.ToTable("IntercompanyTransactions", "erp_finance");

            entity.HasIndex(e => e.TenantId, "IX_IntercompanyTransactions_TenantId");

            entity.Property(e => e.Amount).HasPrecision(19, 4);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.DocumentType).HasMaxLength(40);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.FromLegalEntity).WithMany(p => p.IntercompanyTransactionFromLegalEntities)
                .HasForeignKey(d => d.FromLegalEntityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IntercompanyTransactions_FromLegalEntityId_LegalEntities");

            entity.HasOne(d => d.Tenant).WithMany(p => p.IntercompanyTransactions)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IntercompanyTransactions_TenantId_Tenants");

            entity.HasOne(d => d.ToLegalEntity).WithMany(p => p.IntercompanyTransactionToLegalEntities)
                .HasForeignKey(d => d.ToLegalEntityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IntercompanyTransactions_ToLegalEntityId_LegalEntities");
        });

        modelBuilder.Entity<Interview>(entity =>
        {
            entity.ToTable("Interviews", "erp_hr");

            entity.HasIndex(e => e.TenantId, "IX_Interviews_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Outcome).HasMaxLength(30);
            entity.Property(e => e.ScheduledAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Application).WithMany(p => p.Interviews)
                .HasForeignKey(d => d.ApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Interviews_ApplicationId_JobApplications");

            entity.HasOne(d => d.InterviewerEmployee).WithMany(p => p.Interviews)
                .HasForeignKey(d => d.InterviewerEmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Interviews_InterviewerEmployeeId_Employees");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Interviews)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Interviews_TenantId_Tenants");
        });

        modelBuilder.Entity<InventoryBalance>(entity =>
        {
            entity.ToTable("InventoryBalances", "erp_inventory");

            entity.HasIndex(e => e.TenantId, "IX_InventoryBalances_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.LastCalculatedAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.OnHand).HasPrecision(19, 4);
            entity.Property(e => e.Reserved).HasPrecision(19, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Item).WithMany(p => p.InventoryBalances)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryBalances_ItemId_Items");

            entity.HasOne(d => d.Location).WithMany(p => p.InventoryBalances)
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("FK_InventoryBalances_LocationId_WarehouseLocations");

            entity.HasOne(d => d.Lot).WithMany(p => p.InventoryBalances)
                .HasForeignKey(d => d.LotId)
                .HasConstraintName("FK_InventoryBalances_LotId_InventoryLots");

            entity.HasOne(d => d.Tenant).WithMany(p => p.InventoryBalances)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryBalances_TenantId_Tenants");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.InventoryBalances)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryBalances_WarehouseId_Warehouses");
        });

        modelBuilder.Entity<InventoryLot>(entity =>
        {
            entity.ToTable("InventoryLots", "erp_inventory");

            entity.HasIndex(e => e.TenantId, "IX_InventoryLots_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.LotNo).HasMaxLength(80);
            entity.Property(e => e.QualityStatus).HasMaxLength(30);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Item).WithMany(p => p.InventoryLots)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryLots_ItemId_Items");

            entity.HasOne(d => d.Tenant).WithMany(p => p.InventoryLots)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryLots_TenantId_Tenants");
        });

        modelBuilder.Entity<InventoryReservation>(entity =>
        {
            entity.ToTable("InventoryReservations", "erp_inventory");

            entity.HasIndex(e => e.TenantId, "IX_InventoryReservations_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Quantity).HasPrecision(19, 4);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Item).WithMany(p => p.InventoryReservations)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryReservations_ItemId_Items");

            entity.HasOne(d => d.SalesOrderLine).WithMany(p => p.InventoryReservations)
                .HasForeignKey(d => d.SalesOrderLineId)
                .HasConstraintName("FK_InventoryReservations_SalesOrderLineId_SalesOrderLines");

            entity.HasOne(d => d.Tenant).WithMany(p => p.InventoryReservations)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryReservations_TenantId_Tenants");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.InventoryReservations)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryReservations_WarehouseId_Warehouses");

            entity.HasOne(d => d.WorkOrder).WithMany(p => p.InventoryReservations)
                .HasForeignKey(d => d.WorkOrderId)
                .HasConstraintName("FK_InventoryReservations_WorkOrderId_WorkOrders");
        });

        modelBuilder.Entity<InventorySerial>(entity =>
        {
            entity.ToTable("InventorySerials", "erp_inventory");

            entity.HasIndex(e => e.TenantId, "IX_InventorySerials_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.SerialNo).HasMaxLength(120);
            entity.Property(e => e.Status).HasMaxLength(30);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Item).WithMany(p => p.InventorySerials)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventorySerials_ItemId_Items");

            entity.HasOne(d => d.Lot).WithMany(p => p.InventorySerials)
                .HasForeignKey(d => d.LotId)
                .HasConstraintName("FK_InventorySerials_LotId_InventoryLots");

            entity.HasOne(d => d.Tenant).WithMany(p => p.InventorySerials)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventorySerials_TenantId_Tenants");
        });

        modelBuilder.Entity<InventoryTransaction>(entity =>
        {
            entity.ToTable("InventoryTransactions", "erp_inventory");

            entity.HasIndex(e => e.TenantId, "IX_InventoryTransactions_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.OccurredAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Quantity).HasPrecision(19, 4);
            entity.Property(e => e.SourceType).HasMaxLength(60);
            entity.Property(e => e.TransactionType).HasMaxLength(30);
            entity.Property(e => e.UnitCost).HasPrecision(19, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Item).WithMany(p => p.InventoryTransactions)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryTransactions_ItemId_Items");

            entity.HasOne(d => d.Location).WithMany(p => p.InventoryTransactions)
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("FK_InventoryTransactions_LocationId_WarehouseLocations");

            entity.HasOne(d => d.Lot).WithMany(p => p.InventoryTransactions)
                .HasForeignKey(d => d.LotId)
                .HasConstraintName("FK_InventoryTransactions_LotId_InventoryLots");

            entity.HasOne(d => d.Serial).WithMany(p => p.InventoryTransactions)
                .HasForeignKey(d => d.SerialId)
                .HasConstraintName("FK_InventoryTransactions_SerialId_InventorySerials");

            entity.HasOne(d => d.Tenant).WithMany(p => p.InventoryTransactions)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryTransactions_TenantId_Tenants");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.InventoryTransactions)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryTransactions_WarehouseId_Warehouses");
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.ToTable("Items", "erp_inventory");

            entity.HasIndex(e => e.TenantId, "IX_Items_TenantId");

            entity.HasIndex(e => new { e.TenantId, e.Sku }, "UX_Items_SKU").IsUnique();

            entity.Property(e => e.BaseUomid).HasColumnName("BaseUOMId");
            entity.Property(e => e.CostMethod).HasMaxLength(20);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.ItemType).HasMaxLength(25);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Sku)
                .HasMaxLength(70)
                .HasColumnName("SKU");
            entity.Property(e => e.StandardCost).HasPrecision(19, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.BaseUom).WithMany(p => p.Items)
                .HasForeignKey(d => d.BaseUomid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Items_BaseUOMId_UnitsOfMeasure");

            entity.HasOne(d => d.Category).WithMany(p => p.Items)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_Items_CategoryId_ItemCategories");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Items)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Items_TenantId_Tenants");
        });

        modelBuilder.Entity<ItemCategory>(entity =>
        {
            entity.ToTable("ItemCategories", "erp_inventory");

            entity.HasIndex(e => e.TenantId, "IX_ItemCategories_TenantId");

            entity.Property(e => e.Code).HasMaxLength(30);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.ParentCategory).WithMany(p => p.InverseParentCategory)
                .HasForeignKey(d => d.ParentCategoryId)
                .HasConstraintName("FK_ItemCategories_ParentCategoryId_ItemCategories");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ItemCategories)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemCategories_TenantId_Tenants");
        });

        modelBuilder.Entity<ItemPrice>(entity =>
        {
            entity.ToTable("ItemPrices", "erp_inventory");

            entity.HasIndex(e => e.TenantId, "IX_ItemPrices_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.UnitPrice).HasPrecision(19, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Item).WithMany(p => p.ItemPrices)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemPrices_ItemId_Items");

            entity.HasOne(d => d.PriceList).WithMany(p => p.ItemPrices)
                .HasForeignKey(d => d.PriceListId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemPrices_PriceListId_PriceLists");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ItemPrices)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemPrices_TenantId_Tenants");
        });

        modelBuilder.Entity<JobApplication>(entity =>
        {
            entity.ToTable("JobApplications", "erp_hr");

            entity.HasIndex(e => e.TenantId, "IX_JobApplications_TenantId");

            entity.Property(e => e.AppliedAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Stage).HasMaxLength(40);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Candidate).WithMany(p => p.JobApplications)
                .HasForeignKey(d => d.CandidateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JobApplications_CandidateId_Candidates");

            entity.HasOne(d => d.Requisition).WithMany(p => p.JobApplications)
                .HasForeignKey(d => d.RequisitionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JobApplications_RequisitionId_RecruitmentRequisitions");

            entity.HasOne(d => d.Tenant).WithMany(p => p.JobApplications)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JobApplications_TenantId_Tenants");
        });

        modelBuilder.Entity<JobPosition>(entity =>
        {
            entity.ToTable("JobPositions", "erp_hr");

            entity.HasIndex(e => e.TenantId, "IX_JobPositions_TenantId");

            entity.Property(e => e.Code).HasMaxLength(40);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Title).HasMaxLength(160);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Department).WithMany(p => p.JobPositions)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JobPositions_DepartmentId_Departments");

            entity.HasOne(d => d.Grade).WithMany(p => p.JobPositions)
                .HasForeignKey(d => d.GradeId)
                .HasConstraintName("FK_JobPositions_GradeId_PayGrades");

            entity.HasOne(d => d.ReportsToPosition).WithMany(p => p.InverseReportsToPosition)
                .HasForeignKey(d => d.ReportsToPositionId)
                .HasConstraintName("FK_JobPositions_ReportsToPositionId_JobPositions");

            entity.HasOne(d => d.Tenant).WithMany(p => p.JobPositions)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JobPositions_TenantId_Tenants");
        });

        modelBuilder.Entity<JournalBatch>(entity =>
        {
            entity.ToTable("JournalBatches", "erp_finance");

            entity.HasIndex(e => e.TenantId, "IX_JournalBatches_TenantId");

            entity.Property(e => e.BatchNo).HasMaxLength(40);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.PostedAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Source).HasMaxLength(40);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.LegalEntity).WithMany(p => p.JournalBatches)
                .HasForeignKey(d => d.LegalEntityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JournalBatches_LegalEntityId_LegalEntities");

            entity.HasOne(d => d.Period).WithMany(p => p.JournalBatches)
                .HasForeignKey(d => d.PeriodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JournalBatches_PeriodId_AccountingPeriods");

            entity.HasOne(d => d.Tenant).WithMany(p => p.JournalBatches)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JournalBatches_TenantId_Tenants");
        });

        modelBuilder.Entity<JournalEntry>(entity =>
        {
            entity.ToTable("JournalEntries", "erp_finance");

            entity.HasIndex(e => e.TenantId, "IX_JournalEntries_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.EntryNo).HasMaxLength(50);
            entity.Property(e => e.PostedAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.SourceType).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Batch).WithMany(p => p.JournalEntries)
                .HasForeignKey(d => d.BatchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JournalEntries_BatchId_JournalBatches");

            entity.HasOne(d => d.Tenant).WithMany(p => p.JournalEntries)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JournalEntries_TenantId_Tenants");
        });

        modelBuilder.Entity<JournalLine>(entity =>
        {
            entity.ToTable("JournalLines", "erp_finance");

            entity.HasIndex(e => e.TenantId, "IX_JournalLines_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Credit).HasPrecision(19, 4);
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.Debit).HasPrecision(19, 4);
            entity.Property(e => e.Description).HasMaxLength(300);
            entity.Property(e => e.ExchangeRate).HasPrecision(20, 10);
            entity.Property(e => e.GlaccountId).HasColumnName("GLAccountId");
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.CostCenter).WithMany(p => p.JournalLines)
                .HasForeignKey(d => d.CostCenterId)
                .HasConstraintName("FK_JournalLines_CostCenterId_CostCenters");

            entity.HasOne(d => d.Entry).WithMany(p => p.JournalLines)
                .HasForeignKey(d => d.EntryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JournalLines_EntryId_JournalEntries");

            entity.HasOne(d => d.Glaccount).WithMany(p => p.JournalLines)
                .HasForeignKey(d => d.GlaccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JournalLines_GLAccountId_GLAccounts");

            entity.HasOne(d => d.Tenant).WithMany(p => p.JournalLines)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JournalLines_TenantId_Tenants");
        });

        modelBuilder.Entity<Kpivalue>(entity =>
        {
            entity.ToTable("KPIValues", "erp_management");

            entity.HasIndex(e => e.TenantId, "IX_KPIValues_TenantId");

            entity.Property(e => e.ActualValue).HasPrecision(19, 4);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Kpiid).HasColumnName("KPIId");
            entity.Property(e => e.TargetValue).HasPrecision(19, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Kpi).WithMany(p => p.Kpivalues)
                .HasForeignKey(d => d.Kpiid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KPIValues_KPIId_ManagementKPIs");

            entity.HasOne(d => d.Period).WithMany(p => p.Kpivalues)
                .HasForeignKey(d => d.PeriodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KPIValues_PeriodId_AccountingPeriods");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Kpivalues)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KPIValues_TenantId_Tenants");
        });

        modelBuilder.Entity<Lead>(entity =>
        {
            entity.ToTable("Leads", "erp_crm");

            entity.HasIndex(e => e.TenantId, "IX_Leads_TenantId");

            entity.Property(e => e.CompanyName).HasMaxLength(160);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Email).HasMaxLength(254);
            entity.Property(e => e.FullName).HasMaxLength(160);
            entity.Property(e => e.Phone).HasMaxLength(40);
            entity.Property(e => e.Source).HasMaxLength(80);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.OwnerEmployee).WithMany(p => p.Leads)
                .HasForeignKey(d => d.OwnerEmployeeId)
                .HasConstraintName("FK_Leads_OwnerEmployeeId_Employees");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Leads)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Leads_TenantId_Tenants");
        });

        modelBuilder.Entity<LeaveBalance>(entity =>
        {
            entity.ToTable("LeaveBalances", "erp_hr");

            entity.HasIndex(e => e.TenantId, "IX_LeaveBalances_TenantId");

            entity.Property(e => e.AccruedDays).HasPrecision(19, 4);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.OpeningDays).HasPrecision(19, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.UsedDays).HasPrecision(19, 4);

            entity.HasOne(d => d.Employee).WithMany(p => p.LeaveBalances)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeaveBalances_EmployeeId_Employees");

            entity.HasOne(d => d.FiscalYear).WithMany(p => p.LeaveBalances)
                .HasForeignKey(d => d.FiscalYearId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeaveBalances_FiscalYearId_FiscalYears");

            entity.HasOne(d => d.LeaveType).WithMany(p => p.LeaveBalances)
                .HasForeignKey(d => d.LeaveTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeaveBalances_LeaveTypeId_LeaveTypes");

            entity.HasOne(d => d.Tenant).WithMany(p => p.LeaveBalances)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeaveBalances_TenantId_Tenants");
        });

        modelBuilder.Entity<LeaveRequest>(entity =>
        {
            entity.ToTable("LeaveRequests", "erp_hr");

            entity.HasIndex(e => e.TenantId, "IX_LeaveRequests_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Days).HasPrecision(19, 4);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.ApprovedByEmployee).WithMany(p => p.LeaveRequestApprovedByEmployees)
                .HasForeignKey(d => d.ApprovedByEmployeeId)
                .HasConstraintName("FK_LeaveRequests_ApprovedByEmployeeId_Employees");

            entity.HasOne(d => d.Employee).WithMany(p => p.LeaveRequestEmployees)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeaveRequests_EmployeeId_Employees");

            entity.HasOne(d => d.LeaveType).WithMany(p => p.LeaveRequests)
                .HasForeignKey(d => d.LeaveTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeaveRequests_LeaveTypeId_LeaveTypes");

            entity.HasOne(d => d.Tenant).WithMany(p => p.LeaveRequests)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeaveRequests_TenantId_Tenants");
        });

        modelBuilder.Entity<LeaveType>(entity =>
        {
            entity.ToTable("LeaveTypes", "erp_hr");

            entity.HasIndex(e => e.TenantId, "IX_LeaveTypes_TenantId");

            entity.Property(e => e.AnnualEntitlementDays).HasPrecision(19, 4);
            entity.Property(e => e.Code).HasMaxLength(30);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Tenant).WithMany(p => p.LeaveTypes)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeaveTypes_TenantId_Tenants");
        });

        modelBuilder.Entity<LegalEntity>(entity =>
        {
            entity.ToTable("LegalEntities", "erp_core");

            entity.HasIndex(e => e.TenantId, "IX_LegalEntities_TenantId");

            entity.HasIndex(e => new { e.TenantId, e.Code }, "UX_LegalEntities_Code").IsUnique();

            entity.Property(e => e.Code).HasMaxLength(30);
            entity.Property(e => e.CountryCode)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.FunctionalCurrency)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.Name).HasMaxLength(160);
            entity.Property(e => e.TaxRegistration).HasMaxLength(80);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.ParentLegalEntity).WithMany(p => p.InverseParentLegalEntity)
                .HasForeignKey(d => d.ParentLegalEntityId)
                .HasConstraintName("FK_LegalEntities_ParentLegalEntityId_LegalEntities");

            entity.HasOne(d => d.Tenant).WithMany(p => p.LegalEntities)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LegalEntities_TenantId_Tenants");
        });

        modelBuilder.Entity<ManagementKpi>(entity =>
        {
            entity.ToTable("ManagementKPIs", "erp_management");

            entity.HasIndex(e => e.TenantId, "IX_ManagementKPIs_TenantId");

            entity.Property(e => e.Code).HasMaxLength(60);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Name).HasMaxLength(160);
            entity.Property(e => e.Unit).HasMaxLength(30);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ManagementKpis)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ManagementKPIs_TenantId_Tenants");
        });

        modelBuilder.Entity<MarketingCampaign>(entity =>
        {
            entity.ToTable("MarketingCampaigns", "erp_crm");

            entity.HasIndex(e => e.TenantId, "IX_MarketingCampaigns_TenantId");

            entity.Property(e => e.Budget).HasPrecision(19, 4);
            entity.Property(e => e.Channel).HasMaxLength(40);
            entity.Property(e => e.Code).HasMaxLength(40);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Name).HasMaxLength(160);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Tenant).WithMany(p => p.MarketingCampaigns)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MarketingCampaigns_TenantId_Tenants");
        });

        modelBuilder.Entity<MaterialIssue>(entity =>
        {
            entity.ToTable("MaterialIssues", "erp_manufacturing");

            entity.HasIndex(e => e.TenantId, "IX_MaterialIssues_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.IssuedAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Quantity).HasPrecision(19, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.InventoryTransaction).WithMany(p => p.MaterialIssues)
                .HasForeignKey(d => d.InventoryTransactionId)
                .HasConstraintName("FK_MaterialIssues_InventoryTransactionId_InventoryTransactions");

            entity.HasOne(d => d.Item).WithMany(p => p.MaterialIssues)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialIssues_ItemId_Items");

            entity.HasOne(d => d.Tenant).WithMany(p => p.MaterialIssues)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialIssues_TenantId_Tenants");

            entity.HasOne(d => d.WorkOrder).WithMany(p => p.MaterialIssues)
                .HasForeignKey(d => d.WorkOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaterialIssues_WorkOrderId_WorkOrders");
        });

        modelBuilder.Entity<NonConformance>(entity =>
        {
            entity.ToTable("NonConformances", "erp_manufacturing");

            entity.HasIndex(e => e.TenantId, "IX_NonConformances_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.OpenedAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Severity).HasMaxLength(20);
            entity.Property(e => e.SourceType).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Item).WithMany(p => p.NonConformances)
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("FK_NonConformances_ItemId_Items");

            entity.HasOne(d => d.Tenant).WithMany(p => p.NonConformances)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NonConformances_TenantId_Tenants");
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.ToTable("Notifications", "erp_core");

            entity.HasIndex(e => e.TenantId, "IX_Notifications_TenantId");

            entity.Property(e => e.Body).HasMaxLength(1000);
            entity.Property(e => e.Channel).HasMaxLength(30);
            entity.Property(e => e.CreatedAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.ReadAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Title).HasMaxLength(160);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Notifications)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Notifications_TenantId_Tenants");

            entity.HasOne(d => d.TenantUser).WithMany(p => p.Notifications)
                .HasForeignKey(d => d.TenantUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Notifications_TenantUserId_TenantUsers");
        });

        modelBuilder.Entity<NumberSequence>(entity =>
        {
            entity.ToTable("NumberSequences", "erp_core");

            entity.HasIndex(e => e.TenantId, "IX_NumberSequences_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.DocumentType).HasMaxLength(60);
            entity.Property(e => e.Prefix).HasMaxLength(20);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Tenant).WithMany(p => p.NumberSequences)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NumberSequences_TenantId_Tenants");
        });

        modelBuilder.Entity<Opportunity>(entity =>
        {
            entity.ToTable("Opportunities", "erp_crm");

            entity.HasIndex(e => e.TenantId, "IX_Opportunities_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.ExpectedValue).HasPrecision(19, 4);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.ProbabilityPercent).HasPrecision(9, 4);
            entity.Property(e => e.Stage).HasMaxLength(50);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Customer).WithMany(p => p.Opportunities)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_Opportunities_CustomerId_Customers");

            entity.HasOne(d => d.Lead).WithMany(p => p.Opportunities)
                .HasForeignKey(d => d.LeadId)
                .HasConstraintName("FK_Opportunities_LeadId_Leads");

            entity.HasOne(d => d.OwnerEmployee).WithMany(p => p.Opportunities)
                .HasForeignKey(d => d.OwnerEmployeeId)
                .HasConstraintName("FK_Opportunities_OwnerEmployeeId_Employees");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Opportunities)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Opportunities_TenantId_Tenants");
        });

        modelBuilder.Entity<OpportunityActivity>(entity =>
        {
            entity.ToTable("OpportunityActivities", "erp_crm");

            entity.HasIndex(e => e.TenantId, "IX_OpportunityActivities_TenantId");

            entity.Property(e => e.ActivityType).HasMaxLength(40);
            entity.Property(e => e.CompletedAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.DueAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Notes).HasMaxLength(1000);
            entity.Property(e => e.Subject).HasMaxLength(200);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Employee).WithMany(p => p.OpportunityActivities)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_OpportunityActivities_EmployeeId_Employees");

            entity.HasOne(d => d.Opportunity).WithMany(p => p.OpportunityActivities)
                .HasForeignKey(d => d.OpportunityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OpportunityActivities_OpportunityId_Opportunities");

            entity.HasOne(d => d.Tenant).WithMany(p => p.OpportunityActivities)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OpportunityActivities_TenantId_Tenants");
        });

        modelBuilder.Entity<PayComponent>(entity =>
        {
            entity.ToTable("PayComponents", "erp_hr");

            entity.HasIndex(e => e.TenantId, "IX_PayComponents_TenantId");

            entity.Property(e => e.Code).HasMaxLength(40);
            entity.Property(e => e.ComponentType).HasMaxLength(20);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.GlaccountId).HasColumnName("GLAccountId");
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Glaccount).WithMany(p => p.PayComponents)
                .HasForeignKey(d => d.GlaccountId)
                .HasConstraintName("FK_PayComponents_GLAccountId_GLAccounts");

            entity.HasOne(d => d.Tenant).WithMany(p => p.PayComponents)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PayComponents_TenantId_Tenants");
        });

        modelBuilder.Entity<PayGrade>(entity =>
        {
            entity.ToTable("PayGrades", "erp_hr");

            entity.HasIndex(e => e.TenantId, "IX_PayGrades_TenantId");

            entity.Property(e => e.Code).HasMaxLength(30);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.MaxSalary).HasPrecision(19, 4);
            entity.Property(e => e.MinSalary).HasPrecision(19, 4);
            entity.Property(e => e.Name).HasMaxLength(80);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Tenant).WithMany(p => p.PayGrades)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PayGrades_TenantId_Tenants");
        });

        modelBuilder.Entity<PayrollPeriod>(entity =>
        {
            entity.ToTable("PayrollPeriods", "erp_hr");

            entity.HasIndex(e => e.TenantId, "IX_PayrollPeriods_TenantId");

            entity.HasIndex(e => new { e.TenantId, e.PeriodStart, e.PeriodEnd }, "UX_PayrollPeriods_PeriodStart_PeriodEnd").IsUnique();

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Tenant).WithMany(p => p.PayrollPeriods)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PayrollPeriods_TenantId_Tenants");
        });

        modelBuilder.Entity<PayrollRun>(entity =>
        {
            entity.ToTable("PayrollRuns", "erp_hr");

            entity.HasIndex(e => e.TenantId, "IX_PayrollRuns_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.JournalEntry).WithMany(p => p.PayrollRuns)
                .HasForeignKey(d => d.JournalEntryId)
                .HasConstraintName("FK_PayrollRuns_JournalEntryId_JournalEntries");

            entity.HasOne(d => d.PayrollPeriod).WithMany(p => p.PayrollRuns)
                .HasForeignKey(d => d.PayrollPeriodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PayrollRuns_PayrollPeriodId_PayrollPeriods");

            entity.HasOne(d => d.Tenant).WithMany(p => p.PayrollRuns)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PayrollRuns_TenantId_Tenants");
        });

        modelBuilder.Entity<Payslip>(entity =>
        {
            entity.ToTable("Payslips", "erp_hr");

            entity.HasIndex(e => e.TenantId, "IX_Payslips_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.GrossPay).HasPrecision(19, 4);
            entity.Property(e => e.NetPay).HasPrecision(19, 4);
            entity.Property(e => e.TotalDeductions).HasPrecision(19, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Employee).WithMany(p => p.Payslips)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Payslips_EmployeeId_Employees");

            entity.HasOne(d => d.PayrollRun).WithMany(p => p.Payslips)
                .HasForeignKey(d => d.PayrollRunId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Payslips_PayrollRunId_PayrollRuns");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Payslips)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Payslips_TenantId_Tenants");
        });

        modelBuilder.Entity<PayslipLine>(entity =>
        {
            entity.ToTable("PayslipLines", "erp_hr");

            entity.HasIndex(e => e.TenantId, "IX_PayslipLines_TenantId");

            entity.Property(e => e.Amount).HasPrecision(19, 4);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.PayComponent).WithMany(p => p.PayslipLines)
                .HasForeignKey(d => d.PayComponentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PayslipLines_PayComponentId_PayComponents");

            entity.HasOne(d => d.Payslip).WithMany(p => p.PayslipLines)
                .HasForeignKey(d => d.PayslipId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PayslipLines_PayslipId_Payslips");

            entity.HasOne(d => d.Tenant).WithMany(p => p.PayslipLines)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PayslipLines_TenantId_Tenants");
        });

        modelBuilder.Entity<PensionPlan>(entity =>
        {
            entity.ToTable("PensionPlans", "erp_hr");

            entity.HasIndex(e => e.TenantId, "IX_PensionPlans_TenantId");

            entity.Property(e => e.Code).HasMaxLength(30);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.EmployeeRate).HasPrecision(9, 4);
            entity.Property(e => e.EmployerRate).HasPrecision(9, 4);
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Tenant).WithMany(p => p.PensionPlans)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PensionPlans_TenantId_Tenants");
        });

        modelBuilder.Entity<PerformanceReview>(entity =>
        {
            entity.ToTable("PerformanceReviews", "erp_hr");

            entity.HasIndex(e => e.TenantId, "IX_PerformanceReviews_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Notes).HasMaxLength(1000);
            entity.Property(e => e.Rating).HasPrecision(9, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Employee).WithMany(p => p.PerformanceReviewEmployees)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PerformanceReviews_EmployeeId_Employees");

            entity.HasOne(d => d.ReviewerEmployee).WithMany(p => p.PerformanceReviewReviewerEmployees)
                .HasForeignKey(d => d.ReviewerEmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PerformanceReviews_ReviewerEmployeeId_Employees");

            entity.HasOne(d => d.Tenant).WithMany(p => p.PerformanceReviews)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PerformanceReviews_TenantId_Tenants");
        });

        modelBuilder.Entity<Permission>(entity =>
        {
            entity.ToTable("Permissions", "erp_core");

            entity.HasIndex(e => e.TenantId, "IX_Permissions_TenantId");

            entity.HasIndex(e => new { e.TenantId, e.Code }, "UX_Permissions_Code").IsUnique();

            entity.Property(e => e.Code).HasMaxLength(120);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Description).HasMaxLength(300);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Permissions)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Permissions_TenantId_Tenants");
        });

        modelBuilder.Entity<PortalAccount>(entity =>
        {
            entity.ToTable("PortalAccounts", "erp_portal");

            entity.HasIndex(e => e.TenantId, "IX_PortalAccounts_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.PortalType).HasMaxLength(30);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Customer).WithMany(p => p.PortalAccounts)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_PortalAccounts_CustomerId_Customers");

            entity.HasOne(d => d.Employee).WithMany(p => p.PortalAccounts)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_PortalAccounts_EmployeeId_Employees");

            entity.HasOne(d => d.Student).WithMany(p => p.PortalAccounts)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_PortalAccounts_StudentId_Students");

            entity.HasOne(d => d.Supplier).WithMany(p => p.PortalAccounts)
                .HasForeignKey(d => d.SupplierId)
                .HasConstraintName("FK_PortalAccounts_SupplierId_Suppliers");

            entity.HasOne(d => d.Tenant).WithMany(p => p.PortalAccounts)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PortalAccounts_TenantId_Tenants");

            entity.HasOne(d => d.TenantUser).WithMany(p => p.PortalAccounts)
                .HasForeignKey(d => d.TenantUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PortalAccounts_TenantUserId_TenantUsers");
        });

        modelBuilder.Entity<PriceList>(entity =>
        {
            entity.ToTable("PriceLists", "erp_sales");

            entity.HasIndex(e => e.TenantId, "IX_PriceLists_TenantId");

            entity.Property(e => e.Code).HasMaxLength(40);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Tenant).WithMany(p => p.PriceLists)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PriceLists_TenantId_Tenants");
        });

        modelBuilder.Entity<ProductLifecycleChange>(entity =>
        {
            entity.ToTable("ProductLifecycleChanges", "erp_manufacturing");

            entity.HasIndex(e => e.TenantId, "IX_ProductLifecycleChanges_TenantId");

            entity.Property(e => e.ApprovalStatus).HasMaxLength(24);
            entity.Property(e => e.ChangeNo).HasMaxLength(60);
            entity.Property(e => e.ChangeType).HasMaxLength(40);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Item).WithMany(p => p.ProductLifecycleChanges)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductLifecycleChanges_ItemId_Items");

            entity.HasOne(d => d.Revision).WithMany(p => p.ProductLifecycleChanges)
                .HasForeignKey(d => d.RevisionId)
                .HasConstraintName("FK_ProductLifecycleChanges_RevisionId_EngineeringRevisions");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ProductLifecycleChanges)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductLifecycleChanges_TenantId_Tenants");
        });

        modelBuilder.Entity<ProductionPlan>(entity =>
        {
            entity.ToTable("ProductionPlans", "erp_manufacturing");

            entity.HasIndex(e => e.TenantId, "IX_ProductionPlans_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.PlanNo).HasMaxLength(60);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ProductionPlans)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductionPlans_TenantId_Tenants");
        });

        modelBuilder.Entity<ProductionPlanLine>(entity =>
        {
            entity.ToTable("ProductionPlanLines", "erp_manufacturing");

            entity.HasIndex(e => e.TenantId, "IX_ProductionPlanLines_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.PlannedQty).HasPrecision(19, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Item).WithMany(p => p.ProductionPlanLines)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductionPlanLines_ItemId_Items");

            entity.HasOne(d => d.Plan).WithMany(p => p.ProductionPlanLines)
                .HasForeignKey(d => d.PlanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductionPlanLines_PlanId_ProductionPlans");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ProductionPlanLines)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductionPlanLines_TenantId_Tenants");
        });

        modelBuilder.Entity<ProductionReceipt>(entity =>
        {
            entity.ToTable("ProductionReceipts", "erp_manufacturing");

            entity.HasIndex(e => e.TenantId, "IX_ProductionReceipts_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.GoodQty).HasPrecision(19, 4);
            entity.Property(e => e.ReceivedAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.ScrapQty).HasPrecision(19, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.InventoryTransaction).WithMany(p => p.ProductionReceipts)
                .HasForeignKey(d => d.InventoryTransactionId)
                .HasConstraintName("FK_ProductionReceipts_InventoryTransactionId_Inventor_c95aab97e");

            entity.HasOne(d => d.Item).WithMany(p => p.ProductionReceipts)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductionReceipts_ItemId_Items");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ProductionReceipts)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductionReceipts_TenantId_Tenants");

            entity.HasOne(d => d.WorkOrder).WithMany(p => p.ProductionReceipts)
                .HasForeignKey(d => d.WorkOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductionReceipts_WorkOrderId_WorkOrders");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.ToTable("Projects", "erp_projects");

            entity.HasIndex(e => e.TenantId, "IX_Projects_TenantId");

            entity.HasIndex(e => new { e.TenantId, e.ProjectCode }, "UX_Projects_ProjectCode").IsUnique();

            entity.Property(e => e.BudgetAmount).HasPrecision(19, 4);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.ProjectCode).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Customer).WithMany(p => p.Projects)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_Projects_CustomerId_Customers");

            entity.HasOne(d => d.ManagerEmployee).WithMany(p => p.Projects)
                .HasForeignKey(d => d.ManagerEmployeeId)
                .HasConstraintName("FK_Projects_ManagerEmployeeId_Employees");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Projects)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Projects_TenantId_Tenants");
        });

        modelBuilder.Entity<ProjectBilling>(entity =>
        {
            entity.ToTable("ProjectBillings", "erp_projects");

            entity.HasIndex(e => e.TenantId, "IX_ProjectBillings_TenantId");

            entity.Property(e => e.ArinvoiceId).HasColumnName("ARInvoiceId");
            entity.Property(e => e.BillableAmount).HasPrecision(19, 4);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Arinvoice).WithMany(p => p.ProjectBillings)
                .HasForeignKey(d => d.ArinvoiceId)
                .HasConstraintName("FK_ProjectBillings_ARInvoiceId_ARInvoices");

            entity.HasOne(d => d.Milestone).WithMany(p => p.ProjectBillings)
                .HasForeignKey(d => d.MilestoneId)
                .HasConstraintName("FK_ProjectBillings_MilestoneId_ProjectMilestones");

            entity.HasOne(d => d.Project).WithMany(p => p.ProjectBillings)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProjectBillings_ProjectId_Projects");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ProjectBillings)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProjectBillings_TenantId_Tenants");
        });

        modelBuilder.Entity<ProjectExpense>(entity =>
        {
            entity.ToTable("ProjectExpenses", "erp_projects");

            entity.HasIndex(e => e.TenantId, "IX_ProjectExpenses_TenantId");

            entity.Property(e => e.Amount).HasPrecision(19, 4);
            entity.Property(e => e.Category).HasMaxLength(60);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Employee).WithMany(p => p.ProjectExpenses)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_ProjectExpenses_EmployeeId_Employees");

            entity.HasOne(d => d.Project).WithMany(p => p.ProjectExpenses)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProjectExpenses_ProjectId_Projects");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ProjectExpenses)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProjectExpenses_TenantId_Tenants");
        });

        modelBuilder.Entity<ProjectMilestone>(entity =>
        {
            entity.ToTable("ProjectMilestones", "erp_projects");

            entity.HasIndex(e => e.TenantId, "IX_ProjectMilestones_TenantId");

            entity.Property(e => e.BillingAmount).HasPrecision(19, 4);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Name).HasMaxLength(160);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Project).WithMany(p => p.ProjectMilestones)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProjectMilestones_ProjectId_Projects");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ProjectMilestones)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProjectMilestones_TenantId_Tenants");
        });

        modelBuilder.Entity<ProjectResource>(entity =>
        {
            entity.ToTable("ProjectResources", "erp_projects");

            entity.HasIndex(e => e.TenantId, "IX_ProjectResources_TenantId");

            entity.Property(e => e.AllocationPercent).HasPrecision(9, 4);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.RoleDescription).HasMaxLength(120);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Employee).WithMany(p => p.ProjectResources)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProjectResources_EmployeeId_Employees");

            entity.HasOne(d => d.Project).WithMany(p => p.ProjectResources)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProjectResources_ProjectId_Projects");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ProjectResources)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProjectResources_TenantId_Tenants");
        });

        modelBuilder.Entity<ProjectRiskRegister>(entity =>
        {
            entity.ToTable("ProjectRiskRegister", "erp_projects");

            entity.HasIndex(e => e.TenantId, "IX_ProjectRiskRegister_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Impact).HasMaxLength(20);
            entity.Property(e => e.Mitigation).HasMaxLength(1000);
            entity.Property(e => e.Probability).HasMaxLength(20);
            entity.Property(e => e.RiskDescription).HasMaxLength(800);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.OwnerEmployee).WithMany(p => p.ProjectRiskRegisters)
                .HasForeignKey(d => d.OwnerEmployeeId)
                .HasConstraintName("FK_ProjectRiskRegister_OwnerEmployeeId_Employees");

            entity.HasOne(d => d.Project).WithMany(p => p.ProjectRiskRegisters)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProjectRiskRegister_ProjectId_Projects");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ProjectRiskRegisters)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProjectRiskRegister_TenantId_Tenants");
        });

        modelBuilder.Entity<ProjectTask>(entity =>
        {
            entity.ToTable("ProjectTasks", "erp_projects");

            entity.HasIndex(e => e.TenantId, "IX_ProjectTasks_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.EstimatedHours).HasPrecision(19, 4);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Wbsid).HasColumnName("WBSId");

            entity.HasOne(d => d.ParentTask).WithMany(p => p.InverseParentTask)
                .HasForeignKey(d => d.ParentTaskId)
                .HasConstraintName("FK_ProjectTasks_ParentTaskId_ProjectTasks");

            entity.HasOne(d => d.Project).WithMany(p => p.ProjectTasks)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProjectTasks_ProjectId_Projects");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ProjectTasks)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProjectTasks_TenantId_Tenants");

            entity.HasOne(d => d.Wbs).WithMany(p => p.ProjectTasks)
                .HasForeignKey(d => d.Wbsid)
                .HasConstraintName("FK_ProjectTasks_WBSId_ProjectWBS");
        });

        modelBuilder.Entity<ProjectWb>(entity =>
        {
            entity.ToTable("ProjectWBS", "erp_projects");

            entity.HasIndex(e => e.TenantId, "IX_ProjectWBS_TenantId");

            entity.Property(e => e.BudgetAmount).HasPrecision(19, 4);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Name).HasMaxLength(160);
            entity.Property(e => e.ParentWbsid).HasColumnName("ParentWBSId");
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Wbscode)
                .HasMaxLength(50)
                .HasColumnName("WBSCode");

            entity.HasOne(d => d.ParentWbs).WithMany(p => p.InverseParentWbs)
                .HasForeignKey(d => d.ParentWbsid)
                .HasConstraintName("FK_ProjectWBS_ParentWBSId_ProjectWBS");

            entity.HasOne(d => d.Project).WithMany(p => p.ProjectWbs)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProjectWBS_ProjectId_Projects");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ProjectWbs)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProjectWBS_TenantId_Tenants");
        });

        modelBuilder.Entity<PurchaseOrder>(entity =>
        {
            entity.ToTable("PurchaseOrders", "erp_procurement");

            entity.HasIndex(e => e.TenantId, "IX_PurchaseOrders_TenantId");

            entity.HasIndex(e => new { e.TenantId, e.Ponumber }, "UX_PurchaseOrders_PONumber").IsUnique();

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.Ponumber)
                .HasMaxLength(60)
                .HasColumnName("PONumber");
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.Subtotal).HasPrecision(19, 4);
            entity.Property(e => e.TaxAmount).HasPrecision(19, 4);
            entity.Property(e => e.Total).HasPrecision(19, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Branch).WithMany(p => p.PurchaseOrders)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK_PurchaseOrders_BranchId_Branches");

            entity.HasOne(d => d.Supplier).WithMany(p => p.PurchaseOrders)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrders_SupplierId_Suppliers");

            entity.HasOne(d => d.Tenant).WithMany(p => p.PurchaseOrders)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrders_TenantId_Tenants");
        });

        modelBuilder.Entity<PurchaseOrderLine>(entity =>
        {
            entity.ToTable("PurchaseOrderLines", "erp_procurement");

            entity.HasIndex(e => e.TenantId, "IX_PurchaseOrderLines_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.LineTotal).HasPrecision(19, 4);
            entity.Property(e => e.Quantity).HasPrecision(19, 4);
            entity.Property(e => e.UnitPrice).HasPrecision(19, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Item).WithMany(p => p.PurchaseOrderLines)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrderLines_ItemId_Items");

            entity.HasOne(d => d.PurchaseOrder).WithMany(p => p.PurchaseOrderLines)
                .HasForeignKey(d => d.PurchaseOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrderLines_PurchaseOrderId_PurchaseOrders");

            entity.HasOne(d => d.RequisitionLine).WithMany(p => p.PurchaseOrderLines)
                .HasForeignKey(d => d.RequisitionLineId)
                .HasConstraintName("FK_PurchaseOrderLines_RequisitionLineId_PurchaseRequi_0f6ace7a4");

            entity.HasOne(d => d.TaxCode).WithMany(p => p.PurchaseOrderLines)
                .HasForeignKey(d => d.TaxCodeId)
                .HasConstraintName("FK_PurchaseOrderLines_TaxCodeId_TaxCodes");

            entity.HasOne(d => d.Tenant).WithMany(p => p.PurchaseOrderLines)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrderLines_TenantId_Tenants");
        });

        modelBuilder.Entity<PurchaseRequisition>(entity =>
        {
            entity.ToTable("PurchaseRequisitions", "erp_procurement");

            entity.HasIndex(e => e.TenantId, "IX_PurchaseRequisitions_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.RequisitionNo).HasMaxLength(60);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.RequestedByEmployee).WithMany(p => p.PurchaseRequisitions)
                .HasForeignKey(d => d.RequestedByEmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseRequisitions_RequestedByEmployeeId_Employees");

            entity.HasOne(d => d.Tenant).WithMany(p => p.PurchaseRequisitions)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseRequisitions_TenantId_Tenants");
        });

        modelBuilder.Entity<PurchaseRequisitionLine>(entity =>
        {
            entity.ToTable("PurchaseRequisitionLines", "erp_procurement");

            entity.HasIndex(e => e.TenantId, "IX_PurchaseRequisitionLines_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.EstimatedUnitCost).HasPrecision(19, 4);
            entity.Property(e => e.Quantity).HasPrecision(19, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Item).WithMany(p => p.PurchaseRequisitionLines)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseRequisitionLines_ItemId_Items");

            entity.HasOne(d => d.Requisition).WithMany(p => p.PurchaseRequisitionLines)
                .HasForeignKey(d => d.RequisitionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseRequisitionLines_RequisitionId_PurchaseRequisitions");

            entity.HasOne(d => d.Tenant).WithMany(p => p.PurchaseRequisitionLines)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseRequisitionLines_TenantId_Tenants");
        });

        modelBuilder.Entity<PurchaseReturn>(entity =>
        {
            entity.ToTable("PurchaseReturns", "erp_procurement");

            entity.HasIndex(e => e.TenantId, "IX_PurchaseReturns_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Reason).HasMaxLength(500);
            entity.Property(e => e.ReturnNo).HasMaxLength(60);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.GoodsReceipt).WithMany(p => p.PurchaseReturns)
                .HasForeignKey(d => d.GoodsReceiptId)
                .HasConstraintName("FK_PurchaseReturns_GoodsReceiptId_GoodsReceipts");

            entity.HasOne(d => d.Supplier).WithMany(p => p.PurchaseReturns)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseReturns_SupplierId_Suppliers");

            entity.HasOne(d => d.Tenant).WithMany(p => p.PurchaseReturns)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseReturns_TenantId_Tenants");
        });

        modelBuilder.Entity<PurchaseReturnLine>(entity =>
        {
            entity.ToTable("PurchaseReturnLines", "erp_procurement");

            entity.HasIndex(e => e.TenantId, "IX_PurchaseReturnLines_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Quantity).HasPrecision(19, 4);
            entity.Property(e => e.UnitCost).HasPrecision(19, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.GoodsReceiptLine).WithMany(p => p.PurchaseReturnLines)
                .HasForeignKey(d => d.GoodsReceiptLineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseReturnLines_GoodsReceiptLineId_GoodsReceiptLines");

            entity.HasOne(d => d.Return).WithMany(p => p.PurchaseReturnLines)
                .HasForeignKey(d => d.ReturnId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseReturnLines_ReturnId_PurchaseReturns");

            entity.HasOne(d => d.Tenant).WithMany(p => p.PurchaseReturnLines)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseReturnLines_TenantId_Tenants");
        });

        modelBuilder.Entity<QualityInspection>(entity =>
        {
            entity.ToTable("QualityInspections", "erp_manufacturing");

            entity.HasIndex(e => e.TenantId, "IX_QualityInspections_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.InspectedAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Result).HasMaxLength(24);
            entity.Property(e => e.SourceType).HasMaxLength(50);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.InspectorEmployee).WithMany(p => p.QualityInspections)
                .HasForeignKey(d => d.InspectorEmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QualityInspections_InspectorEmployeeId_Employees");

            entity.HasOne(d => d.Plan).WithMany(p => p.QualityInspections)
                .HasForeignKey(d => d.PlanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QualityInspections_PlanId_QualityInspectionPlans");

            entity.HasOne(d => d.Tenant).WithMany(p => p.QualityInspections)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QualityInspections_TenantId_Tenants");
        });

        modelBuilder.Entity<QualityInspectionPlan>(entity =>
        {
            entity.ToTable("QualityInspectionPlans", "erp_manufacturing");

            entity.HasIndex(e => e.TenantId, "IX_QualityInspectionPlans_TenantId");

            entity.Property(e => e.Code).HasMaxLength(40);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.InspectionStage).HasMaxLength(40);
            entity.Property(e => e.Name).HasMaxLength(140);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Item).WithMany(p => p.QualityInspectionPlans)
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("FK_QualityInspectionPlans_ItemId_Items");

            entity.HasOne(d => d.Tenant).WithMany(p => p.QualityInspectionPlans)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QualityInspectionPlans_TenantId_Tenants");
        });

        modelBuilder.Entity<QualityInspectionResult>(entity =>
        {
            entity.ToTable("QualityInspectionResults", "erp_manufacturing");

            entity.HasIndex(e => e.TenantId, "IX_QualityInspectionResults_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.MeasuredValue).HasPrecision(19, 4);
            entity.Property(e => e.Notes).HasMaxLength(500);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Inspection).WithMany(p => p.QualityInspectionResults)
                .HasForeignKey(d => d.InspectionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QualityInspectionResults_InspectionId_QualityInspections");

            entity.HasOne(d => d.Tenant).WithMany(p => p.QualityInspectionResults)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QualityInspectionResults_TenantId_Tenants");

            entity.HasOne(d => d.Test).WithMany(p => p.QualityInspectionResults)
                .HasForeignKey(d => d.TestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QualityInspectionResults_TestId_QualityInspectionTests");
        });

        modelBuilder.Entity<QualityInspectionTest>(entity =>
        {
            entity.ToTable("QualityInspectionTests", "erp_manufacturing");

            entity.HasIndex(e => e.TenantId, "IX_QualityInspectionTests_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.LowerLimit).HasPrecision(19, 4);
            entity.Property(e => e.ParameterName).HasMaxLength(120);
            entity.Property(e => e.TestCode).HasMaxLength(50);
            entity.Property(e => e.Unit).HasMaxLength(30);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.UpperLimit).HasPrecision(19, 4);

            entity.HasOne(d => d.Plan).WithMany(p => p.QualityInspectionTests)
                .HasForeignKey(d => d.PlanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QualityInspectionTests_PlanId_QualityInspectionPlans");

            entity.HasOne(d => d.Tenant).WithMany(p => p.QualityInspectionTests)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QualityInspectionTests_TenantId_Tenants");
        });

        modelBuilder.Entity<RecruitmentRequisition>(entity =>
        {
            entity.ToTable("RecruitmentRequisitions", "erp_hr");

            entity.HasIndex(e => e.TenantId, "IX_RecruitmentRequisitions_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Position).WithMany(p => p.RecruitmentRequisitions)
                .HasForeignKey(d => d.PositionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecruitmentRequisitions_PositionId_JobPositions");

            entity.HasOne(d => d.RequestedByEmployee).WithMany(p => p.RecruitmentRequisitions)
                .HasForeignKey(d => d.RequestedByEmployeeId)
                .HasConstraintName("FK_RecruitmentRequisitions_RequestedByEmployeeId_Employees");

            entity.HasOne(d => d.Tenant).WithMany(p => p.RecruitmentRequisitions)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecruitmentRequisitions_TenantId_Tenants");
        });

        modelBuilder.Entity<ReorderPolicy>(entity =>
        {
            entity.ToTable("ReorderPolicies", "erp_inventory");

            entity.HasIndex(e => e.TenantId, "IX_ReorderPolicies_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.MaxQty).HasPrecision(19, 4);
            entity.Property(e => e.MinQty).HasPrecision(19, 4);
            entity.Property(e => e.ReorderPoint).HasPrecision(19, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Item).WithMany(p => p.ReorderPolicies)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReorderPolicies_ItemId_Items");

            entity.HasOne(d => d.PreferredSupplier).WithMany(p => p.ReorderPolicies)
                .HasForeignKey(d => d.PreferredSupplierId)
                .HasConstraintName("FK_ReorderPolicies_PreferredSupplierId_Suppliers");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ReorderPolicies)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReorderPolicies_TenantId_Tenants");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.ReorderPolicies)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReorderPolicies_WarehouseId_Warehouses");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.ToTable("Roles", "erp_core");

            entity.HasIndex(e => e.TenantId, "IX_Roles_TenantId");

            entity.HasIndex(e => new { e.TenantId, e.Code }, "UX_Roles_Code").IsUnique();

            entity.Property(e => e.Code).HasMaxLength(60);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Roles)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Roles_TenantId_Tenants");
        });

        modelBuilder.Entity<RolePermission>(entity =>
        {
            entity.ToTable("RolePermissions", "erp_core");

            entity.HasIndex(e => e.TenantId, "IX_RolePermissions_TenantId");

            entity.HasIndex(e => new { e.TenantId, e.RoleId, e.PermissionId }, "UX_RolePermissions_RoleId_PermissionId").IsUnique();

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Permission).WithMany(p => p.RolePermissions)
                .HasForeignKey(d => d.PermissionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RolePermissions_PermissionId_Permissions");

            entity.HasOne(d => d.Role).WithMany(p => p.RolePermissions)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RolePermissions_RoleId_Roles");

            entity.HasOne(d => d.Tenant).WithMany(p => p.RolePermissions)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RolePermissions_TenantId_Tenants");
        });

        modelBuilder.Entity<Routing>(entity =>
        {
            entity.ToTable("Routings", "erp_manufacturing");

            entity.HasIndex(e => e.TenantId, "IX_Routings_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.RevisionCode).HasMaxLength(30);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Item).WithMany(p => p.Routings)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Routings_ItemId_Items");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Routings)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Routings_TenantId_Tenants");
        });

        modelBuilder.Entity<RoutingOperation>(entity =>
        {
            entity.ToTable("RoutingOperations", "erp_manufacturing");

            entity.HasIndex(e => e.TenantId, "IX_RoutingOperations_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.RunMinutesPerUnit).HasPrecision(19, 4);
            entity.Property(e => e.SetupMinutes).HasPrecision(19, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Routing).WithMany(p => p.RoutingOperations)
                .HasForeignKey(d => d.RoutingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoutingOperations_RoutingId_Routings");

            entity.HasOne(d => d.Tenant).WithMany(p => p.RoutingOperations)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoutingOperations_TenantId_Tenants");

            entity.HasOne(d => d.WorkCenter).WithMany(p => p.RoutingOperations)
                .HasForeignKey(d => d.WorkCenterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoutingOperations_WorkCenterId_WorkCenters");
        });

        modelBuilder.Entity<SalesCommission>(entity =>
        {
            entity.ToTable("SalesCommissions", "erp_sales");

            entity.HasIndex(e => e.TenantId, "IX_SalesCommissions_TenantId");

            entity.Property(e => e.CommissionAmount).HasPrecision(19, 4);
            entity.Property(e => e.CommissionRate).HasPrecision(9, 4);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Employee).WithMany(p => p.SalesCommissions)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesCommissions_EmployeeId_Employees");

            entity.HasOne(d => d.SalesOrder).WithMany(p => p.SalesCommissions)
                .HasForeignKey(d => d.SalesOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesCommissions_SalesOrderId_SalesOrders");

            entity.HasOne(d => d.Tenant).WithMany(p => p.SalesCommissions)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesCommissions_TenantId_Tenants");
        });

        modelBuilder.Entity<SalesOrder>(entity =>
        {
            entity.ToTable("SalesOrders", "erp_sales");

            entity.HasIndex(e => e.TenantId, "IX_SalesOrders_TenantId");

            entity.HasIndex(e => new { e.TenantId, e.OrderNo }, "UX_SalesOrders_OrderNo").IsUnique();

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.DiscountAmount).HasPrecision(19, 4);
            entity.Property(e => e.OrderNo).HasMaxLength(60);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.Subtotal).HasPrecision(19, 4);
            entity.Property(e => e.TaxAmount).HasPrecision(19, 4);
            entity.Property(e => e.Total).HasPrecision(19, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Branch).WithMany(p => p.SalesOrders)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK_SalesOrders_BranchId_Branches");

            entity.HasOne(d => d.Customer).WithMany(p => p.SalesOrders)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesOrders_CustomerId_Customers");

            entity.HasOne(d => d.SalespersonEmployee).WithMany(p => p.SalesOrders)
                .HasForeignKey(d => d.SalespersonEmployeeId)
                .HasConstraintName("FK_SalesOrders_SalespersonEmployeeId_Employees");

            entity.HasOne(d => d.Tenant).WithMany(p => p.SalesOrders)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesOrders_TenantId_Tenants");
        });

        modelBuilder.Entity<SalesOrderLine>(entity =>
        {
            entity.ToTable("SalesOrderLines", "erp_sales");

            entity.HasIndex(e => e.TenantId, "IX_SalesOrderLines_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.DeliveredQty).HasPrecision(19, 4);
            entity.Property(e => e.DiscountAmount).HasPrecision(19, 4);
            entity.Property(e => e.LineTotal).HasPrecision(19, 4);
            entity.Property(e => e.OrderedQty).HasPrecision(19, 4);
            entity.Property(e => e.UnitPrice).HasPrecision(19, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Item).WithMany(p => p.SalesOrderLines)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesOrderLines_ItemId_Items");

            entity.HasOne(d => d.SalesOrder).WithMany(p => p.SalesOrderLines)
                .HasForeignKey(d => d.SalesOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesOrderLines_SalesOrderId_SalesOrders");

            entity.HasOne(d => d.TaxCode).WithMany(p => p.SalesOrderLines)
                .HasForeignKey(d => d.TaxCodeId)
                .HasConstraintName("FK_SalesOrderLines_TaxCodeId_TaxCodes");

            entity.HasOne(d => d.Tenant).WithMany(p => p.SalesOrderLines)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesOrderLines_TenantId_Tenants");
        });

        modelBuilder.Entity<SalesQuote>(entity =>
        {
            entity.ToTable("SalesQuotes", "erp_sales");

            entity.HasIndex(e => e.TenantId, "IX_SalesQuotes_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.QuoteNo).HasMaxLength(60);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Customer).WithMany(p => p.SalesQuotes)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesQuotes_CustomerId_Customers");

            entity.HasOne(d => d.Tenant).WithMany(p => p.SalesQuotes)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesQuotes_TenantId_Tenants");
        });

        modelBuilder.Entity<SalesQuoteLine>(entity =>
        {
            entity.ToTable("SalesQuoteLines", "erp_sales");

            entity.HasIndex(e => e.TenantId, "IX_SalesQuoteLines_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.DiscountAmount).HasPrecision(19, 4);
            entity.Property(e => e.Quantity).HasPrecision(19, 4);
            entity.Property(e => e.UnitPrice).HasPrecision(19, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Item).WithMany(p => p.SalesQuoteLines)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesQuoteLines_ItemId_Items");

            entity.HasOne(d => d.Quote).WithMany(p => p.SalesQuoteLines)
                .HasForeignKey(d => d.QuoteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesQuoteLines_QuoteId_SalesQuotes");

            entity.HasOne(d => d.TaxCode).WithMany(p => p.SalesQuoteLines)
                .HasForeignKey(d => d.TaxCodeId)
                .HasConstraintName("FK_SalesQuoteLines_TaxCodeId_TaxCodes");

            entity.HasOne(d => d.Tenant).WithMany(p => p.SalesQuoteLines)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesQuoteLines_TenantId_Tenants");
        });

        modelBuilder.Entity<SalesReturn>(entity =>
        {
            entity.ToTable("SalesReturns", "erp_sales");

            entity.HasIndex(e => e.TenantId, "IX_SalesReturns_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Reason).HasMaxLength(500);
            entity.Property(e => e.ReturnNo).HasMaxLength(60);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Customer).WithMany(p => p.SalesReturns)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesReturns_CustomerId_Customers");

            entity.HasOne(d => d.SalesOrder).WithMany(p => p.SalesReturns)
                .HasForeignKey(d => d.SalesOrderId)
                .HasConstraintName("FK_SalesReturns_SalesOrderId_SalesOrders");

            entity.HasOne(d => d.Tenant).WithMany(p => p.SalesReturns)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesReturns_TenantId_Tenants");
        });

        modelBuilder.Entity<SalesReturnLine>(entity =>
        {
            entity.ToTable("SalesReturnLines", "erp_sales");

            entity.HasIndex(e => e.TenantId, "IX_SalesReturnLines_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Disposition).HasMaxLength(30);
            entity.Property(e => e.ReturnedQty).HasPrecision(19, 4);
            entity.Property(e => e.UnitPrice).HasPrecision(19, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Item).WithMany(p => p.SalesReturnLines)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesReturnLines_ItemId_Items");

            entity.HasOne(d => d.Return).WithMany(p => p.SalesReturnLines)
                .HasForeignKey(d => d.ReturnId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesReturnLines_ReturnId_SalesReturns");

            entity.HasOne(d => d.SalesOrderLine).WithMany(p => p.SalesReturnLines)
                .HasForeignKey(d => d.SalesOrderLineId)
                .HasConstraintName("FK_SalesReturnLines_SalesOrderLineId_SalesOrderLines");

            entity.HasOne(d => d.Tenant).WithMany(p => p.SalesReturnLines)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesReturnLines_TenantId_Tenants");
        });

        modelBuilder.Entity<SelfServiceRequest>(entity =>
        {
            entity.ToTable("SelfServiceRequests", "erp_portal");

            entity.HasIndex(e => e.TenantId, "IX_SelfServiceRequests_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.RequestType).HasMaxLength(50);
            entity.Property(e => e.ResolvedAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.SubmittedAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.PortalAccount).WithMany(p => p.SelfServiceRequests)
                .HasForeignKey(d => d.PortalAccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SelfServiceRequests_PortalAccountId_PortalAccounts");

            entity.HasOne(d => d.Tenant).WithMany(p => p.SelfServiceRequests)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SelfServiceRequests_TenantId_Tenants");
        });

        modelBuilder.Entity<ServiceContract>(entity =>
        {
            entity.ToTable("ServiceContracts", "erp_crm");

            entity.HasIndex(e => e.TenantId, "IX_ServiceContracts_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Slatier)
                .HasMaxLength(40)
                .HasColumnName("SLATier");
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Contract).WithMany(p => p.ServiceContracts)
                .HasForeignKey(d => d.ContractId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiceContracts_ContractId_Contracts");

            entity.HasOne(d => d.Customer).WithMany(p => p.ServiceContracts)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiceContracts_CustomerId_Customers");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ServiceContracts)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiceContracts_TenantId_Tenants");
        });

        modelBuilder.Entity<Shift>(entity =>
        {
            entity.ToTable("Shifts", "erp_hr");

            entity.HasIndex(e => e.TenantId, "IX_Shifts_TenantId");

            entity.Property(e => e.Code).HasMaxLength(40);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.EndTime).HasPrecision(0);
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.StartTime).HasPrecision(0);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Shifts)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Shifts_TenantId_Tenants");
        });

        modelBuilder.Entity<ShiftAssignment>(entity =>
        {
            entity.ToTable("ShiftAssignments", "erp_hr");

            entity.HasIndex(e => e.TenantId, "IX_ShiftAssignments_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Employee).WithMany(p => p.ShiftAssignments)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShiftAssignments_EmployeeId_Employees");

            entity.HasOne(d => d.Shift).WithMany(p => p.ShiftAssignments)
                .HasForeignKey(d => d.ShiftId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShiftAssignments_ShiftId_Shifts");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ShiftAssignments)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShiftAssignments_TenantId_Tenants");
        });

        modelBuilder.Entity<Shipment>(entity =>
        {
            entity.ToTable("Shipments", "erp_sales");

            entity.HasIndex(e => e.TenantId, "IX_Shipments_TenantId");

            entity.Property(e => e.Carrier).HasMaxLength(120);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.ShipmentNo).HasMaxLength(60);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.TrackingNo).HasMaxLength(120);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.SalesOrder).WithMany(p => p.Shipments)
                .HasForeignKey(d => d.SalesOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Shipments_SalesOrderId_SalesOrders");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Shipments)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Shipments_TenantId_Tenants");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.Shipments)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Shipments_WarehouseId_Warehouses");
        });

        modelBuilder.Entity<ShipmentLine>(entity =>
        {
            entity.ToTable("ShipmentLines", "erp_sales");

            entity.HasIndex(e => e.TenantId, "IX_ShipmentLines_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.ShippedQty).HasPrecision(19, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Item).WithMany(p => p.ShipmentLines)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShipmentLines_ItemId_Items");

            entity.HasOne(d => d.Lot).WithMany(p => p.ShipmentLines)
                .HasForeignKey(d => d.LotId)
                .HasConstraintName("FK_ShipmentLines_LotId_InventoryLots");

            entity.HasOne(d => d.SalesOrderLine).WithMany(p => p.ShipmentLines)
                .HasForeignKey(d => d.SalesOrderLineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShipmentLines_SalesOrderLineId_SalesOrderLines");

            entity.HasOne(d => d.Shipment).WithMany(p => p.ShipmentLines)
                .HasForeignKey(d => d.ShipmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShipmentLines_ShipmentId_Shipments");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ShipmentLines)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShipmentLines_TenantId_Tenants");
        });

        modelBuilder.Entity<Slaevent>(entity =>
        {
            entity.ToTable("SLAEvents", "erp_crm");

            entity.HasIndex(e => e.TenantId, "IX_SLAEvents_TenantId");

            entity.Property(e => e.ActualAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Metric).HasMaxLength(40);
            entity.Property(e => e.TargetAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Slaevents)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SLAEvents_TenantId_Tenants");

            entity.HasOne(d => d.Ticket).WithMany(p => p.Slaevents)
                .HasForeignKey(d => d.TicketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SLAEvents_TicketId_SupportTickets");
        });

        modelBuilder.Entity<StockCount>(entity =>
        {
            entity.ToTable("StockCounts", "erp_inventory");

            entity.HasIndex(e => e.TenantId, "IX_StockCounts_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.ApprovedByTenantUser).WithMany(p => p.StockCounts)
                .HasForeignKey(d => d.ApprovedByTenantUserId)
                .HasConstraintName("FK_StockCounts_ApprovedByTenantUserId_TenantUsers");

            entity.HasOne(d => d.Tenant).WithMany(p => p.StockCounts)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockCounts_TenantId_Tenants");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.StockCounts)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockCounts_WarehouseId_Warehouses");
        });

        modelBuilder.Entity<StockCountLine>(entity =>
        {
            entity.ToTable("StockCountLines", "erp_inventory");

            entity.HasIndex(e => e.TenantId, "IX_StockCountLines_TenantId");

            entity.Property(e => e.CountedQty).HasPrecision(19, 4);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.ExpectedQty).HasPrecision(19, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.AdjustmentTransaction).WithMany(p => p.StockCountLines)
                .HasForeignKey(d => d.AdjustmentTransactionId)
                .HasConstraintName("FK_StockCountLines_AdjustmentTransactionId_InventoryT_64d5e2a91");

            entity.HasOne(d => d.Count).WithMany(p => p.StockCountLines)
                .HasForeignKey(d => d.CountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockCountLines_CountId_StockCounts");

            entity.HasOne(d => d.Item).WithMany(p => p.StockCountLines)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockCountLines_ItemId_Items");

            entity.HasOne(d => d.Location).WithMany(p => p.StockCountLines)
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("FK_StockCountLines_LocationId_WarehouseLocations");

            entity.HasOne(d => d.Tenant).WithMany(p => p.StockCountLines)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockCountLines_TenantId_Tenants");
        });

        modelBuilder.Entity<StockTransfer>(entity =>
        {
            entity.ToTable("StockTransfers", "erp_inventory");

            entity.HasIndex(e => e.TenantId, "IX_StockTransfers_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.TransferNo).HasMaxLength(60);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.FromWarehouse).WithMany(p => p.StockTransferFromWarehouses)
                .HasForeignKey(d => d.FromWarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockTransfers_FromWarehouseId_Warehouses");

            entity.HasOne(d => d.Tenant).WithMany(p => p.StockTransfers)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockTransfers_TenantId_Tenants");

            entity.HasOne(d => d.ToWarehouse).WithMany(p => p.StockTransferToWarehouses)
                .HasForeignKey(d => d.ToWarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockTransfers_ToWarehouseId_Warehouses");
        });

        modelBuilder.Entity<StockTransferLine>(entity =>
        {
            entity.ToTable("StockTransferLines", "erp_inventory");

            entity.HasIndex(e => e.TenantId, "IX_StockTransferLines_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Quantity).HasPrecision(19, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Item).WithMany(p => p.StockTransferLines)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockTransferLines_ItemId_Items");

            entity.HasOne(d => d.Lot).WithMany(p => p.StockTransferLines)
                .HasForeignKey(d => d.LotId)
                .HasConstraintName("FK_StockTransferLines_LotId_InventoryLots");

            entity.HasOne(d => d.Tenant).WithMany(p => p.StockTransferLines)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockTransferLines_TenantId_Tenants");

            entity.HasOne(d => d.Transfer).WithMany(p => p.StockTransferLines)
                .HasForeignKey(d => d.TransferId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockTransferLines_TransferId_StockTransfers");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.ToTable("Students", "erp_education");

            entity.HasIndex(e => e.TenantId, "IX_Students_TenantId");

            entity.HasIndex(e => new { e.TenantId, e.StudentNo }, "UX_Students_StudentNo").IsUnique();

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Email).HasMaxLength(254);
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.StudentNo).HasMaxLength(60);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Campus).WithMany(p => p.Students)
                .HasForeignKey(d => d.CampusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Students_CampusId_Campuses");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Students)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Students_TenantId_Tenants");
        });

        modelBuilder.Entity<StudentAttendance>(entity =>
        {
            entity.ToTable("StudentAttendance", "erp_education");

            entity.HasIndex(e => e.TenantId, "IX_StudentAttendance_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Remarks).HasMaxLength(300);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Session).WithMany(p => p.StudentAttendances)
                .HasForeignKey(d => d.SessionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StudentAttendance_SessionId_ClassSessions");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentAttendances)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StudentAttendance_StudentId_Students");

            entity.HasOne(d => d.Tenant).WithMany(p => p.StudentAttendances)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StudentAttendance_TenantId_Tenants");
        });

        modelBuilder.Entity<StudentFeeInvoice>(entity =>
        {
            entity.ToTable("StudentFeeInvoices", "erp_education");

            entity.HasIndex(e => e.TenantId, "IX_StudentFeeInvoices_TenantId");

            entity.Property(e => e.ArinvoiceId).HasColumnName("ARInvoiceId");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.InvoiceNo).HasMaxLength(60);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.Total).HasPrecision(19, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Arinvoice).WithMany(p => p.StudentFeeInvoices)
                .HasForeignKey(d => d.ArinvoiceId)
                .HasConstraintName("FK_StudentFeeInvoices_ARInvoiceId_ARInvoices");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentFeeInvoices)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StudentFeeInvoices_StudentId_Students");

            entity.HasOne(d => d.Tenant).WithMany(p => p.StudentFeeInvoices)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StudentFeeInvoices_TenantId_Tenants");

            entity.HasOne(d => d.Term).WithMany(p => p.StudentFeeInvoices)
                .HasForeignKey(d => d.TermId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StudentFeeInvoices_TermId_AcademicTerms");
        });

        modelBuilder.Entity<StudentFeePayment>(entity =>
        {
            entity.ToTable("StudentFeePayments", "erp_education");

            entity.HasIndex(e => e.TenantId, "IX_StudentFeePayments_TenantId");

            entity.Property(e => e.Amount).HasPrecision(19, 4);
            entity.Property(e => e.ArreceiptId).HasColumnName("ARReceiptId");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Method).HasMaxLength(30);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Arreceipt).WithMany(p => p.StudentFeePayments)
                .HasForeignKey(d => d.ArreceiptId)
                .HasConstraintName("FK_StudentFeePayments_ARReceiptId_ARReceipts");

            entity.HasOne(d => d.StudentFeeInvoice).WithMany(p => p.StudentFeePayments)
                .HasForeignKey(d => d.StudentFeeInvoiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StudentFeePayments_StudentFeeInvoiceId_StudentFeeInvoices");

            entity.HasOne(d => d.Tenant).WithMany(p => p.StudentFeePayments)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StudentFeePayments_TenantId_Tenants");
        });

        modelBuilder.Entity<StudentGuardian>(entity =>
        {
            entity.ToTable("StudentGuardians", "erp_education");

            entity.HasIndex(e => e.TenantId, "IX_StudentGuardians_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Email).HasMaxLength(254);
            entity.Property(e => e.FullName).HasMaxLength(160);
            entity.Property(e => e.Phone).HasMaxLength(40);
            entity.Property(e => e.Relationship).HasMaxLength(50);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentGuardians)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StudentGuardians_StudentId_Students");

            entity.HasOne(d => d.Tenant).WithMany(p => p.StudentGuardians)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StudentGuardians_TenantId_Tenants");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.ToTable("Suppliers", "erp_procurement");

            entity.HasIndex(e => e.TenantId, "IX_Suppliers_TenantId");

            entity.HasIndex(e => new { e.TenantId, e.SupplierNo }, "UX_Suppliers_SupplierNo").IsUnique();

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.Email).HasMaxLength(254);
            entity.Property(e => e.LegalName).HasMaxLength(200);
            entity.Property(e => e.Phone).HasMaxLength(40);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.SupplierNo).HasMaxLength(50);
            entity.Property(e => e.TaxId).HasMaxLength(80);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Suppliers)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Suppliers_TenantId_Tenants");
        });

        modelBuilder.Entity<SupplierClaim>(entity =>
        {
            entity.ToTable("SupplierClaims", "erp_srm");

            entity.HasIndex(e => e.TenantId, "IX_SupplierClaims_TenantId");

            entity.Property(e => e.ClaimAmount).HasPrecision(19, 4);
            entity.Property(e => e.ClaimNo).HasMaxLength(60);
            entity.Property(e => e.ClaimType).HasMaxLength(40);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.GoodsReceipt).WithMany(p => p.SupplierClaims)
                .HasForeignKey(d => d.GoodsReceiptId)
                .HasConstraintName("FK_SupplierClaims_GoodsReceiptId_GoodsReceipts");

            entity.HasOne(d => d.PurchaseOrder).WithMany(p => p.SupplierClaims)
                .HasForeignKey(d => d.PurchaseOrderId)
                .HasConstraintName("FK_SupplierClaims_PurchaseOrderId_PurchaseOrders");

            entity.HasOne(d => d.Supplier).WithMany(p => p.SupplierClaims)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierClaims_SupplierId_Suppliers");

            entity.HasOne(d => d.Tenant).WithMany(p => p.SupplierClaims)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierClaims_TenantId_Tenants");
        });

        modelBuilder.Entity<SupplierContact>(entity =>
        {
            entity.ToTable("SupplierContacts", "erp_procurement");

            entity.HasIndex(e => e.TenantId, "IX_SupplierContacts_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Email).HasMaxLength(254);
            entity.Property(e => e.Name).HasMaxLength(140);
            entity.Property(e => e.Phone).HasMaxLength(40);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Supplier).WithMany(p => p.SupplierContacts)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierContacts_SupplierId_Suppliers");

            entity.HasOne(d => d.Tenant).WithMany(p => p.SupplierContacts)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierContacts_TenantId_Tenants");
        });

        modelBuilder.Entity<SupplierEvaluation>(entity =>
        {
            entity.ToTable("SupplierEvaluations", "erp_srm");

            entity.HasIndex(e => e.TenantId, "IX_SupplierEvaluations_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Notes).HasMaxLength(1000);
            entity.Property(e => e.Score).HasPrecision(9, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.EvaluatorEmployee).WithMany(p => p.SupplierEvaluations)
                .HasForeignKey(d => d.EvaluatorEmployeeId)
                .HasConstraintName("FK_SupplierEvaluations_EvaluatorEmployeeId_Employees");

            entity.HasOne(d => d.Supplier).WithMany(p => p.SupplierEvaluations)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierEvaluations_SupplierId_Suppliers");

            entity.HasOne(d => d.Tenant).WithMany(p => p.SupplierEvaluations)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierEvaluations_TenantId_Tenants");
        });

        modelBuilder.Entity<SupplierOnboarding>(entity =>
        {
            entity.ToTable("SupplierOnboarding", "erp_srm");

            entity.HasIndex(e => e.TenantId, "IX_SupplierOnboarding_TenantId");

            entity.Property(e => e.ApprovedAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Supplier).WithMany(p => p.SupplierOnboardings)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierOnboarding_SupplierId_Suppliers");

            entity.HasOne(d => d.Tenant).WithMany(p => p.SupplierOnboardings)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierOnboarding_TenantId_Tenants");
        });

        modelBuilder.Entity<SupplierPerformanceMetric>(entity =>
        {
            entity.ToTable("SupplierPerformanceMetrics", "erp_srm");

            entity.HasIndex(e => e.TenantId, "IX_SupplierPerformanceMetrics_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.MetricCode).HasMaxLength(60);
            entity.Property(e => e.MetricValue).HasPrecision(19, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Supplier).WithMany(p => p.SupplierPerformanceMetrics)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierPerformanceMetrics_SupplierId_Suppliers");

            entity.HasOne(d => d.Tenant).WithMany(p => p.SupplierPerformanceMetrics)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierPerformanceMetrics_TenantId_Tenants");
        });

        modelBuilder.Entity<SupplierQuote>(entity =>
        {
            entity.ToTable("SupplierQuotes", "erp_procurement");

            entity.HasIndex(e => e.TenantId, "IX_SupplierQuotes_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.QuoteNo).HasMaxLength(60);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Supplier).WithMany(p => p.SupplierQuotes)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierQuotes_SupplierId_Suppliers");

            entity.HasOne(d => d.Tenant).WithMany(p => p.SupplierQuotes)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierQuotes_TenantId_Tenants");
        });

        modelBuilder.Entity<SupplierQuoteLine>(entity =>
        {
            entity.ToTable("SupplierQuoteLines", "erp_procurement");

            entity.HasIndex(e => e.TenantId, "IX_SupplierQuoteLines_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Quantity).HasPrecision(19, 4);
            entity.Property(e => e.UnitPrice).HasPrecision(19, 4);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Item).WithMany(p => p.SupplierQuoteLines)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierQuoteLines_ItemId_Items");

            entity.HasOne(d => d.Quote).WithMany(p => p.SupplierQuoteLines)
                .HasForeignKey(d => d.QuoteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierQuoteLines_QuoteId_SupplierQuotes");

            entity.HasOne(d => d.Tenant).WithMany(p => p.SupplierQuoteLines)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupplierQuoteLines_TenantId_Tenants");
        });

        modelBuilder.Entity<SupportTicket>(entity =>
        {
            entity.ToTable("SupportTickets", "erp_crm");

            entity.HasIndex(e => e.TenantId, "IX_SupportTickets_TenantId");

            entity.Property(e => e.ClosedAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Description).HasMaxLength(2000);
            entity.Property(e => e.OpenedAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Priority).HasMaxLength(20);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.Subject).HasMaxLength(200);
            entity.Property(e => e.TicketNo).HasMaxLength(60);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.AssignedEmployee).WithMany(p => p.SupportTickets)
                .HasForeignKey(d => d.AssignedEmployeeId)
                .HasConstraintName("FK_SupportTickets_AssignedEmployeeId_Employees");

            entity.HasOne(d => d.Contact).WithMany(p => p.SupportTickets)
                .HasForeignKey(d => d.ContactId)
                .HasConstraintName("FK_SupportTickets_ContactId_CustomerContacts");

            entity.HasOne(d => d.Customer).WithMany(p => p.SupportTickets)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_SupportTickets_CustomerId_Customers");

            entity.HasOne(d => d.Tenant).WithMany(p => p.SupportTickets)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SupportTickets_TenantId_Tenants");
        });

        modelBuilder.Entity<TaxCode>(entity =>
        {
            entity.ToTable("TaxCodes", "erp_finance");

            entity.HasIndex(e => e.TenantId, "IX_TaxCodes_TenantId");

            entity.Property(e => e.Code).HasMaxLength(30);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.InputGlaccountId).HasColumnName("InputGLAccountId");
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.OutputGlaccountId).HasColumnName("OutputGLAccountId");
            entity.Property(e => e.Rate).HasPrecision(9, 4);
            entity.Property(e => e.TaxType).HasMaxLength(30);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.InputGlaccount).WithMany(p => p.TaxCodeInputGlaccounts)
                .HasForeignKey(d => d.InputGlaccountId)
                .HasConstraintName("FK_TaxCodes_InputGLAccountId_GLAccounts");

            entity.HasOne(d => d.OutputGlaccount).WithMany(p => p.TaxCodeOutputGlaccounts)
                .HasForeignKey(d => d.OutputGlaccountId)
                .HasConstraintName("FK_TaxCodes_OutputGLAccountId_GLAccounts");

            entity.HasOne(d => d.Tenant).WithMany(p => p.TaxCodes)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TaxCodes_TenantId_Tenants");
        });

        modelBuilder.Entity<Tenant>(entity =>
        {
            entity.ToTable("Tenants", "erp_core");

            entity.HasIndex(e => e.Code, "UX_Tenants_Code").IsUnique();

            entity.Property(e => e.BaseCurrencyCode)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.Code).HasMaxLength(40);
            entity.Property(e => e.CountryCode)
                .HasMaxLength(2)
                .IsFixedLength();
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.LegalName).HasMaxLength(220);
            entity.Property(e => e.Name).HasMaxLength(160);
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.TaxNumber).HasMaxLength(60);
            entity.Property(e => e.TimeZone).HasMaxLength(80);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");
        });

        modelBuilder.Entity<TenantUser>(entity =>
        {
            entity.ToTable("TenantUsers", "erp_core");

            entity.HasIndex(e => e.TenantId, "IX_TenantUsers_TenantId");

            entity.HasIndex(e => new { e.TenantId, e.UserId }, "UX_TenantUsers_UserId").IsUnique();

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.JoinedAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Employee).WithMany(p => p.TenantUsers)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_TenantUsers_EmployeeId_Employees");

            entity.HasOne(d => d.Tenant).WithMany(p => p.TenantUsers)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TenantUsers_TenantId_Tenants");

            entity.HasOne(d => d.User).WithMany(p => p.TenantUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TenantUsers_UserId_Users");
        });

        modelBuilder.Entity<TicketMessage>(entity =>
        {
            entity.ToTable("TicketMessages", "erp_crm");

            entity.HasIndex(e => e.TenantId, "IX_TicketMessages_TenantId");

            entity.Property(e => e.Body).HasMaxLength(2000);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.SentAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.SenderTenantUser).WithMany(p => p.TicketMessages)
                .HasForeignKey(d => d.SenderTenantUserId)
                .HasConstraintName("FK_TicketMessages_SenderTenantUserId_TenantUsers");

            entity.HasOne(d => d.Tenant).WithMany(p => p.TicketMessages)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TicketMessages_TenantId_Tenants");

            entity.HasOne(d => d.Ticket).WithMany(p => p.TicketMessages)
                .HasForeignKey(d => d.TicketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TicketMessages_TicketId_SupportTickets");
        });

        modelBuilder.Entity<Timesheet>(entity =>
        {
            entity.ToTable("Timesheets", "erp_projects");

            entity.HasIndex(e => e.TenantId, "IX_Timesheets_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.ApprovedByEmployee).WithMany(p => p.TimesheetApprovedByEmployees)
                .HasForeignKey(d => d.ApprovedByEmployeeId)
                .HasConstraintName("FK_Timesheets_ApprovedByEmployeeId_Employees");

            entity.HasOne(d => d.Employee).WithMany(p => p.TimesheetEmployees)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Timesheets_EmployeeId_Employees");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Timesheets)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Timesheets_TenantId_Tenants");
        });

        modelBuilder.Entity<TimesheetLine>(entity =>
        {
            entity.ToTable("TimesheetLines", "erp_projects");

            entity.HasIndex(e => e.TenantId, "IX_TimesheetLines_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Hours).HasPrecision(19, 4);
            entity.Property(e => e.Notes).HasMaxLength(500);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.ProjectTask).WithMany(p => p.TimesheetLines)
                .HasForeignKey(d => d.ProjectTaskId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimesheetLines_ProjectTaskId_ProjectTasks");

            entity.HasOne(d => d.Tenant).WithMany(p => p.TimesheetLines)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimesheetLines_TenantId_Tenants");

            entity.HasOne(d => d.Timesheet).WithMany(p => p.TimesheetLines)
                .HasForeignKey(d => d.TimesheetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TimesheetLines_TimesheetId_Timesheets");
        });

        modelBuilder.Entity<TrainingCourse>(entity =>
        {
            entity.ToTable("TrainingCourses", "erp_hr");

            entity.HasIndex(e => e.TenantId, "IX_TrainingCourses_TenantId");

            entity.Property(e => e.Code).HasMaxLength(40);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.DurationHours).HasPrecision(19, 4);
            entity.Property(e => e.Provider).HasMaxLength(120);
            entity.Property(e => e.Title).HasMaxLength(160);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Tenant).WithMany(p => p.TrainingCourses)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TrainingCourses_TenantId_Tenants");
        });

        modelBuilder.Entity<TrainingEnrollment>(entity =>
        {
            entity.ToTable("TrainingEnrollments", "erp_hr");

            entity.HasIndex(e => e.TenantId, "IX_TrainingEnrollments_TenantId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Result).HasMaxLength(40);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Course).WithMany(p => p.TrainingEnrollments)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TrainingEnrollments_CourseId_TrainingCourses");

            entity.HasOne(d => d.Employee).WithMany(p => p.TrainingEnrollments)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TrainingEnrollments_EmployeeId_Employees");

            entity.HasOne(d => d.Tenant).WithMany(p => p.TrainingEnrollments)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TrainingEnrollments_TenantId_Tenants");
        });

        modelBuilder.Entity<UnitsOfMeasure>(entity =>
        {
            entity.ToTable("UnitsOfMeasure", "erp_inventory");

            entity.HasIndex(e => e.TenantId, "IX_UnitsOfMeasure_TenantId");

            entity.Property(e => e.Code).HasMaxLength(20);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Dimension).HasMaxLength(30);
            entity.Property(e => e.Name).HasMaxLength(80);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Tenant).WithMany(p => p.UnitsOfMeasures)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UnitsOfMeasure_TenantId_Tenants");
        });

        modelBuilder.Entity<Uomconversion>(entity =>
        {
            entity.ToTable("UOMConversions", "erp_inventory");

            entity.HasIndex(e => e.TenantId, "IX_UOMConversions_TenantId");

            entity.HasIndex(e => new { e.TenantId, e.FromUomid, e.ToUomid }, "UX_UOMConversions_FromUOMId_ToUOMId").IsUnique();

            entity.Property(e => e.ConversionFactor).HasPrecision(20, 10);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.FromUomid).HasColumnName("FromUOMId");
            entity.Property(e => e.ToUomid).HasColumnName("ToUOMId");
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.FromUom).WithMany(p => p.UomconversionFromUoms)
                .HasForeignKey(d => d.FromUomid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UOMConversions_FromUOMId_UnitsOfMeasure");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Uomconversions)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UOMConversions_TenantId_Tenants");

            entity.HasOne(d => d.ToUom).WithMany(p => p.UomconversionToUoms)
                .HasForeignKey(d => d.ToUomid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UOMConversions_ToUOMId_UnitsOfMeasure");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("Users", "erp_core");

            entity.HasIndex(e => e.Email, "UX_Users_Email").IsUnique();

            entity.Property(e => e.DisplayName).HasMaxLength(160);
            entity.Property(e => e.Email).HasMaxLength(254);
            entity.Property(e => e.LastLoginAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.PasswordHash).HasMaxLength(500);
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.ToTable("UserRoles", "erp_core");

            entity.HasIndex(e => e.TenantId, "IX_UserRoles_TenantId");

            entity.HasIndex(e => new { e.TenantId, e.TenantUserId, e.RoleId }, "UX_UserRoles_TenantUserId_RoleId").IsUnique();

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Role).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserRoles_RoleId_Roles");

            entity.HasOne(d => d.Tenant).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserRoles_TenantId_Tenants");

            entity.HasOne(d => d.TenantUser).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.TenantUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserRoles_TenantUserId_TenantUsers");
        });

        modelBuilder.Entity<Warehouse>(entity =>
        {
            entity.ToTable("Warehouses", "erp_inventory");

            entity.HasIndex(e => e.TenantId, "IX_Warehouses_TenantId");

            entity.HasIndex(e => new { e.TenantId, e.Code }, "UX_Warehouses_Code").IsUnique();

            entity.Property(e => e.Code).HasMaxLength(30);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Name).HasMaxLength(120);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Branch).WithMany(p => p.Warehouses)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK_Warehouses_BranchId_Branches");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Warehouses)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Warehouses_TenantId_Tenants");
        });

        modelBuilder.Entity<WarehouseLocation>(entity =>
        {
            entity.ToTable("WarehouseLocations", "erp_inventory");

            entity.HasIndex(e => e.TenantId, "IX_WarehouseLocations_TenantId");

            entity.Property(e => e.Code).HasMaxLength(40);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.LocationType).HasMaxLength(30);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.ParentLocation).WithMany(p => p.InverseParentLocation)
                .HasForeignKey(d => d.ParentLocationId)
                .HasConstraintName("FK_WarehouseLocations_ParentLocationId_WarehouseLocations");

            entity.HasOne(d => d.Tenant).WithMany(p => p.WarehouseLocations)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WarehouseLocations_TenantId_Tenants");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.WarehouseLocations)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WarehouseLocations_WarehouseId_Warehouses");
        });

        modelBuilder.Entity<WorkCenter>(entity =>
        {
            entity.ToTable("WorkCenters", "erp_manufacturing");

            entity.HasIndex(e => e.TenantId, "IX_WorkCenters_TenantId");

            entity.Property(e => e.CapacityHoursPerDay).HasPrecision(19, 4);
            entity.Property(e => e.Code).HasMaxLength(40);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.HourlyCostRate).HasPrecision(19, 4);
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.Department).WithMany(p => p.WorkCenters)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_WorkCenters_DepartmentId_Departments");

            entity.HasOne(d => d.Tenant).WithMany(p => p.WorkCenters)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkCenters_TenantId_Tenants");
        });

        modelBuilder.Entity<WorkOrder>(entity =>
        {
            entity.ToTable("WorkOrders", "erp_manufacturing");

            entity.HasIndex(e => e.TenantId, "IX_WorkOrders_TenantId");

            entity.HasIndex(e => new { e.TenantId, e.WorkOrderNo }, "UX_WorkOrders_WorkOrderNo").IsUnique();

            entity.Property(e => e.Bomid).HasColumnName("BOMId");
            entity.Property(e => e.CompletedQty).HasPrecision(19, 4);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.PlannedEnd).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.PlannedQty).HasPrecision(19, 4);
            entity.Property(e => e.PlannedStart).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.WorkOrderNo).HasMaxLength(60);

            entity.HasOne(d => d.Bom).WithMany(p => p.WorkOrders)
                .HasForeignKey(d => d.Bomid)
                .HasConstraintName("FK_WorkOrders_BOMId_BOMHeaders");

            entity.HasOne(d => d.Item).WithMany(p => p.WorkOrders)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkOrders_ItemId_Items");

            entity.HasOne(d => d.Routing).WithMany(p => p.WorkOrders)
                .HasForeignKey(d => d.RoutingId)
                .HasConstraintName("FK_WorkOrders_RoutingId_Routings");

            entity.HasOne(d => d.Tenant).WithMany(p => p.WorkOrders)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkOrders_TenantId_Tenants");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.WorkOrders)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkOrders_WarehouseId_Warehouses");
        });

        modelBuilder.Entity<WorkOrderOperation>(entity =>
        {
            entity.ToTable("WorkOrderOperations", "erp_manufacturing");

            entity.HasIndex(e => e.TenantId, "IX_WorkOrderOperations_TenantId");

            entity.Property(e => e.ActualEnd).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.ActualStart).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(CURRENT_TIMESTAMP AT TIME ZONE 'UTC'::text)")
                .HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.PlannedStart).HasColumnType("timestamp(3) without time zone");
            entity.Property(e => e.Status).HasMaxLength(24);
            entity.Property(e => e.UpdatedAt).HasColumnType("timestamp(3) without time zone");

            entity.HasOne(d => d.RoutingOperation).WithMany(p => p.WorkOrderOperations)
                .HasForeignKey(d => d.RoutingOperationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkOrderOperations_RoutingOperationId_RoutingOperations");

            entity.HasOne(d => d.Tenant).WithMany(p => p.WorkOrderOperations)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkOrderOperations_TenantId_Tenants");

            entity.HasOne(d => d.WorkOrder).WithMany(p => p.WorkOrderOperations)
                .HasForeignKey(d => d.WorkOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkOrderOperations_WorkOrderId_WorkOrders");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
