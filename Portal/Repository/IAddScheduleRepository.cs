using Portal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Repository
{
    public interface IAddScheduleRepository
    {
        public void AddToDb(List<Schedule> schedules, DataContext dataContext);
        public List<Schedule> GetFromDb(DataContext dataContext);
    }
}
