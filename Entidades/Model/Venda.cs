using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Model
{
    public class Venda
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VendaId { get; set; }
        public DateTime Data_Venda { get; set; }
        public DateTime Data_Entrega { get; set; }

        public Produto Produto { get; set; }

    }
}
