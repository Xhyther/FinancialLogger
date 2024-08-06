using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinanceLogs.Data;
using FinanceLogs.Models;

namespace FinanceLogs.Controllers
{
    public class WantsController : Controller
    {
        private readonly FinanceDbContext _context;

        public WantsController(FinanceDbContext context)
        {
            _context = context;
        }

        // GET: Wants
        public async Task<IActionResult> Index()
        {
            return View(await _context.Wants.ToListAsync());
        }

        // GET: Wants/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wants = await _context.Wants
                .FirstOrDefaultAsync(m => m.Id == id);
            if (wants == null)
            {
                return NotFound();
            }

            return View(wants);
        }

        // GET: Wants/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Wants/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,ImgUrl,Price,CanBuy")] Wants wants)
        {
            if (ModelState.IsValid)
            {
                _context.Add(wants);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(wants);
        }

        // GET: Wants/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wants = await _context.Wants.FindAsync(id);
            if (wants == null)
            {
                return NotFound();
            }
            return View(wants);
        }

        // POST: Wants/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,ImgUrl,Price,CanBuy")] Wants wants)
        {
            if (id != wants.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wants);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WantsExists(wants.Id))
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
            return View(wants);
        }

        // GET: Wants/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wants = await _context.Wants
                .FirstOrDefaultAsync(m => m.Id == id);
            if (wants == null)
            {
                return NotFound();
            }

            return View(wants);
        }

        // POST: Wants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var wants = await _context.Wants.FindAsync(id);
            if (wants != null)
            {
                _context.Wants.Remove(wants);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WantsExists(int id)
        {
            return _context.Wants.Any(e => e.Id == id);
        }
    }
}
