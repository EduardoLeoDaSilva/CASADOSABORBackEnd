using ControleDeClientes.Interfaces.Repositories;
using ControleDeClientes.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeClientes.Servicos
{
    public class BaseServico<Entidade> : IBaseServico<Entidade>
    {
        private readonly IBaseRepository<Entidade> _baseRepository;
        public BaseServico(IBaseRepository<Entidade> baseRepository)
        {
            _baseRepository =  baseRepository;
        }

        public void Atualizar(Entidade entidade)
        {
            _baseRepository.Atualizar(entidade);
        }

        public void Cadastrar(Entidade entidade)
        {
            _baseRepository.Cadastrar(entidade);

        }

        public void Deletar(int id)
        {
            _baseRepository.Deletar(id);

        }

        public Entidade ObterPeloId(int id)
        {
            return _baseRepository.ObterPeloId(id);
        }

        public List<Entidade> ObterTodos()
        {
            return _baseRepository.ObterTodos();
        }
    }
}
