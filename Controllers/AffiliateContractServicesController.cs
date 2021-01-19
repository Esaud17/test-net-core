using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AFFILIATES.GB.Models;
using Microsoft.AspNetCore.Authorization;

namespace AFFILIATES.GB.Controllers
{
    [Authorize]
    public class AffiliateContractServicesController : Controller
    {
        private readonly AffiliatesDbContext _context;

        public AffiliateContractServicesController(AffiliatesDbContext context)
        {
            _context = context;
        }

        // GET: AffiliateContractServices
        public async Task<IActionResult> Index(int? id)
        {
            if (id == null)
            {
                return NotFound(); 
            }

            var affiliatesDbContext = _context.AffiliateContractServices.Include(a => a.AffiliateContract).Include(a => a.Service).Where(x=> x.AffiliateContractId == id);

            ViewData["AffiliateContractId"] = id;
            return View(await affiliatesDbContext.ToListAsync());
        }

        // GET: AffiliateContractServices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var affiliateContractServices = await _context.AffiliateContractServices
                .Include(a => a.AffiliateContract)
                .Include(a => a.Service)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (affiliateContractServices == null)
            {
                return NotFound();
            }

            return View(affiliateContractServices);
        }

        // GET: AffiliateContractServices/Create
        public IActionResult Create(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ViewData["Valor"] = id;//new SelectList(_context.AffiliateContracts, "Id", "Id");
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Code");
           
            return View();
        }

        // POST: AffiliateContractServices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AffiliateContractId,ServiceId,Observation")] AffiliateContractServices affiliateContractServices)
        {
            if (ModelState.IsValid)
            {
                //affiliateContractServices.AffiliateContract = _context.AffiliateContracts.Where(x => x.Id == affiliateContractServices.AffiliateContractId).First();
                affiliateContractServices.Id = 0;
                _context.Add(affiliateContractServices);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index),new {id = affiliateContractServices.AffiliateContractId });
            }
            ViewData["AffiliateContractId"] = new SelectList(_context.AffiliateContracts, "Id", "Id", affiliateContractServices.AffiliateContractId);
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Code", affiliateContractServices.ServiceId);
            return View(affiliateContractServices);
        }

        // GET: AffiliateContractServices/Edit/5
        [Authorize(Roles = "Administrador,Auditor")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var affiliateContractServices = await _context.AffiliateContractServices.FindAsync(id);
            if (affiliateContractServices == null)
            {
                return NotFound();
            }
            ViewData["AffiliateContractId"] = new SelectList(_context.AffiliateContracts, "Id", "Id", affiliateContractServices.AffiliateContractId);
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Code", affiliateContractServices.ServiceId);
            return View(affiliateContractServices);
        }

        // POST: AffiliateContractServices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Administrador,Auditor")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AffiliateContractId,ServiceId,Observation")] AffiliateContractServices affiliateContractServices)
        {
            if (id != affiliateContractServices.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(affiliateContractServices);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AffiliateContractServicesExists(affiliateContractServices.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index), new { id = affiliateContractServices.AffiliateContractId });
            }
            ViewData["AffiliateContractId"] = new SelectList(_context.AffiliateContracts, "Id", "Id", affiliateContractServices.AffiliateContractId);
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Code", affiliateContractServices.ServiceId);
            return View(affiliateContractServices);
        }

        // GET: AffiliateContractServices/Delete/5
        [Authorize(Roles = "Administrador")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var affiliateContractServices = await _context.AffiliateContractServices
                .Include(a => a.AffiliateContract)
                .Include(a => a.Service)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (affiliateContractServices == null)
            {
                return NotFound();
            }

            return View(affiliateContractServices);
        }

        // POST: AffiliateContractServices/Delete/5
        [Authorize(Roles = "Administrador")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
           
            var affiliateContractServices = await _context.AffiliateContractServices.FindAsync(id);
            var contract = affiliateContractServices.AffiliateContractId;

            _context.AffiliateContractServices.Remove(affiliateContractServices);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index),new {id= contract });
        }

        private bool AffiliateContractServicesExists(int id)
        {
            return _context.AffiliateContractServices.Any(e => e.Id == id);
        }
    }
}
