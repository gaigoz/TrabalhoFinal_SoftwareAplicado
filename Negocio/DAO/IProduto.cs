using Entidades.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.DAO
{
    public interface IProduto
    {
        List<Produto> todos();
        Produto adicionarProduto(Produto prod);
        Produto getPrudotoPorID(int id);


    }
}
