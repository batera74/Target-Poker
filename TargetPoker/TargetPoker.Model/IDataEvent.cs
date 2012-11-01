using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetPoker.Model
{
    public interface IDataEvent
    {
        void Save(Event _event);

        Events GetAllEvents();

        Event GetEvent(Guid globalId);
    }
}
