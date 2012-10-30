using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetPoker.Entidade
{
    public class EventoJogador
    {
        public int Id { get; set; }
        public Evento Evento { get; set; }
        public Jogador Jogador { get; set; }
        public int Posicao { get; set; }
        public int Pontuacao { get; set; }
    }
}
