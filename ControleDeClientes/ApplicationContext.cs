using ControleDeClientes.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeClientes
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasKey(x => x.Id);
            modelBuilder.Entity<Endereco>().HasKey(x => x.Id);
            modelBuilder.Entity<Pedido>().HasKey(x => x.Id);

            modelBuilder.Entity<Cliente>().ToTable("Clientes");
            modelBuilder.Entity<Endereco>().ToTable("Enderecos");
            modelBuilder.Entity<Pedido>().ToTable("Pedidos");

            modelBuilder.Entity<Cliente>().HasOne(x => x.Endereco).WithOne(x => x.Cliente).HasForeignKey<Endereco>(x => x.Id).HasConstraintName("ClienteId");
            modelBuilder.Entity<Cliente>().HasMany(x => x.Pedidos).WithOne(x => x.Cliente);
        }
    }
}
