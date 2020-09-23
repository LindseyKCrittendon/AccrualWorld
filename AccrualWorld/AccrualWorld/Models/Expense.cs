using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AccrualWorld.Models
{
    public class Expense
    {
        [Key]
        public int ExpenseId
        {
            get; set;
        }

        [Required]
        [Display(Name = "Deduction Category")]
        [Range(1, 1000, ErrorMessage = "Please Select a Deduction Category")]
        public int ExpenseTypeId
        {
            get; set;
        }

        [Required]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public double Total
        {
            get; set;
        }

        [Required]
        [Display(Name = "Date Purchased")]
        public DateTime DateTime
        {
            get; set;
        }

        public string ImagePath
        {
            get; set;
        }


        [Required]
        public ApplicationUser User
        {
            get; set;
        }

        [Required]
        public string UserId
        {
            get; set;
        }

        public ExpenseType ExpenseType
        {
            get; set;
        }

    }
}
