using Microsoft.AspNetCore.Mvc;
using magero_store.Models;
using magero_store.Data;
using System.Data.SqlClient;
using Dapper;

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

        // WARNING: This is deliberately vulnerable to SQL injection!
        public IActionResult Search(string searchTerm)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                // Vulnerable code: Direct string concatenation in SQL query
                var sql = "SELECT * FROM Products WHERE Name LIKE '%" + searchTerm + "%' OR Description LIKE '%" + searchTerm + "%'";
                var products = connection.Query<Product>(sql).ToList();
                return View("Index", products);
            }
        }
    }
}