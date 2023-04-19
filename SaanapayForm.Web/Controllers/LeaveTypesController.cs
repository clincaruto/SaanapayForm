using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SaanapayForm.Web.Constants;
using SaanapayForm.Web.Data;
using SaanapayForm.Web.GenericRepository.IRepository;
using SaanapayForm.Web.Models.Domain;
using SaanapayForm.Web.Models.ViewModel;

namespace SaanapayForm.Web.Controllers
{
    [Authorize(Roles = Roles.Administrator)]
   // [Authorize(Roles = "Administrator, User")]
    public class LeaveTypesController : Controller
    {
        
        private readonly ILeaveTypeRepository leaveTypeRepository;
        private readonly IMapper mapper;

        public LeaveTypesController(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            
            this.leaveTypeRepository = leaveTypeRepository;
            this.mapper = mapper;
        }

        // GET: LeaveTypes
        public async Task<IActionResult> Index()
        {
            // Fetch data from the database - domain leavetype
            var leaveTypes = await leaveTypeRepository.GetAllAsync();

            // Convert domain into Viewmodel
            var LeaveTypeVM = mapper.Map<List<LeaveTypeVM>>(leaveTypes);

            // return response
            return View(LeaveTypeVM);
        }

        // GET: LeaveTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            // Get data from database
            var leaveType = await leaveTypeRepository.GetAsync(id);

            if (leaveType == null)
            {
                return NotFound();
            }

            // Convert domain into viewmodel leavetype
            var leaveTypeVM = mapper.Map<LeaveTypeVM>(leaveType);
            return View(leaveTypeVM);

           
        }

        // GET: LeaveTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LeaveTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LeaveTypeVM leaveTypeVM)
        {
            if (ModelState.IsValid)
            {
                var leaveType = mapper.Map<LeaveType>(leaveTypeVM);
                await leaveTypeRepository.AddAsync(leaveType);
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeVM);
        }

        // GET: LeaveTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            // Get data from database
            var leaveType = await leaveTypeRepository.GetAsync(id);

            if (leaveType == null)
            {
                return NotFound();
            }

            // Convert domain into viewmodel leavetype
            var leaveTypeVM = mapper.Map<LeaveTypeVM>(leaveType);
            return View(leaveTypeVM);
        }

        // POST: LeaveTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,  LeaveTypeVM leaveTypeVM)
        {
            if (id != leaveTypeVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var leaveType = mapper.Map<LeaveType>(leaveTypeVM);
                    await leaveTypeRepository.UpdateAsync(leaveType);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await leaveTypeRepository.Exists(leaveTypeVM.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeVM);
        }

        
       

        // POST: LeaveTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await leaveTypeRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        //private async Task<bool> LeaveTypeExists(int id)
        //{
        //  return await leaveTypeRepository.Exists(id);
        //}
    }
}
