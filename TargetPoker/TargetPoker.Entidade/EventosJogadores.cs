using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetPoker.Entidade
{
    public class EventosJogadores : List<EventoJogador>
    {
        public EventosJogadores()
            : base()
        {
        }

        public EventosJogadores(IEnumerable<EventoJogador> eventosJogadores)
            : base(eventosJogadores)
        {
        }
    }
}
