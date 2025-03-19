using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;

namespace PadariaProj.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) 
        {

        }

        public DbSet<Vendas> Vendas { get; set; }
        public DbSet<Ingredientes> Ingredientes { get; set; }
        public DbSet<Producao> Producao { get; set; }
        public DbSet<IngredienteVenda> IngredientesVendas { get; set; }
        public DbSet<IngredienteProducao> IngredientesProducoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IngredienteVenda>()
                .HasOne(iv => iv.Venda)
                .WithMany(v => v.IngredientesVendidos)
                .HasForeignKey(iv => iv.VendaId);

            modelBuilder.Entity<IngredienteVenda>()
                .HasOne(iv => iv.Ingrediente)
                .WithMany(i => i.IngredientesVendidos)
                .HasForeignKey(iv => iv.IngredienteId);

            modelBuilder.Entity<IngredienteProducao>()
                .HasOne(ip => ip.Producao)
                .WithMany(p => p.IngredientesUtilizados)
                .HasForeignKey(ip => ip.ProducaoId);

            modelBuilder.Entity<IngredienteProducao>()
                .HasOne(ip => ip.Ingrediente)
                .WithMany()
                .HasForeignKey(ip => ip.IngredienteId);
        }
    }

}

