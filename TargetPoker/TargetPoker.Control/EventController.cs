using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TargetPoker.Control
{
    public class EventController
    {
        private Model.IDataEvent _dataEvent;

        public EventController()
        {
            this._dataEvent = Container.FactoryData.GetEventsRepository();
        }

        public EventController(Model.IDataEvent dataEvent)
        {
            this._dataEvent = dataEvent;
        }

        public void SaveEvent(Model.Event _event)
        {
            if (_event == null)
                throw new ArgumentNullException("_event");
            if (_event.EventType == null)
                throw new InvalidOperationException("EventType is null");
            if (string.IsNullOrEmpty(_event.Name))
                throw new InvalidOperationException("Name is empty");
            if (string.IsNullOrEmpty(_event.Description))
                throw new InvalidOperationException("Description is empty");  
            if (_event.Date == null)
                throw new InvalidOperationException("Date is null");
            if (string.IsNullOrEmpty(_event.Place))
                throw new InvalidOperationException("Place is empty");
            
            this._dataEvent.Save(_event);
        }

        public Model.Events GetAllEvents()
        {
            return this._dataEvent.GetAllEvents();
        }

        public Model.Event GetEvent(Guid id)
        {
            return this._dataEvent.GetEvent(id);
        }
    }
}
