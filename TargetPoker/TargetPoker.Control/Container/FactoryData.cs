using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TargetPoker.Control.Container
{
    internal class FactoryData
    {
        public static Model.IDataEvent GetEventsRepository()
        {
            return new Data.DataEvent();
        }

        public static Model.IDataPlayer GetPlayerRepository()
        {
            return new Data.DataPlayer();
        }
    }
}
