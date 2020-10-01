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
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace AccrualWorld.Controllers
{
    [Authorize]
    public class IncomesController : Controller
    {
        private readonly ApplicationDbContext _context;

        // Add private field to hold our user manager
        private readonly UserManager<ApplicationUser> _userManager;

        //Add private field for photos
        private readonly IWebHostEnvironment _hostEnvironment;

        public IncomesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _userManager = userManager;
            this._hostEnvironment = hostEnvironment;
        }

        // Get the currently logged in user
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        // GET: Incomes
        public async Task<IActionResult> Index(DateTime? start, DateTime? end)
        {
            //Added user information to only show information for the correct user
            ApplicationUser loggedInUser = await GetCurrentUserAsync();

            var income = await _context.Incomes
               .Include(i => i.User)
                .Where(income => income.UserId == loggedInUser.Id && (!start.HasValue || income.DateTime >= start) && (!end.HasValue || income.DateTime <= end))
                .ToListAsync();
            return View(income);
        }

        // GET: Incomes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            ApplicationUser loggedInUser = await GetCurrentUserAsync();

            if (id == null)
            {
                return NotFound();
            }

            var income = await _context.Incomes
                .Include(i => i.User)
                .Where(income => income.UserId == loggedInUser.Id)
                .FirstOrDefaultAsync(m => m.IncomeId == id);
            if (income == null)
            {
                return NotFound();
            }

            return View(income);
        }

        // GET: Incomes/Create
        public IActionResult Create()
        {
           
            return View();
        }

        // POST: Incomes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IncomeId,DateTime,ImageFile,Total,Description,Payer,UserId")] Income income)
        {
            ModelState.Remove("UserId");
            ModelState.Remove("User");

            //saving image to wwwRoot/receipt
            string wwwRootPath = _hostEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(income.ImageFile.FileName);
            string extension = Path.GetExtension(income.ImageFile.FileName);
            income.ImagePath = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            string path = Path.Combine(wwwRootPath + "/invoice/", fileName);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                await income.ImageFile.CopyToAsync(fileStream);
            }


            if (ModelState.IsValid)
            {
                var user = await GetCurrentUserAsync();
                income.UserId = user.Id;
                _context.Add(income);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", new
                {
                    id = income.IncomeId
                });
            }
            
            return View(income);
        }

        // GET: Incomes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ApplicationUser loggedInUser = await GetCurrentUserAsync();
            //TODO:: MAKE SURE USER SEES PICTURE THEY ALREADY UPLOADED AND CAN CHANGE PICTURE IF WANTED
            if (id == null)
            {
                return NotFound();
            }

            var income = await _context.Incomes
                .Include(i => i.User)
                .Where(income => income.UserId == loggedInUser.Id)
               // .FindAsync(id);
               .FirstOrDefaultAsync(m => m.IncomeId == id);
            if (income == null)
            {
                return NotFound();
            }
           
            return View(income);
        }

        // POST: Incomes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IncomeId,DateTime,ImageFile,Total,Description,Payer,UserId")] Income income)
        {
            ModelState.Remove("User");
            ModelState.Remove("UserId");

            //saving image to wwwRoot/receipt
            string wwwRootPath = _hostEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(income.ImageFile.FileName);
            string extension = Path.GetExtension(income.ImageFile.FileName);
            income.ImagePath = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            string path = Path.Combine(wwwRootPath + "/invoice/", fileName);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                await income.ImageFile.CopyToAsync(fileStream);
            }

            if (id != income.IncomeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var user = await GetCurrentUserAsync();
                    income.UserId = user.Id;
                    _context.Update(income);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IncomeExists(income.IncomeId))
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
                    id = income.IncomeId
                });
            }
           
            return View(income);
        }

        // GET: Incomes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            ApplicationUser loggedInUser = await GetCurrentUserAsync();
            if (id == null)
            {
                return NotFound();
            }

            var income = await _context.Incomes
                .Include(i => i.User)
                .Where(income => income.UserId == loggedInUser.Id)
                .FirstOrDefaultAsync(m => m.IncomeId == id);
            if (income == null)
            {
                return NotFound();
            }

            return View(income);
        }

        // POST: Incomes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var income = await _context.Incomes.FindAsync(id);
            var user = await GetCurrentUserAsync();

            //deletes the image from the wwwroot folder
            var imagePath = Path.Combine(_hostEnvironment.WebRootPath, "invoice", income.ImagePath);
            if (System.IO.File.Exists(imagePath))
                System.IO.File.Delete(imagePath);

            income.UserId = user.Id;
            _context.Incomes.Remove(income);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IncomeExists(int id)
        {
            return _context.Incomes.Any(e => e.IncomeId == id);
        }

        //display paystubs only
        public async Task<IActionResult> Invoice(DateTime? start, DateTime? end)
        {
            //Added user information to only show information for the correct user
            ApplicationUser loggedInUser = await GetCurrentUserAsync();

            var income = await _context.Incomes
               .Include(i => i.User)
                .Where(income => income.UserId == loggedInUser.Id && (!start.HasValue || income.DateTime >= start) && (!end.HasValue || income.DateTime <= end))
                .ToListAsync();
            return View(income);
        }
    }
}
