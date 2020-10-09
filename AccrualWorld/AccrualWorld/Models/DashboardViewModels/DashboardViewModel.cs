using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccrualWorld.Models.DashboardViewModels
{
    public class DashboardViewModel
    {
        public Income income
        {
            get; set;
        }

        public List<Income> incomes
        {
            get; set;
        } = new List<Income>();

        public Expense expense
        {
            get; set;
        }

        public List<Expense> expenses
        {
            get; set;
        } = new List<Expense>();

        public ExpenseType expenseType
        {
            get; set;
        }

        public Mileage mileage
        {
            get; set;
        }

        public List<Mileage> mileages
        {
            get; set;
        } = new List<Mileage>();

        public List<double> monthlyTotals = new List<double>();

        public List<double> eMonthlyTotals = new List<double>();

        public List<double> ePercentages = new List<double>();
    }
}
