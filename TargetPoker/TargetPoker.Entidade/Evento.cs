using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TargetPoker.Entidade
{
    public class Evento
    {
        public int Id { get; set; }
        public TipoEvento TipoEvento { get; set; }
        public DateTime Data { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Local { get; set; }
        public decimal BuyIn { get; set; }
        public decimal Rake { get; set; }
        public int QuantidadeMinimaJogadores { get; set; } 
        public int QuantidadeMaximaJogadores { get; set; }
        public EventosJogadores Jogadores { get; set; }
    }
}
