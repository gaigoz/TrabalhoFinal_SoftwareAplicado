using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Model
{
    public class Faq
    {
        public int FaqID { get; set; }
        public string Coment { get; set; }
        // nao vai ter imagem
        public String User { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
    }
}
