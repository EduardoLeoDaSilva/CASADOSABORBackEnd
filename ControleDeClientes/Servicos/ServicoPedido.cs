using ControleDeClientes.Interfaces.Repositories;
using ControleDeClientes.Interfaces.Servicos;
using ControleDeClientes.Modelos;
using ControleDeClientes.Modelos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeClientes.Servicos
{
    public class ServicoPedido : BaseServico<Pedido>, IServicoPedido
    {
        private readonly IPedidoRepository _pedidoRepository;
        public ServicoPedido(IPedidoRepository pedidoRepository) :base(pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }


        public List<Pedido> ObterOrdensDePedidoDeUmadata(DateTime data)
        {
            var dateAtual = DateTime.Today;
           var pedidosDoDia = _pedidoRepository.ObterTodos().Where(x => x.Data == data);
            return pedidosDoDia.ToList();
        }

        public int ObterQuantidadeDePedidoPelaData(DateTime data)
        {
            var pedidosMesLista = _pedidoRepository.ObterTodosPedidosVendidosMes(data.Month, data.Year);
            var total = 0;
            foreach (var item in pedidosMesLista)
            {
                total += item.Quantidade;
            }
            return total;
        }

        public void SetarStatusPedido(Pedido pedido)
        {
            var pedidoBanco = _pedidoRepository.ObterPeloId(pedido.Id);
            if(pedidoBanco == null)
            {
                throw new NullReferenceException("Não existe esse pedido no sistema");
            }
            pedidoBanco.Status = pedido.Status;
            this.Atualizar(pedidoBanco);
        }

    }
}
