using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Models
{
    public static class GlobalData
    {
        public static List<Pharmacy> Pharmacies { get; set; }
        public static List<Schedule> Schedules { get; set; }
        public static string Token { get; set; }
        public static bool TokenExist { get; set; }
        public static string CurrentUser{ get; set; }
        public static string MedNames { get; set; }
    }
}
