using CD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.Business.Contexto
{
    public class EFContexto : DbContext
    {
        public EFContexto(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<Cliente> Cliente { get; internal set; }
        public DbSet<Funcionario> Funcionario { get; internal set; }
        public DbSet<Vendas> Vendas { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=luan;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            optionsBuilder.UseLazyLoadingProxies();
        }


    }
}
