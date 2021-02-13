using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Models
{
    public class ScheduleDB
    {
        [Key]
        public int Id { get; set; }
        public string User { get; set; }
        public string RepName { get; set; }
        public string DocName { get; set; }
        public string Ailment { get; set; }
        public string Medicine { get; set; }
        public string Time { get; set; }
        public DateTime Date { get; set; }
        public long Mobile { get; set; }
    }
}
