using Entidades.Model;
using Negocio.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Service
{
    public class FacadeClass
    {
        private readonly IProduto _daoProduto;

        public FacadeClass(IProduto _produtoDao)
        {
            _daoProduto = _produtoDao;
        }

        public List<Produto> TodosOsProdutos()
        {
            return _daoProduto.todos();
        }
    
        public void AdicionaProduto(Produto prod)
        {
            _daoProduto.adicionarProduto(prod);
        }

        public void addReview(Faq rev)
        {
            _daoProduto.addReview(rev);
        }

        public void Comprar(Venda venda)
        {
            _daoProduto.Comprar(venda); 
        }
    }
}
