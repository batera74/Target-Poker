using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TargetPoker.Model
{
    [Serializable]
    public class Players : List<Player>
    {
        public Players()
            : base()
        {
        }

        public Players(IEnumerable<Player> players)
            : base(players)
        {
        }
    }
}
