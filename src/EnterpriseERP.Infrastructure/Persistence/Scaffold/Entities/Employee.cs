using System;
using System.Collections.Generic;

namespace EnterpriseERP.Infrastructure.Persistence.Scaffold.Entities;

public partial class Employee
{
    public long Id { get; set; }

    public long TenantId { get; set; }

    public string EmployeeNo { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string WorkEmail { get; set; } = null!;

    public long DepartmentId { get; set; }

    public long? PositionId { get; set; }

    public long? ManagerEmployeeId { get; set; }

    public DateOnly HireDate { get; set; }

    public string EmploymentStatus { get; set; } = null!;

    public DateOnly? TerminationDate { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<AttendanceRecord> AttendanceRecords { get; set; } = new List<AttendanceRecord>();

    public virtual ICollection<CallCenterCall> CallCenterCalls { get; set; } = new List<CallCenterCall>();

    public virtual ICollection<Capaaction> Capaactions { get; set; } = new List<Capaaction>();

    public virtual ICollection<ClassSection> ClassSections { get; set; } = new List<ClassSection>();

    public virtual ICollection<ContractObligation> ContractObligations { get; set; } = new List<ContractObligation>();

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    public virtual ICollection<DeliveryRoute> DeliveryRoutes { get; set; } = new List<DeliveryRoute>();

    public virtual Department Department { get; set; } = null!;

    public virtual ICollection<EmployeeBenefit> EmployeeBenefits { get; set; } = new List<EmployeeBenefit>();

    public virtual ICollection<EmployeeDemographic> EmployeeDemographics { get; set; } = new List<EmployeeDemographic>();

    public virtual ICollection<EmployeePension> EmployeePensions { get; set; } = new List<EmployeePension>();

    public virtual ICollection<EmployeeSeparation> EmployeeSeparations { get; set; } = new List<EmployeeSeparation>();

    public virtual ICollection<EmploymentContract> EmploymentContracts { get; set; } = new List<EmploymentContract>();

    public virtual ICollection<Interview> Interviews { get; set; } = new List<Interview>();

    public virtual ICollection<Employee> InverseManagerEmployee { get; set; } = new List<Employee>();

    public virtual ICollection<Lead> Leads { get; set; } = new List<Lead>();

    public virtual ICollection<LeaveBalance> LeaveBalances { get; set; } = new List<LeaveBalance>();

    public virtual ICollection<LeaveRequest> LeaveRequestApprovedByEmployees { get; set; } = new List<LeaveRequest>();

    public virtual ICollection<LeaveRequest> LeaveRequestEmployees { get; set; } = new List<LeaveRequest>();

    public virtual Employee? ManagerEmployee { get; set; }

    public virtual ICollection<Opportunity> Opportunities { get; set; } = new List<Opportunity>();

    public virtual ICollection<OpportunityActivity> OpportunityActivities { get; set; } = new List<OpportunityActivity>();

    public virtual ICollection<Payslip> Payslips { get; set; } = new List<Payslip>();

    public virtual ICollection<PerformanceReview> PerformanceReviewEmployees { get; set; } = new List<PerformanceReview>();

    public virtual ICollection<PerformanceReview> PerformanceReviewReviewerEmployees { get; set; } = new List<PerformanceReview>();

    public virtual ICollection<PortalAccount> PortalAccounts { get; set; } = new List<PortalAccount>();

    public virtual JobPosition? Position { get; set; }

    public virtual ICollection<ProjectExpense> ProjectExpenses { get; set; } = new List<ProjectExpense>();

    public virtual ICollection<ProjectResource> ProjectResources { get; set; } = new List<ProjectResource>();

    public virtual ICollection<ProjectRiskRegister> ProjectRiskRegisters { get; set; } = new List<ProjectRiskRegister>();

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();

    public virtual ICollection<PurchaseRequisition> PurchaseRequisitions { get; set; } = new List<PurchaseRequisition>();

    public virtual ICollection<QualityInspection> QualityInspections { get; set; } = new List<QualityInspection>();

    public virtual ICollection<RecruitmentRequisition> RecruitmentRequisitions { get; set; } = new List<RecruitmentRequisition>();

    public virtual ICollection<SalesCommission> SalesCommissions { get; set; } = new List<SalesCommission>();

    public virtual ICollection<SalesOrder> SalesOrders { get; set; } = new List<SalesOrder>();

    public virtual ICollection<ShiftAssignment> ShiftAssignments { get; set; } = new List<ShiftAssignment>();

    public virtual ICollection<SupplierEvaluation> SupplierEvaluations { get; set; } = new List<SupplierEvaluation>();

    public virtual ICollection<SupportTicket> SupportTickets { get; set; } = new List<SupportTicket>();

    public virtual Tenant Tenant { get; set; } = null!;

    public virtual ICollection<TenantUser> TenantUsers { get; set; } = new List<TenantUser>();

    public virtual ICollection<Timesheet> TimesheetApprovedByEmployees { get; set; } = new List<Timesheet>();

    public virtual ICollection<Timesheet> TimesheetEmployees { get; set; } = new List<Timesheet>();

    public virtual ICollection<TrainingEnrollment> TrainingEnrollments { get; set; } = new List<TrainingEnrollment>();
}
