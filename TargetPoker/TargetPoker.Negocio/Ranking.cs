using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TargetPoker.Negocio
{
    public class Ranking
    {
        private Dados.targetpokerEntities _ctx;

        public Ranking()
        {
            _ctx = new Dados.targetpokerEntities();
        }

        public List<Entidades.Jogador> Carregar()
        {
            var jogadores = from j in _ctx.jogador
                            select new Entidades.Jogador
                            {
                                Id = j.id_jogador,
                                Nome = j.nm_jogador,
                                Sobrenome = j.nm_sobrenome_jogador,
                                Nascimento = j.dt_nascimento,
                                Email = j.ds_email,
                                TargetTeam = j.ic_target_team,
                                Torneios = j.torneio_jogador,
                                TorneioDisputados = j.torneio_jogador.Count()
                            };

            foreach (var item in jogadores)
            {
                ObterPontuacao(item);
                ObterEstrelas(item);
            }

            return jogadores.ToList();
        }

        private void ObterPontuacao(Entidades.Jogador jogador)
        {
            int pontos = 0;
            int melhor_posicao = 0;

            foreach (var item in jogador.Torneios)
            {                
                pontos += item.qt_pontos;

                if (melhor_posicao < item.ds_posicao_torneio)
                    melhor_posicao = item.ds_posicao_torneio;
            }

            jogador.Pontos = pontos;
            jogador.MelhorPosicaoTorneio = melhor_posicao;

        }

        private void ObterEstrelas(Entidades.Jogador jogador)
        {
            if ((jogador.Pontos / jogador.TorneioDisputados) >= 9)
                jogador.Entrelas = 5;
            else if ((jogador.Pontos / jogador.TorneioDisputados) >= 8)
                jogador.Entrelas = 4.5M;
            else if ((jogador.Pontos / jogador.TorneioDisputados) >= 7)
                jogador.Entrelas = 4;
            else if ((jogador.Pontos / jogador.TorneioDisputados) >= 6)
                jogador.Entrelas = 3.5M;
            else if ((jogador.Pontos / jogador.TorneioDisputados) >= 5)
                jogador.Entrelas = 3;
            else if ((jogador.Pontos / jogador.TorneioDisputados) >= 4)
                jogador.Entrelas = 2.5M;
            else if ((jogador.Pontos / jogador.TorneioDisputados) >= 3)
                jogador.Entrelas = 2;
            else if((jogador.Pontos / jogador.TorneioDisputados) >= 2)
                jogador.Entrelas = 1.5M;
            else if((jogador.Pontos / jogador.TorneioDisputados) >= 1)
                jogador.Entrelas = 1;
            else if((jogador.Pontos / jogador.TorneioDisputados) >= 0.5)
                jogador.Entrelas = 0.5M;
            else
                jogador.Entrelas = 0;
        }
    }
}
