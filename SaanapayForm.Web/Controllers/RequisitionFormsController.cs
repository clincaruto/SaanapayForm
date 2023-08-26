using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SaanapayForm.Web.Data;
using SaanapayForm.Web.GenericRepository.IRepository;
using SaanapayForm.Web.GenericRepository.Repository;
using SaanapayForm.Web.Models.Domain;
using SaanapayForm.Web.Models.ViewModel;

namespace SaanapayForm.Web.Controllers
{
    [Authorize]
    public class RequisitionFormsController : Controller
    {
       
        private readonly IRequisitionRepository requisitionRepository;
        private readonly IMapper mapper;

        public RequisitionFormsController(IRequisitionRepository requisitionRepository, IMapper mapper)
        {
            this.requisitionRepository = requisitionRepository;
            this.mapper = mapper;
        }

        // GET: RequisitionForms
        //[ActionName("Draft")]
        public async Task<IActionResult> Index([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
        {
            // 
            var requisition = await requisitionRepository.GetAllAsync(pageNumber, pageSize);

            // covert domain into viewmodel
            var requisitionVM = mapper.Map<List<RequisitionFormVM>>(requisition);
            return View(requisitionVM);

        }

        // GET: RequisitionForms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
           var requisition = await requisitionRepository.GetAsync(id);
            if (requisition == null)
            {
                return NotFound();
            }

            // Convert domain into viewmodel leavetype
            var requisitionVM = mapper.Map<RequisitionFormVM>(requisition);
            return View(requisitionVM);
        }

        // GET: RequisitionForms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RequisitionForms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( RequisitionFormVM requisitionFormVM)
        {
            if (ModelState.IsValid)
            {
                var requisition = mapper.Map<RequisitionForm>(requisitionFormVM);
                await requisitionRepository.AddAsync(requisition);
                return RedirectToAction(nameof(Index));
            }
            return View(requisitionFormVM);
        }

        // GET: RequisitionForms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            // Get data from database
            var requisition = await requisitionRepository.GetAsync(id);
            if (requisition == null)
            {
                return NotFound();
            }

            // convert domain into viewmodel requisitionform
            var requisitionVM = mapper.Map<RequisitionFormVM>(requisition);
            return View(requisitionVM);
        }

        // POST: RequisitionForms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, RequisitionFormVM requisitionFormVM)
        {
            if (id != requisitionFormVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var requisition = mapper.Map<RequisitionForm>(requisitionFormVM);
                    await requisitionRepository.UpdateAsync(requisition);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await requisitionRepository.Exists(requisitionFormVM.Id))
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
            return View(requisitionFormVM);

          
        }

      

        // POST: RequisitionForms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
           await requisitionRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        //private bool RequisitionFormExists(int id)
        //{
        //  return (_context.RequisitionForm?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
