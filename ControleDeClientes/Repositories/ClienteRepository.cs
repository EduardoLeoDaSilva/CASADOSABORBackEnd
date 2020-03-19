using ControleDeClientes.Interfaces.Repositories;
using ControleDeClientes.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeClientes.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        private readonly ApplicationContext _context;
        public ClienteRepository(ApplicationContext context): base(context)
        {
            _context = context;
        }

        public Cliente ObterPeloNome(string nome)
        {
            var cliente = _context.Set<Cliente>().Where(x => x.Nome == nome).Include(x => x.Endereco).Include(x => x.Pedidos).SingleOrDefault();
            return cliente;
        }

        public Cliente ObterPeloTel(string tel)
        {
            var cliente = _context.Set<Cliente>().Where(x => x.Telefone == tel).Include(x => x.Endereco).Include(x => x.Pedidos).SingleOrDefault();
            return cliente;
        }

        public List<Cliente> ObterPeloNomeV2(string nome)
        {
            var clienteLista = _context.Set<Cliente>().Where(x => x.Nome.Contains(nome)|| x.Telefone == nome).Include(x => x.Endereco).Include(x => x.Pedidos).ToList();
            return clienteLista;
        }
    }
}
