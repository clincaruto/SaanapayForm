using SaanapayForm.Web.Models.Domain;
using SaanapayForm.Web.Models.ViewModel;

namespace SaanapayForm.Web.GenericRepository.IRepository
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
       Task LeaveAllocation(int leaveTypeId);
        Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period);
        Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId); 
        Task<LeaveAllocation?> GetEmployeeAllocation(string employeeId, int leaveTypeId);
		Task<LeaveAllocationEditVM> GetEmployeeAllocation(int Id);
        Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVM model);
	}
}
