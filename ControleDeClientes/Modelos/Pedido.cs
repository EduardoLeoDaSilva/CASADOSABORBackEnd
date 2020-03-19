using ControleDeClientes.Modelos.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeClientes.Modelos
{
    public class Pedido
    {
        public int Id { get; set; }

        public int Quantidade { get; set; }

        public DateTime Data { get; set; }

        
        public Cliente Cliente { get; set; }

        public StatusPedidoEnum Status { get; set; }


        public Pedido()
        {

        }

        public Pedido(int id, int quantidade, DateTime data, Cliente cliente)
        {
            Id = id;
            Quantidade = quantidade;
            Data = data;
            Cliente = cliente;
        }
    }
}
