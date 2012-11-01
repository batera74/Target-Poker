using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetPoker.Data
{
    public class DataPlayer : Model.IDataPlayer
    {
        public void Save(Model.Player player)
        {
            using (DataContext context = new DataContext())
            {
                if (player.Id == 0)
                {
                    context.Players.Add(player);
                }
                else
                {
                    context.Entry(player).State = EntityState.Modified;
                }

                context.SaveChanges();
            }
        }

        public Model.Players GetAllPlayers()
        {
            using (DataContext context = new DataContext())
            {
                var query = context.Players.OrderBy(p => p.Name);

                if (query.Count() > 0)
                    return new Model.Players(query);
            }

            return new Model.Players();
        }

        public Model.Player GetPlayer(Guid globalId)
        {
            using (DataContext context = new DataContext())
            {
                return context.Players.FirstOrDefault(p => p.GlobalId == globalId);
            }
        }
    }
}
