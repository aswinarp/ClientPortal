using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Models
{
    public class Schedule
    {
        [Display(Name = "Representative")]
        public string RepName { get; set; }

        [Display(Name = "Doctor")]
        public string DocName { get; set; }

        [Display(Name = "Target Ailment")]
        public string Ailment { get; set; }

        [Display(Name = "Medicines")]
        public List<string> Medicine { get; set; }

        [Display(Name = "Slot")]
        public string Time { get; set; }

        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Display(Name = "Contact Number")]
        public long Mobile { get; set; }
    }
}
