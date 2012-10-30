using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TargetPoker.Entidade;

namespace TargetPoker.Dados
{
    public class Jogador : IData<Entidade.Jogador>
    {
        /*public List<Entidade.Jogador> CarregarTodos()
        {

            using (var _ctx = new Dados.targetpokerEntities())
            {
                var jogadores = from j in _ctx.jogador.Include("evento_jogador")
                                select new Entidade.Jogador
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
        }*/
        
        public void Salvar(Entidade.Jogador entidade)
        {

            using (DataContext context = new DataContext())
            {
                if (entidade.Id == 0)
                {                    
                    foreach (var evento in entidade.Eventos)
                    {
                        context.Entry(evento).State = EntityState.Unchanged;
                    }

                    context.Jogadores.Add(entidade);
                }
                else
                {
                    var jogador = context.Jogadores.Include("Eventos").Where(b => b.Id == entidade.Id).Single();

                    UpdateBookAuthors(book.Authors.Select(a => a.Id).ToArray(), bookToUpdate, context);

                    jogador.Nome = entidade.Nome;
                    jogador.Sobrenome = entidade.Sobrenome;
                    jogador.Nascimento = entidade.Nascimento;
                    jogador.Email = entidade.Email;
                    jogador.TargetTeam = entidade.TargetTeam;
                    jogador.Pontos = entidade.Pontos;
                    jogador.Estrelas = entidade.Estrelas;
                    jogador.MelhorPosicaoEvento = entidade.MelhorPosicaoEvento;
                    jogador.EventosDisputados = entidade.EventosDisputados;
                    
                    context.Entry(jogador).State = EntityState.Modified;
                }

                context.SaveChanges();
            }
        }

        private void AtualizarEventos(int[] enventosSelecionados, Entidade.Jogador jogador, DataContext context)
        {
            if (enventosSelecionados == null)
            {
                jogador.Eventos = new Entidade.EventosJogadores();
                return;
            }

            var selEventos = new HashSet<int>(enventosSelecionados);
            var jogEventos = new HashSet<int>(jogador.Eventos.Select(a => a.Id));

            foreach (var evento in context.Eventos)
            {
                if (selEventos.Contains(evento.Id))
                {
                    if (!jogEventos.Contains(evento.Id))
                    {
                        //jogador.Eventos.Add(author);
                        context.Entry(evento).State = EntityState.Modified;
                    }
                    else
                    {
                        context.Entry(evento).State = EntityState.Unchanged;
                    }
                }
                else
                {
                    if (jogEventos.Contains(evento.Id))
                    {
                        //jogador.Eventos.Remove(author);
                    }
                }
            }
        }

        public Entidade.Jogador Selecionar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Entidade.Jogador> SelecionarTodos()
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Entidade.Jogador entidade)
        {
            throw new NotImplementedException();
        }

        #region [ Métodos Privados ]


        private void ObterPontuacao(Entidade.Jogador jogador)
        {
            int pontos = 0;
            int melhor_posicao = 0;

            foreach (var item in jogador.Eventos)
            {
                pontos += item.Pontuacao;

                if (melhor_posicao < item.Posicao)
                    melhor_posicao = item.Posicao;
            }

            jogador.Pontos = pontos;
            jogador.MelhorPosicaoEvento = melhor_posicao;

        }

        private void ObterEstrelas(Entidade.Jogador jogador)
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

        #endregion
    }
}
