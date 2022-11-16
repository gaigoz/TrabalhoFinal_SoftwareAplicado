using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Entidades.Model;
using persistencia.Data;
using Negocio.Service;
using Negocio.DAO;
using persistencia.DAOImpl;
using Microsoft.AspNetCore.Authorization;

namespace WebShop.Controllers
{
    
    public class ProdutosController : Controller
    {
        private readonly ShopContext _context;

        private readonly FacadeClass _negocio;

        public ProdutosController(FacadeClass negocio, ShopContext context)
        {
            _context = context;
            _negocio = negocio;
        }

        // GET: Produtos
        public async Task<IActionResult> Index()
        {
            var shopContext = _context.Produtos.Include(p => p.Categoria).Include(p => p.Faq);
            return View(await shopContext.ToListAsync());
        }

        // GET: Produtos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produtos
                .Include(p => p.Categoria)
                .Include(p => p.Faq)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // GET: Produtos/Create
        public IActionResult Create()
        {
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "ID", "ID");
            ViewData["FaqId"] = new SelectList(_context.Faqs, "ID", "ID");
            return View();
        }

        // POST: Produtos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("ID,Status,Name,Description,Local,Price,Dt_Inclusion,CategoriaId,FaqId")] Produto produto)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(produto);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["CategoriaId"] = new SelectList(_context.Categorias, "ID", "ID", produto.CategoriaId);
        //    ViewData["FaqId"] = new SelectList(_context.Faqs, "ID", "ID", produto.FaqId);
        //    return View(produto);
        //}

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,Description,Local,Price")] Produto prod)
        {
            Produto novo = new Produto()
            {
                Name = prod.Name,
                Description = prod.Description,
                Price = prod.Price,
                Local = prod.Local,
            };

            _negocio.AdicionaProduto(novo);

            //return View(prod);

            return RedirectToAction(nameof(Index));
        }

        // GET: Produtos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produtos.FindAsync(id);
            if (produto == null)
            {
                return NotFound();
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "ID", "ID", produto.CategoriaId);
           // ViewData["FaqId"] = new SelectList(_context.Faqs, "ID", "ID", produto.FaqId);
            return View(produto);
        }

        // POST: Produtos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Status,Name,Description,Local,Price,Dt_Inclusion,CategoriaId,FaqId")] Produto produto)
        {
            if (id != produto.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(produto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutoExists(produto.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "ID", "ID", produto.CategoriaId);
          //  ViewData["FaqId"] = new SelectList(_context.Faqs, "ID", "ID", produto.FaqId);
            return View(produto);
        }

        // GET: Produtos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produtos
                .Include(p => p.Categoria)
                .Include(p => p.Faq)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // POST: Produtos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);
            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProdutoExists(int id)
        {
            return _context.Produtos.Any(e => e.ID == id);
        }
    }
}
