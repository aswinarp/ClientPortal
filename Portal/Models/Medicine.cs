using System;

namespace Portal.Models
{
    public class Medicine
    {
        public string Name { get; set; }
        public string[] ChemicalComposition { get; set; }
        public string TargetAilment { get; set; }
        public DateTime DateOfExpiry { get; set; }
        public int NumberOfTabletsInStock { get; set; }
    }
}
