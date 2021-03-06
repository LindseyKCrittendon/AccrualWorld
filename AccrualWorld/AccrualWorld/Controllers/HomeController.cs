﻿using System;
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

        public async Task<IActionResult> DashboardAsync()
        {
            
            ApplicationUser loggedInUser = await GetCurrentUserAsync();
            //Getting income totals by month for line graph
             DashboardViewModel ViewModel = new DashboardViewModel();
            var incomes = _context.Incomes.Include(u=>u.User).ToList();
            List<double> totals = new List<double>();
            for (int p = 0; p < 12; p++)
            {
                var number = 0.0;
                for (int i = 0; i < incomes.Count; i++)
                {
                    number = incomes.Where(t => t.DateTime.Month == (p + 1) && t.UserId == loggedInUser.Id).Sum(t => t.Total);
                }
                //var betternumber = number / (incomes.Where(t => t.DateTime.Month == (p + 1) && t.UserId == loggedInUser.Id).Count());
                totals.Add(number);
            }

          
            ViewModel.monthlyTotals = totals;
            ViewData["totals"] = totals.ToArray();

            // getting expense totals by month for line graph
            var expenses = _context.Expenses.Include(u => u.User).ToList();
            List<double> eTotals = new List<double>();
            for (int m = 0; m < 12; m++)
            {
                var eNumber = 0.0;
                for (int x = 0; x < expenses.Count; x++)
                {
                    eNumber = expenses.Where(et => et.DateTime.Month == (m + 1) && et.UserId == loggedInUser.Id).Sum(et => et.Total);
                }
                eTotals.Add(eNumber);
            }


            ViewModel.eMonthlyTotals = eTotals;
            ViewData["eTotals"] = eTotals.ToArray();

            //get percentages of expenses grouped together by type for pie chart
            var expenseType = _context.ExpenseTypes
                 .Include(e => e.Expenses)
                 .ThenInclude(u => User)
                 .ToList();

            List<double> ePercentages = new List<double>();
           // List<double> allExpenseSum = new List<double>();
            //need a (total of all expenses regardless of type / sum of expenses by expense type)x100 for percentage
            var totalAllExpensesForYear = 0.0;
           // foreach (var thing in expenses)
           // {
                totalAllExpensesForYear = expenses.Where(xe => xe.DateTime.Year == DateTime.Now.Year && xe.UserId == loggedInUser.Id).Sum(xe => xe.Total);
                 // allExpenseSum.Add(totalAllExpensesForYear)
           // }
            
            //ViewModel.expenses.Where(xe => xe.DateTime.Year == DateTime.Now.Year).Sum(xe.Total);
            foreach (var item in expenseType)
            {
                //for (int n = 0; n < expenses.Count; n++)
               // {


                    var eTNumber = 0.0;

                    eTNumber = (item.Expenses.Where(ete => ete.DateTime.Year == DateTime.Now.Year && ete.UserId == loggedInUser.Id).Sum(ete => ete.Total)) / (totalAllExpensesForYear);

                    ViewModel.ePercentages.Add(eTNumber);

               // }
                
            }
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
