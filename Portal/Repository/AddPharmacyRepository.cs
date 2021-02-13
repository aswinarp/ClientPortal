using Portal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Repository
{
    public class AddPharmacyRepository:IAddPharmacyRepository
    {
        public void AddToDb(List<Pharmacy> pharmacies,DataContext dataContext)
        {
            for (int i = 0; i < pharmacies.Count; i++)
            {
                var itemToRemove = dataContext.Pharmacies.FirstOrDefault(x => x.User == GlobalData.CurrentUser);
                if (itemToRemove != null)
                {
                    dataContext.Pharmacies.Remove(itemToRemove);
                    dataContext.SaveChanges();
                }
            }

            foreach (var item in pharmacies)
                dataContext.Pharmacies.Add(new PharmacyDB { User = GlobalData.CurrentUser, PharmacyName = item.PharmacyName, MedicineName = string.Join(',', item.MedicineName.ToArray()), SupplyCount = string.Join(',', item.SupplyCount.ToArray()) });
            dataContext.SaveChanges();
        }

        public List<Pharmacy> GetFromDb(DataContext dataContext)
        {
            List<Pharmacy> pharmacies = new List<Pharmacy>();
            var itemFromDb = dataContext.Pharmacies.Where(x => x.User == GlobalData.CurrentUser).ToList();
            foreach(var item in itemFromDb)
            {
                pharmacies.Add(new Pharmacy { PharmacyName = item.PharmacyName, MedicineName = item.MedicineName.Split(',').ToList(), SupplyCount = item.SupplyCount.Split(',').ToList().Select(s => int.Parse(s)).ToList() });
            }
            return pharmacies;
        }

    }
}
