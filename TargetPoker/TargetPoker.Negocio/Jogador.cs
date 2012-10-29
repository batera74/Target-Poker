using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TargetPoker.Dados;

namespace TargetPoker.Negocio
{
    public class Jogador
    {
        public List<Dados.DTO.Jogador> CarregarTodos()
        {
            Dados.AcessoDados.Jogador jogadorDados = new Dados.AcessoDados.Jogador();
            return jogadorDados.CarregarTodos();
        }
    }
}
