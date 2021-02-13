using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Models
{
    public class Pharmacy
    {
        [Display(Name = "Pharmacy Name")]
        public string PharmacyName { get; set; }

        [Display(Name = "Medicine Name")]
        public List<string> MedicineName { get; set; }        

        [Display(Name = "Supply Stock")]
        public List<int> SupplyCount { get; set; }
    }
}
