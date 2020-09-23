using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AccrualWorld.Models
{
    public class ExpenseType
    {
        [Key]
        public int ExpenseTypeId
        {
            get; set;
        }

        [Required]
        [StringLength(255)]
        [Display(Name = "Deduction Category")]
        public string Label
        {
            get; set;
        }

        [NotMapped]
        public int Quantity
        {
            get; set;
        }

        public virtual ICollection<Expense> Expenses
        {
            get; set;
        }


    }
}
