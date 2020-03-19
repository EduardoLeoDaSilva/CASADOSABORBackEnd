using ControleDeClientes.Interfaces.Repositories;
using ControleDeClientes.Interfaces.Servicos;
using ControleDeClientes.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeClientes.Servicos
{
    public class ServicoEndereco : BaseServico<Endereco>, IServicoEndereco
    {
        private readonly IEnderecoRepository _enderecoRepository;
        public ServicoEndereco(IEnderecoRepository enderecoRepository) : base(enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }


    
    }
}
