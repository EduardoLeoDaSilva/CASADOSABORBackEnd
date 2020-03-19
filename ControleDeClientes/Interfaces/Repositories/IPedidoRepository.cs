using ControleDeClientes.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeClientes.Interfaces.Repositories
{
    public interface IPedidoRepository : IBaseRepository<Pedido>
    {
        List<Pedido> ObterTodosPedidosVendidosMes(int mes, int ano);
    }
}
