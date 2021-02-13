using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Portal.Models
{
    public class Helper
    {
        [Display(Name = "User Name")]
        [Required]
        public string UserName { get; set; }

        [Display(Name = "Password")]
        [Required]
        public string Password { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime StartDate { get; set; }

    }
}
