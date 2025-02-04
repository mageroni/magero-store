using magero_store.Models;

namespace magero_store.Data
{
    public static class SampleData
    {
        public static List<Product> Products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Classic T-Shirt",
                Description = "Comfortable cotton t-shirt in various colors",
                Price = 19.99M,
                ImageUrl = "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab"
            },
            new Product
            {
                Id = 2,
                Name = "Designer Jeans",
                Description = "High-quality denim jeans with perfect fit",
                Price = 59.99M,
                ImageUrl = "https://images.unsplash.com/photo-1542272604-787c3835535d"
            },
            new Product
            {
                Id = 3,
                Name = "Running Shoes",
                Description = "Lightweight and durable running shoes",
                Price = 89.99M,
                ImageUrl = "https://images.unsplash.com/photo-1542291026-7eec264c27ff"
            }
        };
    }
}
