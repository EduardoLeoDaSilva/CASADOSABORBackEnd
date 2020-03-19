using ControleDeClientes.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeClientes.Repositories
{
    public class BaseRepository<Entidade> : IBaseRepository<Entidade> where Entidade : class
    {
        private readonly ApplicationContext _context;
        public BaseRepository(ApplicationContext context)
        {
            _context = context;
        }

        public virtual void Atualizar(Entidade entidade)
        {
            _context.Set<Entidade>().Update(entidade);
            _context.SaveChanges();
        }

        public virtual void Cadastrar(Entidade entidade)
        {
            _context.Set<Entidade>().Add(entidade);
            _context.SaveChanges();
        }

        public virtual void Deletar(int id)
        {
            var entidade = _context.Set<Entidade>().Find(id);
            _context.Set<Entidade>().Remove(entidade);
            _context.SaveChanges();
        }

        public virtual Entidade ObterPeloId(int id)
        {
            var entidade = _context.Set<Entidade>().Find(id);
            return entidade;

        }

        public virtual List<Entidade> ObterTodos()
        {
            return _context.Set<Entidade>().ToList();
        }
    }
}
