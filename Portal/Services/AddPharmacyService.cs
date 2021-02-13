using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portal.Models;
using Portal.Repository;

namespace Portal.Services
{
    public class AddPharmacyService:IAddPharmacyService
    {
        private readonly IAddPharmacyRepository _addPharmacyRepository;
        public AddPharmacyService(IAddPharmacyRepository addPharmacyRepository)
        {
            _addPharmacyRepository = addPharmacyRepository;
        }
        public void AddToDb(List<Pharmacy> pharmacies, DataContext dataContext)
        {
            _addPharmacyRepository.AddToDb(pharmacies, dataContext);
        }
        public List<Pharmacy> GetFromDb(DataContext dataContext)
        {
            return _addPharmacyRepository.GetFromDb(dataContext);
        }
    }
}
