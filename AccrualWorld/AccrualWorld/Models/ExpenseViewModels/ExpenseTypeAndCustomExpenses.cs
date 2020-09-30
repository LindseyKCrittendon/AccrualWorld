using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccrualWorld.Models.ExpenseViewModels
{
    public class ExpenseTypeAndCustomExpenses
    {
        public ExpenseType expenseType
        {
            get; set;
        }

        public List<Expense> expenses
        {
            get; set;
        } = new List<Expense>();
    }

}
