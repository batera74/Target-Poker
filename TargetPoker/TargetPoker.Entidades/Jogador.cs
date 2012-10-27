using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TargetPoker.Entidades
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
        public ICollection<Dados.torneio_jogador> Torneios { get; set; }
        public int MelhorPosicaoTorneio { get; set; }
        public int TorneioDisputados { get; set; }
    }
}
