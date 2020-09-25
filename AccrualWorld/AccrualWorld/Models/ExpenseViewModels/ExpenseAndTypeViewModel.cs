using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccrualWorld.Models.ExpenseViewModels
{
    public class ExpenseAndTypeViewModel
    {
        public Expense expense
        {
            get; set;
        }

        public List<SelectListItem> expenseTypes
        {
            get; set;
        } = new List<SelectListItem>();

    }
}
