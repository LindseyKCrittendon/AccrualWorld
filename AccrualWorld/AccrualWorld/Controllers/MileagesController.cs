using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AccrualWorld.Data;
using AccrualWorld.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace AccrualWorld.Controllers
{[Authorize]
    public class MileagesController : Controller
    {
        private readonly ApplicationDbContext _context;

        // Add private field to hold our user manager
        private readonly UserManager<ApplicationUser> _userManager;

        public MileagesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // Get the currently logged in user
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        // GET: Mileages
        public async Task<IActionResult> Index(DateTime? start, DateTime? end)
        {
            ApplicationUser loggedInUser = await GetCurrentUserAsync();
            //TODO:: DATE RANGE PICKER BROKE CALCULATIONS.  GET CORRECT CALCULATIONS FOR CURRENT MONTH AND YEAR REGARDLESS
            var mileage = await _context.Mileages
                .Include(m => m.User)
                //adds conditional information for date range picker.
                .Where(mileage => mileage.UserId == loggedInUser.Id && (!start.HasValue || mileage.DateTime >= start) && (!end.HasValue || mileage.DateTime <= end))
                .ToListAsync();
            return View(mileage);
        }

        // GET: Mileages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            ApplicationUser loggedInUser = await GetCurrentUserAsync();
            if (id == null)
            {
                return NotFound();
            }

            var mileage = await _context.Mileages
                .Include(m => m.User)
                .Where(mileage => mileage.UserId == loggedInUser.Id)
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
            
            return View();
        }

        // POST: Mileages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MileageId,Total,DateTime,Description,Paid,AmountPerMile,UserId")] Mileage mileage)
        {
            ModelState.Remove("User");
            ModelState.Remove("UserId");

            if (ModelState.IsValid)
            {
                var user = await GetCurrentUserAsync();
                mileage.UserId = user.Id;
                _context.Add(mileage);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", new
                {
                    id = mileage.MileageId
                });
            }
            
            return View(mileage);
        }

        // GET: Mileages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ApplicationUser loggedInUser = await GetCurrentUserAsync();
            if (id == null)
            {
                return NotFound();
            }

            var mileage = await _context.Mileages
                 .Include(m => m.User)
                .Where(mileage => mileage.UserId == loggedInUser.Id)
                .FirstOrDefaultAsync(m => m.MileageId == id);
            ;
            if (mileage == null)
            {
                return NotFound();
            }
           
            return View(mileage);
        }

        // POST: Mileages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MileageId,Total,DateTime,Description,Paid,AmountPerMile,UserId")] Mileage mileage)
        {
            ModelState.Remove("User");
            ModelState.Remove("UserId");
            if (id != mileage.MileageId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var user = await GetCurrentUserAsync();
                    mileage.UserId = user.Id;
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
                return RedirectToAction("Details", new
                {
                    id = mileage.MileageId
                });
            }
           
            return View(mileage);
        }

        // GET: Mileages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            ApplicationUser loggedInUser = await GetCurrentUserAsync();
            if (id == null)
            {
                return NotFound();
            }

            var mileage = await _context.Mileages
                .Include(m => m.User)
                .Where(mileage => mileage.UserId == loggedInUser.Id)
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
            var user = await GetCurrentUserAsync();
            mileage.UserId = user.Id;
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
