using Microsoft.EntityFrameworkCore;
using persistencia.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persistencia.Data
{
    internal class EComerceContext : DbContext
    {
        public EComerceContext(DbContextOptions<EComerceContext> options) : base(options)
        {
            //todo - criar contexto no banco de dados
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Venda>.HasMany(object => object.Produto)
            // como montar?
            //modelBuilder.Seed();
        }

        public DbSet<Produto> Produtos { get; set;}
        public DbSet<Categoria> Categorias { get; set;}
        public DbSet<Venda> Vendas { get; set;}
        public DbSet<Avaliacoes> Avaliacoes { get; set;}
        public DbSet<Faq> Faqs { get; set; }

    }
}
