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
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace WebShop.Controllers
{
    public class VendasController : Controller
    {
        private readonly ShopContext _context;

        private readonly FacadeClass _negocio;

        public readonly UserManager<ApplicationUser> _userManager;

        public VendasController(FacadeClass negocio, ShopContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
            _negocio = negocio;
        }

        // GET: VendasController
        public ActionResult Index()
        {
            if (_context.Vendas == null)
            {
                return Problem("Entity set 'MvcMovieContext.Movie'  is null.");
            }

            var movies = from m in _context.Vendas
                         select m;
            return View(movies);
        }


    }


}
