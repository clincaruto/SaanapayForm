using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SaanapayForm.Web.Constants;
using SaanapayForm.Web.GenericRepository.IRepository;
using SaanapayForm.Web.Models.Domain;
using SaanapayForm.Web.Models.ViewModel;

namespace SaanapayForm.Web.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly UserManager<Employee> userManager;
        private readonly IMapper mapper;
		private readonly ILeaveAllocationRepository leaveAllocationRepository;
		private readonly ILeaveTypeRepository leaveTypeRepository;

		public EmployeesController(UserManager<Employee> userManager, IMapper mapper, ILeaveAllocationRepository leaveAllocationRepository, ILeaveTypeRepository leaveTypeRepository)
        {
            this.userManager = userManager;
            this.mapper = mapper;
			this.leaveAllocationRepository = leaveAllocationRepository;
			this.leaveTypeRepository = leaveTypeRepository;
		}


        // GET: EmployeesController
        public async Task<IActionResult> Index()
        {
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);

            var employeesVM = mapper.Map<List<EmployeeListVM>>(employees);
            return View(employeesVM);
        }

		// GET: EmployeesController/ViewAllocations/5
		public async Task<IActionResult> ViewAllocations(string id)
        {
			var model = await leaveAllocationRepository.GetEmployeeAllocations(id);
			return View(model);
        }

      

		// GET: EmployeesController/EditAllocation/5
		public async Task<IActionResult> EditAllocation(int id)
        {
            // Get data from database
            var leaveAllocation = await leaveAllocationRepository.GetEmployeeAllocation(id);
            if (leaveAllocation == null)
            {
                return NotFound();
            }

         
            return View(leaveAllocation);
        }

        // POST: EmployeesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAllocation(int id, LeaveAllocationEditVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (await leaveAllocationRepository.UpdateEmployeeAllocation(model))
                    {
						return RedirectToAction(nameof(ViewAllocations), new { id = model.EmployeeId });
					}

					
				}
            }
            catch(Exception ex)
            {
                ModelState.AddModelError(string.Empty, "An Error Has Occured. Please Try Again Later");
            }
            model.Employee = mapper.Map<EmployeeListVM>(await userManager.FindByIdAsync(model.EmployeeId));
            model.LeaveType = mapper.Map<LeaveTypeVM>(await leaveTypeRepository.GetAsync(model.LeaveTypeId));

            return View(model);
        }

        
    }
}
