using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AccrualWorld.Models
{
    public class Mileage
    {
        [Key]
        public int MileageId
        {
            get; set;
        }

        [Required]
        public int Total
        {
            get; set;
        }

        [Required]
        [Display(Name = "Date")]
        public DateTime DateTime
        {
            get; set;
        }

        [Required]
        [StringLength(255)]
        public string Description
        {
            get; set;
        }

        public bool Paid
        {
            get; set;
        }

        [DisplayFormat(DataFormatString = "{0:C}")]
        [Display(Name = "Amount per Mile")]
        public double AmountPerMile
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
    }
}
