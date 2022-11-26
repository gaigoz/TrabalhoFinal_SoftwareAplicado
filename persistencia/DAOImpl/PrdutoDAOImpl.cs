using Entidades.Model;
using Microsoft.EntityFrameworkCore;
using Negocio.DAO;
using persistencia.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persistencia.DAOImpl
{
    public class PrdutoDAOImpl : IProduto
    {
        private readonly ShopContext _shopContext;

        public PrdutoDAOImpl()
        {
            _shopContext = new ShopContext();
        }


        public Produto adicionarProduto(Produto produto)
        {

            _shopContext.Add(produto);
            _shopContext.SaveChanges();
            return produto;

        }

        public Produto getPrudotoPorID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Produto> todos()
        {
           return _shopContext.Produtos.ToList<Produto>();
        }
    }
}
