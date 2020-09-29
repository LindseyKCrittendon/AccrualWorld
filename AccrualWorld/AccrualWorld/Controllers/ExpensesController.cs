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
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace AccrualWorld.Controllers
{
    public class ExpensesController : Controller
    {
        private readonly ApplicationDbContext _context;

        // Add private field to hold our user manager
        private readonly UserManager<ApplicationUser> _userManager;

        //Add private field for photos
        private readonly IWebHostEnvironment _hostEnvironment;

        public ExpensesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _userManager = userManager;
            this._hostEnvironment = hostEnvironment;
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
                //.Include(e => e.User)
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
            ExpenseAndTypeViewModel ViewModel = new ExpenseAndTypeViewModel();

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
        public async Task<IActionResult> Create([Bind("ExpenseId,ExpenseTypeId,Total,DateTime,ImageFile,UserId")] Expense expense)
        {
            //adding user information automatically rather than in the form
            ModelState.Remove("expense.User");
            ModelState.Remove("expense.UserId");

            ExpenseAndTypeViewModel ViewModel = new ExpenseAndTypeViewModel();

            //Forced user to upload a file by making ImageFile Required with an error message in model

            //saving image to wwwRoot/receipt

                    string wwwRootPath = _hostEnvironment.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(expense.ImageFile.FileName);
                    string extension = Path.GetExtension(expense.ImageFile.FileName);
                    expense.ImagePath = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwRootPath + "/receipt/", fileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await expense.ImageFile.CopyToAsync(fileStream);
                    }
                
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
            ExpenseAndTypeViewModel ViewModel = new ExpenseAndTypeViewModel();
            if (id == null)
            {
                return NotFound();
            }

            ViewModel.expense = await _context.Expenses.FindAsync(id);
            if (ViewModel.expense == null)
            {
                return NotFound();
            }
            ViewModel.expenseTypes = _context.ExpenseTypes.Select(c => new SelectListItem
            {
                Text = c.Label,
                Value = c.ExpenseTypeId.ToString()
            }
            ).ToList();
            //ViewData["ExpenseTypeId"] = new SelectList(_context.ExpenseTypes, "ExpenseTypeId", "Label", expense.ExpenseTypeId);
            //ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", expense.UserId);
            return View(ViewModel);
        }

        // POST: Expenses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ExpenseId,ExpenseTypeId,Total,DateTime,ImageFile,UserId")] Expense expense)
        {
            ModelState.Remove("expense.User");
            ModelState.Remove("expense.UserId");

            //saving image to wwwRoot/receipt
            string wwwRootPath = _hostEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(expense.ImageFile.FileName);
            string extension = Path.GetExtension(expense.ImageFile.FileName);
            expense.ImagePath = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            string path = Path.Combine(wwwRootPath + "/receipt/", fileName);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                await expense.ImageFile.CopyToAsync(fileStream);
            }


            ExpenseAndTypeViewModel ViewModel = new ExpenseAndTypeViewModel();
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
            //ViewData["ExpenseTypeId"] = new SelectList(_context.ExpenseTypes, "ExpenseTypeId", "Label", expense.ExpenseTypeId);
            //ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", expense.UserId);
            return View(ViewModel);
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
            var user = await GetCurrentUserAsync();
            expense.UserId = user.Id;
            //deletes the image from the wwwroot folder
            var imagePath = Path.Combine(_hostEnvironment.WebRootPath, "receipt", expense.ImagePath);
            if (System.IO.File.Exists(imagePath))
                System.IO.File.Delete(imagePath);

            //deletes the record in the database
            _context.Expenses.Remove(expense);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "ExpenseTypes", new
            {
                id = expense.ExpenseTypeId
            });
        }

        private bool ExpenseExists(int id)
        {
            return _context.Expenses.Any(e => e.ExpenseId == id);
        }

        // GET: Receipts
        public async Task<IActionResult> Receipt()
        {
            //Added user information to only show information for the correct user
            ApplicationUser loggedInUser = await GetCurrentUserAsync();

            var expense = await _context.Expenses
                
                .Include(u => u.User)
                .Where(expense => expense.UserId == loggedInUser.Id)
                .ToListAsync();
            return View(expense);

            
        }
    }
}
