using ControleDeClientes.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeClientes.Interfaces.Servicos
{
    public interface IServicoCliente : IBaseServico<Cliente>
    {
        Cliente ObterPeloNome(string endereco);
        Cliente ObterPeloTel(string tel);
        List<Cliente> ObterPeloNomeV2(string nome);
    }
}
