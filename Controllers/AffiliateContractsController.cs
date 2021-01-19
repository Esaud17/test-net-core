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
    public class AffiliateContractsController : Controller
    {
        private readonly AffiliatesDbContext _context;

        public AffiliateContractsController(AffiliatesDbContext context)
        {
            _context = context;
        }

        // GET: AffiliateContracts
        public async Task<IActionResult> Index()
        {
            var affiliatesDbContext = _context.AffiliateContracts.Include(a => a.Affiliate).Include(a => a.ContractStatu);

            return View(await affiliatesDbContext.Where(x => x.ContractStatuId != 7 ).ToListAsync());
        }

        // GET: AffiliateContracts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var affiliateContracts = await _context.AffiliateContracts
                .Include(a => a.Affiliate)
                .Include(a => a.ContractStatu)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (affiliateContracts == null)
            {
                return NotFound();
            }

            return View(affiliateContracts);
        }

        // GET: AffiliateContracts/Create
        public IActionResult Create()
        {
            ViewData["AffiliateId"] = new SelectList(_context.Affiliates, "Id", "FirtsName");
            ViewData["ContractStatuId"] = new SelectList(_context.ContractStatus, "Id", "Status");
            return View();
        }

        // POST: AffiliateContracts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AffiliateId,ContractStatuId,ApplicationDate")] AffiliateContracts affiliateContracts)
        {
            var validReg = _context.AffiliateContracts.Where(x =>x.AffiliateId == affiliateContracts.AffiliateId && x.ContractStatuId == 4 ).Count() == 0 ? true: false;

            if (ModelState.IsValid && validReg )
            {
                affiliateContracts.ContractStatuId = 4;
                affiliateContracts.ApplicationDate = DateTime.Now;

                _context.Add(affiliateContracts);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), "AffiliateContractServices", new { id = affiliateContracts.Id });
            }
            else
            {
                ModelState.AddModelError("AffiliateId", "Can't create new request to contracts by has one pendenting to approve");
               
            }
            ViewData["AffiliateId"] = new SelectList(_context.Affiliates, "Id", "FirtsName", affiliateContracts.AffiliateId);
            ViewData["ContractStatuId"] = new SelectList(_context.ContractStatus, "Id", "Status", affiliateContracts.ContractStatuId);
            return View(affiliateContracts);
        }

        // GET: AffiliateContracts/Edit/5
        [Authorize(Roles = "Administrador,Auditor")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var affiliateContracts = await _context.AffiliateContracts.FindAsync(id);
            if (affiliateContracts == null)
            {
                return NotFound();
            }
            ViewData["AffiliateId"] = new SelectList(_context.Affiliates, "Id", "FirtsName", affiliateContracts.AffiliateId);
            ViewData["ContractStatuId"] = new SelectList(_context.ContractStatus, "Id", "Status", affiliateContracts.ContractStatuId);
            return View(affiliateContracts);
        }

        // POST: AffiliateContracts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Administrador,Auditor")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AffiliateId,ContractStatuId,ApplicationDate")] AffiliateContracts affiliateContracts)
        {
            if (id != affiliateContracts.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(affiliateContracts);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AffiliateContractsExists(affiliateContracts.Id))
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
            ViewData["AffiliateId"] = new SelectList(_context.Affiliates, "Id", "FirtsName", affiliateContracts.AffiliateId);
            ViewData["ContractStatuId"] = new SelectList(_context.ContractStatus, "Id", "Status", affiliateContracts.ContractStatuId);
            return View(affiliateContracts);
        }

        // GET: AffiliateContracts/Delete/5
        [Authorize(Roles = "Administrador")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var affiliateContracts = await _context.AffiliateContracts
                .Include(a => a.Affiliate)
                .Include(a => a.ContractStatu)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (affiliateContracts == null)
            {
                return NotFound();
            }

            return View(affiliateContracts);
        }

        // POST: AffiliateContracts/Delete/5
        [Authorize(Roles = "Administrador")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var affiliateContracts = await _context.AffiliateContracts.FindAsync(id);
            _context.AffiliateContracts.Remove(affiliateContracts);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AffiliateContractsExists(int id)
        {
            return _context.AffiliateContracts.Any(e => e.Id == id);
        }
    }
}
