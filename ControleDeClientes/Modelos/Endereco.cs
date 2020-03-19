using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeClientes.Modelos
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }

        [JsonIgnore]
        public Cliente Cliente { get; set; }


        public Endereco()
        {

        }

        public Endereco(string rua, string numero)
        {
            Rua = rua;
            Numero = numero;
        }
    }
}
