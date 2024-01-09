using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SaanapayForm.Web.Constants;
using SaanapayForm.Web.Data;
using SaanapayForm.Web.GenericRepository.IRepository;
using SaanapayForm.Web.Models.Domain;
using SaanapayForm.Web.Models.ViewModel;

namespace SaanapayForm.Web.GenericRepository.Repository
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
		private readonly ApplicationDbContext context;
		private readonly UserManager<Employee> userManager;
		private readonly ILeaveTypeRepository leaveTypeRepository;
		private readonly IMapper mapper;

		public LeaveAllocationRepository(ApplicationDbContext context, UserManager<Employee> userManager, ILeaveTypeRepository leaveTypeRepository, IMapper mapper) : base(context)
        {
			this.context = context;
			this.userManager = userManager;
			this.leaveTypeRepository = leaveTypeRepository;
			this.mapper = mapper;
		}

		public async Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period)
		{
			return await context.LeaveAllocations.AnyAsync(q => q.EmployeeId == employeeId && q.LeaveTypeId== leaveTypeId && q.Period == period);
		}

		
		public async Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId)
		{
			var allocations = await context.LeaveAllocations
				.Include(q => q.LeaveType)
				.Where(q => q.EmployeeId== employeeId).ToListAsync();
			var employee = await userManager.FindByIdAsync(employeeId);

			var employeeAllocationModel = mapper.Map<EmployeeAllocationVM>(employee);
			employeeAllocationModel.LeaveAllocations = mapper.Map<List<LeaveAllocationVM>>(allocations);

			return employeeAllocationModel;

		}

		public async Task<LeaveAllocationEditVM> GetEmployeeAllocation(int Id)
		{

			var allocations = await context.LeaveAllocations
				.Include(q => q.LeaveType)
				.FirstOrDefaultAsync(q => q.Id == Id);

			if (allocations == null)
			{
				return null;
			}
			var employee = await userManager.FindByIdAsync(allocations.EmployeeId);

			// Convert domain into viewmodel
			var employeeAllocationModel = mapper.Map<LeaveAllocationEditVM>(allocations);

			//map the leaveallocation to employee
			employeeAllocationModel.Employee = mapper.Map<EmployeeListVM>(await userManager.FindByIdAsync(allocations.EmployeeId));

			return employeeAllocationModel;
		}


		//public async Task LeaveAllocation(int leaveTypeId)
		//{
		//    var employees = await userManager.GetUsersInRoleAsync(Roles.User);
		//    var period = DateTime.Now.Year;
		//    var leavetype = await leaveTypeRepository.GetAsync(leaveTypeId);

		//    foreach (var employee in employees)
		//    {
		//        var allocation = new LeaveAllocation
		//        {
		//            EmployeeId = employee.Id,
		//            LeaveTypeId = leaveTypeId,
		//            Period = period,
		//            NumberOfDays = leavetype.DefaultDays
		//        };
		//        await AddAsync(allocation);

		//    }


		//}

		public async Task LeaveAllocation(int leaveTypeId)
		{
			var employees = await userManager.GetUsersInRoleAsync(Roles.User);
			var period = DateTime.Now.Year;
			var leavetype = await leaveTypeRepository.GetAsync(leaveTypeId);
			var allocations = new List<LeaveAllocation>();

			foreach (var employee in employees)
			{
				if (await AllocationExists(employee.Id, leaveTypeId, period))
					continue;

				allocations.Add(new LeaveAllocation
				{
					EmployeeId = employee.Id,
					LeaveTypeId = leaveTypeId,
					Period = period,
					NumberOfDays = leavetype.DefaultDays
				});
				

			}
			await AddRangeAsync(allocations);


		}

		public async Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVM model)
		{
			var leaveAllocation = await GetAsync(model.Id);
			if (leaveAllocation == null)
			{
				return false;
			}
			leaveAllocation.Period = model.Period;
			leaveAllocation.NumberOfDays = model.NumberOfDays;
			await UpdateAsync(leaveAllocation);

			return true;
		}

        public async Task<LeaveAllocation?> GetEmployeeAllocation(string employeeId, int leaveTypeId)
        {
            return await context.LeaveAllocations.FirstOrDefaultAsync(q => q.EmployeeId == employeeId && q.LeaveTypeId == leaveTypeId);
        }
    }
}
