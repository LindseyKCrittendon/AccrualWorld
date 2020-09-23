using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AccrualWorld.Models
{
    public class ApplicationUser : IdentityUser
    {

        public ApplicationUser()
        {
        
        }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName
        {
            get; set;
        }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName
        {
            get; set;
        }

        public virtual ICollection<Expense> Expenses
        {
            get; set;
        }

        public virtual ICollection<Income> Incomes
        {
            get; set;
        }

        public virtual ICollection<Mileage> Mileages
        {
            get; set;
        }

    }
}
