using Portal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Services
{
    public interface IAddPharmacyService
    {
        public void AddToDb(List<Pharmacy> pharmacies, DataContext dataContext);
        public List<Pharmacy> GetFromDb(DataContext dataContext);
    }
}
