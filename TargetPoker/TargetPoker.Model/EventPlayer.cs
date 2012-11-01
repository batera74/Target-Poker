using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetPoker.Model
{
    public class EventPlayer
    {
        public EventPlayer()
        {
            this.GlobalId = new Guid();
        }

        public int Id { get; set; }

        public int EventId { get; set; }

        public int PlayerId { get; set; }

        public Event Event { get; set; }

        public Player Player { get; set; }

        public int Position { get; set; }

        public int Points { get; set; }

        public Guid GlobalId { get; set; }        
    }
}
