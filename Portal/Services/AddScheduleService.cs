using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portal.Models;
using Portal.Repository;

namespace Portal.Services
{
    public class AddScheduleService:IAddScheduleService
    {
        private readonly IAddScheduleRepository _addScheduleRepository;
        public AddScheduleService(IAddScheduleRepository addScheduleRepository)
        {
            _addScheduleRepository = addScheduleRepository;
        }

        public void AddToDb(List<Schedule> schedules, DataContext dataContext)
        {
            _addScheduleRepository.AddToDb(schedules, dataContext);
        }

        public List<Schedule> GetFromDb(DataContext dataContext)
        {
            return _addScheduleRepository.GetFromDb(dataContext);
        }
    }
}
