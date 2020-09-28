using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AccrualWorld.Models
{
    public class Income
    {
        [Key]
        public int IncomeId
        {
            get; set;
        }

        [Required]
        [Display(Name = "Date Received")]
        public DateTime DateTime
        {
            get; set;
        }

        [Display(Name = "Image Name")]
        public string ImagePath
        {
            get; set;
        }

        [NotMapped]
        [Display(Name = "Upload Invoice")]
        [Required(ErrorMessage = "Please Upload a Paystub or Invoice")]
        public IFormFile ImageFile
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
        [StringLength(255)]
        public string Description
        {
            get; set;
        }

        [Required]
        [StringLength(55, ErrorMessage = "Please Shorten Payer Name to 55 Characters")]
        public string Payer
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
