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
    public class AffiliatesController : Controller
    {
        private readonly AffiliatesDbContext _context;

        public AffiliatesController(AffiliatesDbContext context)
        {
            _context = context;
        }

        // GET: Affiliates
        public async Task<IActionResult> Index()
        {
            return View(await _context.Affiliates.ToListAsync());
        }

        // GET: Affiliates/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var affiliates = await _context.Affiliates.Include( x => x.AffiliateContracts)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (affiliates == null)
            {
                return NotFound();
            }
            

            return View(affiliates);
        }

        // GET: Affiliates/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Affiliates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirtsName,LastName,NationalId,Birthday,Gender")] Affiliates affiliates)
        {
            if (ModelState.IsValid)
            {
                _context.Add(affiliates);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(affiliates);
        }

        // GET: Affiliates/Edit/5
        [Authorize(Roles = "Administrador,Auditor")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var affiliates = await _context.Affiliates.FindAsync(id);
            if (affiliates == null)
            {
                return NotFound();
            }
            return View(affiliates);
        }

        // POST: Affiliates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrador,Auditor")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirtsName,LastName,NationalId,Birthday,Gender")] Affiliates affiliates)
        {
            if (id != affiliates.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(affiliates);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AffiliatesExists(affiliates.Id))
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
            return View(affiliates);
        }

        // GET: Affiliates/Delete/5
        [Authorize(Roles = "Administrador")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var affiliates = await _context.Affiliates
                .FirstOrDefaultAsync(m => m.Id == id);
            if (affiliates == null)
            {
                return NotFound();
            }

            return View(affiliates);
        }

        // POST: Affiliates/Delete/5
        [Authorize(Roles = "Administrador")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var affiliates = await _context.Affiliates.FindAsync(id);
            _context.Affiliates.Remove(affiliates);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AffiliatesExists(int id)
        {
            return _context.Affiliates.Any(e => e.Id == id);
        }
    }
}
