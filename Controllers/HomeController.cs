using Microsoft.AspNetCore.Mvc;
using magero_store.Data;
using magero_store.Models;

namespace magero_store.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Muestra la página principal con una lista de productos.
        /// </summary>
        /// <returns>Vista con la lista de productos.</returns>
        public IActionResult Index()
        {
            var products = SampleData.Products;
            return View(products);
        }

        /// <summary>
        /// Muestra la página de error.
        /// </summary>
        /// <returns>Vista de error.</returns>
        public IActionResult Error()
        {
            return View();
        }
    }
}