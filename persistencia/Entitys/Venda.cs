using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persistencia.Entitys
{
    internal class Venda
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public DateTime Data_Venda { get; set; }
        public DateTime Data_Entrega { get; set; }

    }
}
