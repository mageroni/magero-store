using Microsoft.AspNetCore.Mvc;
using magero_store.Models;
using magero_store.Data;

namespace magero_store.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
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
    }
}