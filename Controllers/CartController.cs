using Microsoft.AspNetCore.Mvc;
using magero_store.Models;
using System.Collections.Generic;
using System.Linq;
using magero_store.Helpers;
using magero_store.Data;

namespace magero_store.Controllers
{
    public class CartController : Controller
    {
        private readonly Data.ApplicationDbContext _context;

        public CartController(Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var cartItems = GetCartItems();
            
            return View(cartItems);
        }

        public IActionResult AddToCart(int productId)
        {
            var product = _context.Products.Find(productId);
            if (product == null)
            {
                return NotFound();
            }

            var cartItems = GetCartItems();
            var cartItem = cartItems.FirstOrDefault(ci => ci.ProductId == productId);

            if (cartItem == null)
            {
                cartItems.Add(new CartItem { ProductId = productId, Quantity = 1, Product = product });
            }
            else
            {
                cartItem.Quantity++;
            }

            SaveCartItems(cartItems);
            return RedirectToAction("Index");
        }

        public IActionResult RemoveFromCart(int productId)
        {
            var cartItems = GetCartItems();
            var cartItem = cartItems.FirstOrDefault(ci => ci.ProductId == productId);

            if (cartItem != null)
            {
                cartItems.Remove(cartItem);
            }

            SaveCartItems(cartItems);
            return RedirectToAction("Index");
        }

        public IActionResult Checkout()
        {
            var cartItems = GetCartItems();
            if (!cartItems.Any())
            {
                return RedirectToAction("Index", "Home");
            }

            return View(cartItems);
        }

        private List<CartItem> GetCartItems()
        {
            return HttpContext.Session.Get<List<CartItem>>("Cart") ?? new List<CartItem>();
        }

        private void SaveCartItems(List<CartItem> cartItems)
        {
            HttpContext.Session.Set("Cart", cartItems);
        }
    }
}