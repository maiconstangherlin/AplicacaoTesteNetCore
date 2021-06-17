using ApiTeste.Model;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiTeste.Context
{
    public class PessoaContext : DbContext
    {

        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Teste;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>(
                i =>
                {
                    i.ToTable("Pessoas");
                    
                    i.HasKey(f => f.Id);
                    i.Property(f => f.Id).ValueGeneratedOnAdd();
                });           
        }

    }
}
