using ControleDeClientes.Interfaces.Repositories;
using ControleDeClientes.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeClientes.Repositories
{
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        private readonly ApplicationContext _context;

        public PedidoRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

        public override void Cadastrar(Pedido entidade)
        {
            var clienteBanco = _context.Set<Cliente>().Find(entidade.Cliente.Id);
            entidade.Cliente = clienteBanco;
            _context.Set<Pedido>().Add(entidade);
            _context.SaveChanges();
        }

        public override List<Pedido> ObterTodos()
        {
           var listaPedido =  _context.Set<Pedido>().Include(x => x.Cliente).ThenInclude(x => x.Endereco).ToList();
            return listaPedido;
        }

        public  List<Pedido> ObterTodosPedidosVendidosMes(int mes, int ano)
        {
            var pedisoVendidosMes = _context.Set<Pedido>().Where(x => x.Data.Month == mes && x.Data.Year == ano).ToList();
            return pedisoVendidosMes;
        }
    }
}
