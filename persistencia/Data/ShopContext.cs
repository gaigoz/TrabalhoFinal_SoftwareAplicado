using Entidades.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persistencia.Data
{
    public class ShopContext : IdentityDbContext<ApplicationUser>
    {
        public ShopContext()
        {
        }

        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Avaliacoes> Avaliacoes { get; set; }
        public DbSet<Faq> Faqs { get; set; }

        // bd de autenticacao
        public DbSet<ApplicationUser> ApplicationUser { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // associar a PK do Identity
            modelBuilder.Entity<ApplicationUser>().ToTable("AspNetUsers").HasKey(t => t.Id);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                  .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ShopContext;Trusted_Connection=True");
                base.OnConfiguring(optionsBuilder);
            }
        }



    }
}
