using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persistencia.Entitys
{
    internal class Faq
    {
        public int ID { get; set; }
        public string descricao { get; set; }
        //imagem aqui
        public DateTime DateFaq { get; set; }
    }
}
