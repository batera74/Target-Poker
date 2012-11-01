using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetPoker.Model
{
    public class Player
    {
        public Player()
        {
            this.GlobalId = Guid.NewGuid();
            this.Events = new EventsPlayers();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime Birth { get; set; }

        public string Email { get; set; }

        public bool TargetTeam { get; set; }

        public int Points { get { return this.Events.Select(x => x.Points).Sum(); } }

        public decimal Stars { get { return this.GetStars(this.Points, this.Events.Count()); } }

        public EventsPlayers Events { get; set; }

        public int BestEventPosition { get { return this.Events.Min(e => e.Position); } }

        public int EventsPlayed { get { return this.Events.Count(); } }

        public Guid GlobalId { get; set; }

        private decimal GetStars(int points, int events)
        {
            int avgPoints = points / events;

            if (avgPoints > 80)
                return 5;
            if (avgPoints > 75)
                return 4.5M;
            if (avgPoints > 65)
                return 4;
            if (avgPoints > 60)
                return 3.5M;
            if (avgPoints > 50)
                return 3;
            if (avgPoints > 40)
                return 2.5M;
            if (avgPoints > 30)
                return 2;
            if (avgPoints > 20)
                return 1.5M;
            if (avgPoints > 10)
                return 1;
            if (avgPoints > 5)
                return 0.5M;
            else
                return 0;
        }

    }
}
