using Microsoft.AspNetCore.Mvc;
using magero_store.Models;
using magero_store.Data;
using Microsoft.Data.SqlClient;  // Changed from System.Data.SqlClient
using Dapper;
using System.Linq;

namespace magero_store.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IConfiguration _configuration;

        public ProductsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            ViewBag.Categories = SampleData.Products
                .Select(p => p.Category)
                .Distinct()
                .ToList();
            return View(SampleData.Products);
        }

        public IActionResult Details(int id)
        {
            var product = SampleData.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        /// <summary>
        /// Busca productos por término de búsqueda en los datos de muestra.
        /// </summary>
        /// <param name="searchTerm">El término de búsqueda.</param>
        /// <returns>Vista con los productos encontrados.</returns>
        public IActionResult Search(string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
                return View("Index", SampleData.Products);

            var products = SampleData.Products
                .Where(p => p.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                           p.Description.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                .ToList();

            ViewBag.Categories = SampleData.Products
                .Select(p => p.Category)
                .Distinct()
                .ToList();

            return View("Index", products);
        }

        /// <summary>
        /// Filtra productos por categoría.
        /// </summary>
        /// <param name="category">La categoría a filtrar.</param>
        /// <returns>Lista de productos filtrados.</returns>
        public IActionResult FilterByCategory(string category)
        {
            var products = string.IsNullOrEmpty(category) 
                ? SampleData.Products 
                : SampleData.Products.Where(p => p.Category == category).ToList();
            return Json(products);
        }
    }
}