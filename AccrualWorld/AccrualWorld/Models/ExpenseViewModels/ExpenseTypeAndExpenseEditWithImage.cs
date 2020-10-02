using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AccrualWorld.Models.ExpenseViewModels
{
    public class ExpenseTypeAndExpenseEditWithImage
    {

        public Expense expense
        {
            get; set;
        }
        [NotMapped]
        [Display(Name = "Change Receipt")]
        
        public IFormFile ImageFile
        {
            get; set;
        }
        public List<SelectListItem> expenseTypes
        {
            get; set;
        } = new List<SelectListItem>();




    }
}
