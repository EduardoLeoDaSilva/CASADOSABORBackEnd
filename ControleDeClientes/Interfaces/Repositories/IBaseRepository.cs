using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeClientes.Interfaces.Repositories
{
    public interface IBaseRepository<Entidade>
    {
        void Cadastrar(Entidade entidade);
        void Atualizar(Entidade entidade);
        Entidade ObterPeloId(int id);
        List<Entidade> ObterTodos();

        void Deletar(int id);
    }
}
