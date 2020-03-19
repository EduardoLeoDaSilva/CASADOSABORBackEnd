using ControleDeClientes.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeClientes.Interfaces.Servicos
{
    public interface IServicoPedido: IBaseServico<Pedido>
    {
        List<Pedido> ObterOrdensDePedidoDeUmadata(DateTime data);
        int ObterQuantidadeDePedidoPelaData(DateTime data);

        void SetarStatusPedido(Pedido pedido);

    }
}
