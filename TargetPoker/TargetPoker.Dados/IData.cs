using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TargetPoker.Dados
{
    public interface IData<T>
    {
        void Salvar(T entidade);
        T Selecionar(int id);
        List<T> SelecionarTodos();
        void Deletar(int id);
        void Deletar(T entidade);

    }
}
