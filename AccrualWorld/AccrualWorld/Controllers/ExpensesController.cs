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
    public class ExpensesController : Controller
    {
        private readonly ApplicationDbContext _context;

        // Add private field to hold our user manager
        private readonly UserManager<ApplicationUser> _userManager;

        public ExpensesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // Get the currently logged in user
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        // GET: Expenses
        public async Task<IActionResult> Index()
        {
            //Added user information to only show information for the correct user
            ApplicationUser loggedInUser = await GetCurrentUserAsync();

            var expense = await _context.Expenses
                .Include(et => et.ExpenseType)
                .Include(u => u.User)
                .Where(expense => expense.UserId == loggedInUser.Id)
                .ToListAsync();
            return View(expense);

            //var applicationDbContext = _context.Expenses.Include(e => e.ExpenseType).Include(e => e.User);
            //return View(await applicationDbContext.ToListAsync());
        }

        // GET: Expenses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expense = await _context.Expenses
                .Include(e => e.ExpenseType)
                .Include(e => e.User)
                .FirstOrDefaultAsync(m => m.ExpenseId == id);
            if (expense == null)
            {
                return NotFound();
            }

            return View(expense);
        }

        // GET: Expenses/Create
        public IActionResult Create()
        {
            //create an instance of the ExpenseCreateViewModel to get the list of ExpenseTypes in dropdown
            ExpenseCreateViewModel ViewModel = new ExpenseCreateViewModel();

            //then use the view model rather than view data for more flexibility
            ViewModel.expenseTypes = _context.ExpenseTypes.Select(c => new SelectListItem
            {
                Text = c.Label,
                Value = c.ExpenseTypeId.ToString()
            }
            ).ToList();

            //Forces user to select from the drop down
            //Error displays if not due to data annotation on product type model
            ViewModel.expenseTypes.Insert(0, new SelectListItem() { Value = "0", Text = "--Select Deduction Category--" });

            return View(ViewModel);

            //ViewData["ExpenseTypeId"] = new SelectList(_context.ExpeseTypes, "ExpenseTypeId", "Label");
            //ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id");
            //return View();
        }

        // POST: Expenses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ExpenseId,ExpenseTypeId,Total,DateTime,ImagePath,UserId")] Expense expense)
        {
            //adding user information automatically rather than in the form
            ModelState.Remove("expense.User");
            ModelState.Remove("expense.UserId");

            ExpenseCreateViewModel ViewModel = new ExpenseCreateViewModel();

            if (ModelState.IsValid)
            {
                //add user to get the user information
                var user = await GetCurrentUserAsync();
                expense.UserId = user.Id;
                _context.Add(expense);
                await _context.SaveChangesAsync();
                //redirects to expense details view
                return RedirectToAction("Details", new
                {
                    id = expense.ExpenseId
                });
            }
            ViewModel.expenseTypes = _context.ExpenseTypes.Select(c => new SelectListItem
            {
                Text = c.Label,
                Value = c.ExpenseTypeId.ToString()
            }).ToList();
            return View(ViewModel);
            //ViewData["ExpenseTypeId"] = new SelectList(_context.ExpeseTypes, "ExpenseTypeId", "Label", expense.ExpenseTypeId);
            //ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", expense.UserId);
            //return View(expense);
        }

        // GET: Expenses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expense = await _context.Expenses.FindAsync(id);
            if (expense == null)
            {
                return NotFound();
            }
            ViewData["ExpenseTypeId"] = new SelectList(_context.ExpenseTypes, "ExpenseTypeId", "Label", expense.ExpenseTypeId);
            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", expense.UserId);
            return View(expense);
        }

        // POST: Expenses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ExpenseId,ExpenseTypeId,Total,DateTime,ImagePath,UserId")] Expense expense)
        {
            if (id != expense.ExpenseId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var user = await GetCurrentUserAsync();
                    expense.UserId = user.Id;
                    _context.Update(expense);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExpenseExists(expense.ExpenseId))
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
            ViewData["ExpenseTypeId"] = new SelectList(_context.ExpenseTypes, "ExpenseTypeId", "Label", expense.ExpenseTypeId);
            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", expense.UserId);
            return View(expense);
        }

        // GET: Expenses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expense = await _context.Expenses
                .Include(e => e.ExpenseType)
                .Include(e => e.User)
                .FirstOrDefaultAsync(m => m.ExpenseId == id);
            if (expense == null)
            {
                return NotFound();
            }

            return View(expense);
        }

        // POST: Expenses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var expense = await _context.Expenses.FindAsync(id);
            _context.Expenses.Remove(expense);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExpenseExists(int id)
        {
            return _context.Expenses.Any(e => e.ExpenseId == id);
        }
    }
}
