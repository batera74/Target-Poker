using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TargetPoker.Dados.AcessoDados
{
    public class Jogador
    {
        public List<DTO.Jogador> CarregarTodos()
        {
            using (var _ctx = new Dados.targetpokerEntities())
            {
                var jogadores = from j in _ctx.jogador.Include("evento_jogador")
                                select new DTO.Jogador
                                {
                                    Id = j.id_jogador,
                                    Nome = j.nm_jogador,
                                    Sobrenome = j.nm_sobrenome_jogador,
                                    Nascimento = j.dt_nascimento,
                                    Email = j.ds_email,
                                    TargetTeam = j.ic_target_team,
                                    Torneios = j.evento_jogador,
                                    EventosDisputados = j.evento_jogador.Count()
                                };

                foreach (var item in jogadores)
                {
                    ObterPontuacao(item);
                    ObterEstrelas(item);
                }

                return jogadores.ToList();
            }
        }

        private void ObterPontuacao(DTO.Jogador jogador)
        {
            int pontos = 0;
            int melhor_posicao = 0;

            foreach (var item in jogador.Torneios)
            {
                pontos += item.qt_pontos;

                if (melhor_posicao < item.ds_posicao_evento)
                    melhor_posicao = item.ds_posicao_evento;
            }

            jogador.Pontos = pontos;
            jogador.MelhorPosicaoEvento = melhor_posicao;

        }

        private void ObterEstrelas(DTO.Jogador jogador)
        {
            if ((jogador.Pontos / jogador.EventosDisputados) >= 9)
                jogador.Entrelas = 5;
            else if ((jogador.Pontos / jogador.EventosDisputados) >= 8)
                jogador.Entrelas = 4.5M;
            else if ((jogador.Pontos / jogador.EventosDisputados) >= 7)
                jogador.Entrelas = 4;
            else if ((jogador.Pontos / jogador.EventosDisputados) >= 6)
                jogador.Entrelas = 3.5M;
            else if ((jogador.Pontos / jogador.EventosDisputados) >= 5)
                jogador.Entrelas = 3;
            else if ((jogador.Pontos / jogador.EventosDisputados) >= 4)
                jogador.Entrelas = 2.5M;
            else if ((jogador.Pontos / jogador.EventosDisputados) >= 3)
                jogador.Entrelas = 2;
            else if ((jogador.Pontos / jogador.EventosDisputados) >= 2)
                jogador.Entrelas = 1.5M;
            else if ((jogador.Pontos / jogador.EventosDisputados) >= 1)
                jogador.Entrelas = 1;
            else if ((jogador.Pontos / jogador.EventosDisputados) >= 0.5)
                jogador.Entrelas = 0.5M;
            else
                jogador.Entrelas = 0;
        }
    }
}
