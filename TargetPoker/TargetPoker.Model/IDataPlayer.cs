using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetPoker.Model
{
    public interface IDataPlayer
    {
        void Save(Player player);

        Players GetAllPlayers();

        Player GetPlayer(Guid globalId);
    }
}
