using ControleDeClientes.Interfaces.Repositories;
using ControleDeClientes.Interfaces.Servicos;
using ControleDeClientes.Repositories;
using ControleDeClientes.Servicos;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeClientes.Ioc
{
    public static class InjetoDeDependencias
    {
        public static void Injetar(IServiceCollection services)
        {
            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddTransient<IClienteRepository, ClienteRepository>();
            services.AddTransient<IEnderecoRepository, EnderecoRepository>();
            services.AddTransient<IPedidoRepository, PedidoRepository>();

            services.AddTransient(typeof(IBaseServico<>), typeof(BaseServico<>));
            services.AddTransient<IServicoCliente, ServicoCliente>();
            services.AddTransient<IServicoEndereco, ServicoEndereco>();
            services.AddTransient<IServicoPedido, ServicoPedido>();
        }
    }
}
