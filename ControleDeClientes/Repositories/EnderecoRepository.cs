using ControleDeClientes.Interfaces.Repositories;
using ControleDeClientes.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeClientes.Repositories
{
    public class EnderecoRepository : BaseRepository<Endereco>, IEnderecoRepository
    {
        private readonly ApplicationContext _context;
        public EnderecoRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }
    }
}
