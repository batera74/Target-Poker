using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetPoker.Data
{
    public class DataEvent : Model.IDataEvent
    {
        public void Save(Model.Event _event)
        {
            using (DataContext context = new DataContext())
            {
                if (_event.Id == 0)
                {
                    context.Events.Add(_event);
                }
                else
                {
                    context.Entry(_event).State = EntityState.Modified;
                }

                context.SaveChanges();
            }
        }

        public Model.Events GetAllEvents()
        {
            using (DataContext context = new DataContext())
            {
                var query = context.Events.OrderBy(e => e.Date);

                if (query.Count() > 0)
                    return new Model.Events(query);
            }

            return new Model.Events();
        }

        public Model.Event GetEvent(Guid globalId)
        {
            using (DataContext context = new DataContext())
            {
                return context.Events.FirstOrDefault(e => e.GlobalId == globalId);
            }
        }
    }
}
