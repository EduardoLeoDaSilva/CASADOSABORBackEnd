using ControleDeClientes.Interfaces.Repositories;
using ControleDeClientes.Interfaces.Servicos;
using ControleDeClientes.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeClientes.Servicos
{
    public class ServicoCliente : BaseServico<Cliente>, IServicoCliente
    {
        private readonly IClienteRepository _clienteRepository;
        public ServicoCliente(IClienteRepository clienteRepository) : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public Cliente ObterPeloNome(string nome)
        {
            var cliente = _clienteRepository.ObterPeloNome(nome);
            if (cliente != null)
            {
                return cliente;
            }
            throw new Exception("Não existe cliente com esse nome no sistema");
        }

        public Cliente ObterPeloTel(string tel)
        {
            var cliente = _clienteRepository.ObterPeloTel(tel);
            if (cliente != null)
            {
                return cliente;
            }
            throw new Exception("Não existe cliente com esse telefone no sistema");
        }


        public List<Cliente> ObterPeloNomeV2(string nome)
        {
            var clienteLista = _clienteRepository.ObterPeloNomeV2(nome);

            if (nome == "" || nome == null)
            {
                clienteLista.Clear();
                return clienteLista;

            }

            if (clienteLista.Count > 0)
            {
                return clienteLista;

            }


            throw new Exception("Não existe nenhum cliente com esse nome");
        }





    }
}
