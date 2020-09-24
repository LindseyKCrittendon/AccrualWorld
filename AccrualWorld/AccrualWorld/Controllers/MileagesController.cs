using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AccrualWorld.Data;
using AccrualWorld.Models;

namespace AccrualWorld.Controllers
{
    public class MileagesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MileagesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Mileages
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Mileages.Include(m => m.User);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Mileages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mileage = await _context.Mileages
                .Include(m => m.User)
                .FirstOrDefaultAsync(m => m.MileageId == id);
            if (mileage == null)
            {
                return NotFound();
            }

            return View(mileage);
        }

        // GET: Mileages/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id");
            return View();
        }

        // POST: Mileages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MileageId,Total,DateTime,Description,Paid,AmountPerMile,UserId")] Mileage mileage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mileage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", mileage.UserId);
            return View(mileage);
        }

        // GET: Mileages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mileage = await _context.Mileages.FindAsync(id);
            if (mileage == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", mileage.UserId);
            return View(mileage);
        }

        // POST: Mileages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MileageId,Total,DateTime,Description,Paid,AmountPerMile,UserId")] Mileage mileage)
        {
            if (id != mileage.MileageId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mileage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MileageExists(mileage.MileageId))
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
            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", mileage.UserId);
            return View(mileage);
        }

        // GET: Mileages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mileage = await _context.Mileages
                .Include(m => m.User)
                .FirstOrDefaultAsync(m => m.MileageId == id);
            if (mileage == null)
            {
                return NotFound();
            }

            return View(mileage);
        }

        // POST: Mileages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mileage = await _context.Mileages.FindAsync(id);
            _context.Mileages.Remove(mileage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MileageExists(int id)
        {
            return _context.Mileages.Any(e => e.MileageId == id);
        }
    }
}
