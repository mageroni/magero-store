using Microsoft.AspNetCore.Mvc;
using magero_store.Data;
using magero_store.Models;

namespace magero_store.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var products = SampleData.Products;
            return View(products);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}