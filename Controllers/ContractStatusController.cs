using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AFFILIATES.GB.Models;
using Microsoft.AspNetCore.Authorization;

namespace AFFILIATES.GB
{
    [Authorize(Roles = "Administrador")]
    public class ContractStatusController : Controller
    {
        private readonly AffiliatesDbContext _context;

        public ContractStatusController(AffiliatesDbContext context)
        {
            _context = context;
        }

        // GET: ContractStatus
        public async Task<IActionResult> Index()
        {
            return View(await _context.ContractStatus.ToListAsync());
        }

        // GET: ContractStatus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contractStatus = await _context.ContractStatus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contractStatus == null)
            {
                return NotFound();
            }

            return View(contractStatus);
        }

        // GET: ContractStatus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ContractStatus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Status,Enable")] ContractStatus contractStatus)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contractStatus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contractStatus);
        }

        // GET: ContractStatus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contractStatus = await _context.ContractStatus.FindAsync(id);
            if (contractStatus == null)
            {
                return NotFound();
            }
            return View(contractStatus);
        }

        // POST: ContractStatus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Status,Enable")] ContractStatus contractStatus)
        {
            if (id != contractStatus.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contractStatus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContractStatusExists(contractStatus.Id))
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
            return View(contractStatus);
        }

        // GET: ContractStatus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contractStatus = await _context.ContractStatus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contractStatus == null)
            {
                return NotFound();
            }

            return View(contractStatus);
        }

        // POST: ContractStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contractStatus = await _context.ContractStatus.FindAsync(id);
            _context.ContractStatus.Remove(contractStatus);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContractStatusExists(int id)
        {
            return _context.ContractStatus.Any(e => e.Id == id);
        }
    }
}
