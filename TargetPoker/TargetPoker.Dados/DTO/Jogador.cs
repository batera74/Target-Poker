using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TargetPoker.Dados.DTO
{
    public class Jogador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Email { get; set; }
        public bool TargetTeam { get; set; }
        public int Pontos { get; set; }
        public decimal Entrelas { get; set; }
        public ICollection<Dados.evento_jogador> Torneios { get; set; }
        public int MelhorPosicaoEvento { get; set; }
        public int EventosDisputados { get; set; }
    }
}
