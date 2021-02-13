using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Models
{
    public class PharmacyDB
    {
        [Key]
        public int Id { get; set; }
        public string User { get; set; }
        public string PharmacyName { get; set; }
        public string MedicineName { get; set; }
        public string SupplyCount { get; set; }
    }
}
