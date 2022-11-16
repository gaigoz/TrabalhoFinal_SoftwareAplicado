using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Model
{

    public enum Status
    {
        EmVenda, Vendido, Disponivel, D, F
    }
    public class Produto
    {       
        public int ID { get; set; }
        public Status? Status { get; set; }
        public string Name { get; set; }
        //titulo do produto?
        //colocar imagem
        public string Description { get; set; }
        public string Local { get; set; }
        public decimal Price { get; set; }
        public DateTime Dt_Inclusion { get; set; }

        //entidades

        // precisa desses Ids?
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

            public List<Faq> Faq { get; set; }
    }
}
