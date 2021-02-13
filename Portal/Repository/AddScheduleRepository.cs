using Portal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Repository
{
    public class AddScheduleRepository:IAddScheduleRepository
    {
        public void AddToDb(List<Schedule> schedules, DataContext dataContext)
        {
            for (int i = 0; i < schedules.Count; i++)
            {
                var itemToRemove = dataContext.Schedules.FirstOrDefault(x => x.User == GlobalData.CurrentUser);
                if (itemToRemove != null)
                {
                    dataContext.Schedules.Remove(itemToRemove);
                    dataContext.SaveChanges();
                }
            }
            foreach (var item in schedules)
                dataContext.Schedules.Add(new ScheduleDB { User = GlobalData.CurrentUser, DocName = item.DocName, RepName = item.RepName, Ailment = item.Ailment, Medicine = string.Join(',', item.Medicine.ToArray()), Time = item.Time, Date = item.Date, Mobile = item.Mobile });
            dataContext.SaveChanges();
        }

        public List<Schedule> GetFromDb(DataContext dataContext)
        {
            List<Schedule> schedules = new List<Schedule>();
            var itemFromDb = dataContext.Schedules.Where(x => x.User == GlobalData.CurrentUser).ToList();
            foreach (var item in itemFromDb)
            {
                schedules.Add(new Schedule { Ailment = item.Ailment, RepName = item.RepName, DocName = item.DocName, Date = item.Date, Mobile = item.Mobile, Time = item.Time, Medicine = item.Medicine.Split(',').ToList() });
            }
            return schedules;
        }
    }
}
