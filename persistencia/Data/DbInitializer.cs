using Entidades.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persistencia.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ShopContext context)
        {

            context.Database.EnsureCreated();

            //--------------------------------------//
            if (context.Produtos.Any())
            {
                return;   // DB has been seeded
            }

            var produtos = new Produto[] {

                new Produto {CategoriaId = 1, FaqId = 1, Status = Status.Disponivel, Name = "Bicicleta", Description = "Bike para trilha de terra", Price = 200, Dt_Inclusion = DateTime.Parse("2005-09-01") }

            };

            foreach (Produto s in produtos)
            {
                context.Produtos.Add(s);
            }
            //--------------------------------------//
            if (context.Categorias.Any())
            {
                return;   // DB has been seeded
            }

            var categorias = new Categoria[]
            {
                new Categoria
                {
                 Descricao = "Lazer",Tipo="tipo da categoria"
                }
            };

            foreach (Categoria s in categorias)
            {
                context.Categorias.Add(s);
            }
            //--------------------------------------//
            if (context.Faqs.Any())
            {
                return;   // DB has been seeded
            }

            var faqs = new Faq[]
            {
                new Faq
                {
                    Descricao = "anda na lama?", DateFaq=DateTime.Parse("2005-09-01")
                }
            };

            foreach (Faq s in faqs)
            {
                context.Faqs.Add(s);
            }
            //--------------------------------------//

            context.SaveChanges();
        }
    }
}
