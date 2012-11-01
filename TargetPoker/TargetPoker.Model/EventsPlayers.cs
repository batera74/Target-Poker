using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetPoker.Model
{
    [Serializable]
    public class EventsPlayers : List<EventPlayer>
    {
        public EventsPlayers()
            : base()
        {
        }

        public EventsPlayers(IEnumerable<EventPlayer> eventsPlayers)
            : base(eventsPlayers)
        {
        }
    }
}
