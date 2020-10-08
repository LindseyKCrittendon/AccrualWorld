using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AccrualWorld.Models;
using AccrualWorld.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AccrualWorld.Models.DashboardViewModels;

namespace AccrualWorld.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _context;

        // Add private field to hold our user manager
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        // Get the currently logged in user
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            
            //ApplicationUser loggedInUser = await GetCurrentUserAsync();
            //INSTANCE OF VIEW MODEL
             DashboardViewModel ViewModel = new DashboardViewModel();
            //TODO:: DATE RANGE PICKER FOR GRAPHS AND CHARTS
            var incomes = _context.Incomes.ToList();
            //   .Include(m => m.User)
            //adds conditional information for date range picker.
            //  .Where(income => income.UserId == loggedInUser.Id)
            //  .ToListAsync();
            // return View();
            List<double> totals = new List<double>();
            for (int p = 0; p < 12; p++)
            {
                var number = 0.0;
                for (int i = 0; i < incomes.Count; i++)
                {
                    number += incomes.Where(t => t.DateTime.Month == (p + 1)).Sum(t => t.Total);
                }
                totals.Add(number);
            }

          
            ViewModel.monthlyTotals = totals;
            ViewData["totals"] = totals.ToArray();
            return View(ViewModel);
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
