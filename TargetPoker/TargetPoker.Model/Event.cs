using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetPoker.Model
{
    public class Event
    {
        public Event()
        {
            this.GlobalId = Guid.NewGuid();
            this.Players = new EventsPlayers();
        }

        public int Id { get; set; }

        public EventType EventType { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public string Place { get; set; }

        public decimal BuyIn { get; set; }

        public decimal Rake { get; set; }

        public int MinPlayers { get; set; }

        public int MaxPlayers { get; set; }

        public EventsPlayers Players { get; set; }

        public Guid GlobalId { get; set; }
    }
}
