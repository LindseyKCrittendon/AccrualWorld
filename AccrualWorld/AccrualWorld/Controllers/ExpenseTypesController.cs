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
using AccrualWorld.Models.ExpenseViewModels;

namespace AccrualWorld.Controllers
{
    public class ExpenseTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        // Add private field to hold our user manager
        private readonly UserManager<ApplicationUser> _userManager;

        public ExpenseTypesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // Get the currently logged in user
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        // GET: ExpenseTypes
        public async Task<IActionResult> Index()
        {
            

            var ExpenseType = await _context.ExpenseTypes
                .Include(e => e.Expenses)
                
                .ToListAsync();

            return View(ExpenseType);
            //return View(await _context.ExpenseTypes.ToListAsync());
        }

        // GET: ExpenseTypes/Details/5
        public async Task<IActionResult> Details(int? id, DateTime? start, DateTime? end)
        {

            ExpenseTypeAndCustomExpenses vm = new ExpenseTypeAndCustomExpenses();
            
            
            if (id == null)
            {
                return NotFound();
            }
            //created a view model to manipulate the expense list within ExpenseTypes freely for date picker and calculations
           vm.expenseType = await _context.ExpenseTypes
                .Include(e => e.Expenses)
                //.Include(u => User)
                
                //.ToListAsync();
                .FirstOrDefaultAsync(m => m.ExpenseTypeId == id);
            //targeting expenses in the view model for the date picker
             vm.expenses = vm.expenseType.Expenses.Where(t => (!start.HasValue || t.DateTime >= start) && (!end.HasValue || t.DateTime <= end)).ToList();
            if (vm.expenseType == null)
            {
                return NotFound();
            }

            return View(vm);
        }

        // GET: ExpenseTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ExpenseTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ExpenseTypeId,Label")] ExpenseType expenseType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(expenseType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(expenseType);
        }

        // GET: ExpenseTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expenseType = await _context.ExpenseTypes.FindAsync(id);
            if (expenseType == null)
            {
                return NotFound();
            }
            return View(expenseType);
        }

        // POST: ExpenseTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ExpenseTypeId,Label")] ExpenseType expenseType)
        {
            if (id != expenseType.ExpenseTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(expenseType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExpenseTypeExists(expenseType.ExpenseTypeId))
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
            return View(expenseType);
        }

        // GET: ExpenseTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expenseType = await _context.ExpenseTypes
                .FirstOrDefaultAsync(m => m.ExpenseTypeId == id);
            if (expenseType == null)
            {
                return NotFound();
            }

            return View(expenseType);
        }

        // POST: ExpenseTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var expenseType = await _context.ExpenseTypes.FindAsync(id);
            _context.ExpenseTypes.Remove(expenseType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExpenseTypeExists(int id)
        {
            return _context.ExpenseTypes.Any(e => e.ExpenseTypeId == id);
        }
    }
}
