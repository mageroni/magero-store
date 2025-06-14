using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using magero_store.Models;
using magero_store.Data;

namespace magero_store.Controllers
{
    public class ProductsController : Controller
    {
        private readonly Data.ApplicationDbContext _context;

        /// <summary>
        /// Inicializa una nueva instancia del controlador de productos.
        /// </summary>
        /// <param name="context">Contexto de base de datos.</param>
        public ProductsController(Data.ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Muestra la lista de productos con filtros opcionales.
        /// </summary>
        /// <param name="searchTerm">Término de búsqueda.</param>
        /// <param name="categoryId">ID de categoría para filtrar.</param>
        /// <returns>Vista con la lista de productos.</returns>
        public async Task<IActionResult> Index(string searchTerm, int? categoryId)
        {
            var products = _context.Products.Include(p => p.Category).AsQueryable();

            if (categoryId.HasValue)
            {
                products = products.Where(p => p.CategoryId == categoryId.Value);
            }

            if (!string.IsNullOrEmpty(searchTerm))
            {
                products = products.Where(p => p.Name.Contains(searchTerm) || p.Description.Contains(searchTerm));
            }

            ViewBag.Categories = await _context.Categories.ToListAsync();
            ViewBag.SelectedCategoryId = categoryId;

            return View(await products.ToListAsync());
        }

        /// <summary>
        /// Muestra los detalles de un producto específico.
        /// </summary>
        /// <param name="id">ID del producto.</param>
        /// <returns>Vista con los detalles del producto.</returns>
        public async Task<IActionResult> Details(int id)
        {
            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(p => p.Id == id);
            
            if (product == null)
            {
                return NotFound();
            }
            
            return View(product);
        }

        /// <summary>
        /// Busca productos por término de búsqueda usando Entity Framework.
        /// </summary>
        /// <param name="searchTerm">Término de búsqueda.</param>
        /// <returns>Vista con los resultados de búsqueda.</returns>
        public async Task<IActionResult> Search(string searchTerm)
        {
            var products = await _context.Products
                .Include(p => p.Category)
                .Where(p => p.Name.Contains(searchTerm) || p.Description.Contains(searchTerm))
                .ToListAsync();

            ViewBag.Categories = await _context.Categories.ToListAsync();
            return View("Index", products);
        }
    }
}