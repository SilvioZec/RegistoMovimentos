using Microsoft.EntityFrameworkCore;
using RegistoMovimentos.Business_data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistoMovimentos.Persistence
{
    internal class DBWorker : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Movimento> Movimentos { get; set; }
        public DbSet<Tipo_movimento> Tipos_movimento { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define o tipo de coluna para a propriedade Valor na tabela de Movimento
            modelBuilder.Entity<Movimento>()
                .Property(m => m.Valor)
                .HasColumnType("decimal(18,2)");

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=62.28.39.135,62444;Initial Catalog=MovimentosSilvio;User ID=EFASILVIO;Password=zechin031294;Trust server certificate = true;");
        }

    }
}
