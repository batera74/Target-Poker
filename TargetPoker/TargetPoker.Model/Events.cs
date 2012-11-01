using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TargetPoker.Model
{
    [Serializable]
    public class Events : List<Event>
    {
        public Events()
            : base()
        {
        }

        public Events(IEnumerable<Event> events)
            : base(events)
        {
        }
    }
}
