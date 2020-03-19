using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeClientes.Interfaces.Servicos
{
    public interface IBaseServico<Entidade>
    {

        void Cadastrar(Entidade entidade);

        void Atualizar(Entidade entidade);

        void Deletar(int id);

        Entidade ObterPeloId(int id);


        List<Entidade> ObterTodos();

    }
}
