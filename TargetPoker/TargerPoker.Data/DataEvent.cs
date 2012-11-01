using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetPoker.Data
{
    public class DataEvent : Model.IDataEvent
    {
        public void Save(Model.Event _event)
        {
            throw new NotImplementedException();
        }

        public Model.Events GetAllEvents()
        {
            throw new NotImplementedException();
        }

        public Model.Event GetEvent(Guid globalId)
        {
            throw new NotImplementedException();
        }
    }
}
