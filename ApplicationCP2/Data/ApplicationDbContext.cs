using Microsoft.EntityFrameworkCore;
using ApplicationCP2.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace ApplicationCP2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Loja> Loja { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle("Data Source=oracle.fiap.com.br:1521/orcl;User ID=rm98959;Password=071100;");
        }
    }
}
