using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Model
{
    public class Avaliacoes
    {
        public int ID { get; set; }
        public string Avaliacao { get; set; }
        public DateTime? AvaliacaoDate { get; set; }

        public Venda Venda { get; set; }

    }
}
