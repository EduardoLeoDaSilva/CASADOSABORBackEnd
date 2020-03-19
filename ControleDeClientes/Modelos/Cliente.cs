using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeClientes.Modelos
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public Endereco Endereco { get; set; }

        [JsonIgnore]
        public List<Pedido> Pedidos { get; set; }


        public Cliente()
        {

        }

        public Cliente(string nome, string telefone, Endereco endereco)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
        }
    }
}
