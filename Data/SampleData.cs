using magero_store.Models;

namespace magero_store.Data
{
    /// <summary>
    /// Clase estática que contiene datos de ejemplo para la aplicación.
    /// </summary>
    public static class SampleData
    {
        /// <summary>
        /// Lista de productos de ejemplo.
        /// </summary>
        public static List<Product> Products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Laptop",
                Description = "High performance laptop",
                Price = 999.99M,
                ImageUrl = "/images/laptop.jpg",
                Category = CategoryEnum.Electronics
            },
            new Product
            {
                Id = 2,
                Name = "T-Shirt",
                Description = "Cotton T-Shirt",
                Price = 19.99M,
                ImageUrl = "/images/tshirt.jpg",
                Category = CategoryEnum.Clothing
            },
            new Product
            {
                Id = 3,
                Name = "Programming Book",
                Description = "C# Programming Guide",
                Price = 49.99M,
                ImageUrl = "/images/book.jpg",
                Category = CategoryEnum.Books
            },
            new Product
            {
                Id = 4,
                Name = "Leather Jacket",
                Description = "Stylish leather jacket for all seasons",
                Price = 129.99M,
                ImageUrl = "https://images.unsplash.com/photo-1514996937319-344454492b37",
                Category = CategoryEnum.Clothing
            },
            new Product
            {
                Id = 5,
                Name = "Sports Watch",
                Description = "Durable and waterproof sports watch",
                Price = 199.99M,
                ImageUrl = "https://images.unsplash.com/photo-1516574187841-cb9cc2ca948b",
                Category = CategoryEnum.Sports
            },
            new Product
            {
                Id = 6,
                Name = "Sunglasses",
                Description = "UV protection sunglasses with stylish frames",
                Price = 49.99M,
                ImageUrl = "https://images.unsplash.com/photo-1504198453319-5ce911bafcde",
                Category = CategoryEnum.Clothing
            },
            new Product
            {
                Id = 7,
                Name = "Backpack",
                Description = "Spacious and durable backpack for everyday use",
                Price = 79.99M,
                ImageUrl = "https://images.unsplash.com/photo-1514474959185-4c1ad6b9a6a3",
                Category = CategoryEnum.Sports
            },
            new Product
            {
                Id = 8,
                Name = "Smartphone",
                Description = "Latest model smartphone with advanced features",
                Price = 699.99M,
                ImageUrl = "https://images.unsplash.com/photo-1511707171634-5f897ff02aa9",
                Category = CategoryEnum.Electronics
            },
            new Product
            {
                Id = 9,
                Name = "Laptop",
                Description = "High-performance laptop for work and play",
                Price = 999.99M,
                ImageUrl = "https://images.unsplash.com/photo-1517336714731-489689fd1ca8",
                Category = CategoryEnum.Electronics
            },
            new Product
            {
                Id = 10,
                Name = "Headphones",
                Description = "Noise-cancelling over-ear headphones",
                Price = 149.99M,
                ImageUrl = "https://images.unsplash.com/photo-1511367461989-f85a21fda167",
                Category = CategoryEnum.Electronics
            },
            new Product
            {
                Id = 11,
                Name = "Coffee Maker",
                Description = "Automatic coffee maker with programmable settings",
                Price = 89.99M,
                ImageUrl = "https://images.unsplash.com/photo-1509042239860-f550ce710b93",
                Category = CategoryEnum.Home
            },
            new Product
            {
                Id = 12,
                Name = "Blender",
                Description = "High-speed blender for smoothies and shakes",
                Price = 59.99M,
                ImageUrl = "https://images.unsplash.com/photo-1586201375761-83865001b2d7",
                Category = CategoryEnum.Home
            },
            new Product
            {
                Id = 13,
                Name = "Microwave Oven",
                Description = "Compact microwave oven with multiple settings",
                Price = 129.99M,
                ImageUrl = "https://images.unsplash.com/photo-1586201375761-83865001b2d7",
                Category = CategoryEnum.Home
            },
            new Product
            {
                Id = 14,
                Name = "Electric Kettle",
                Description = "Fast-boiling electric kettle with auto shut-off",
                Price = 39.99M,
                ImageUrl = "https://images.unsplash.com/photo-1586201375761-83865001b2d7",
                Category = CategoryEnum.Home
            },
            new Product
            {
                Id = 15,
                Name = "Vacuum Cleaner",
                Description = "Powerful vacuum cleaner with HEPA filter",
                Price = 199.99M,
                ImageUrl = "https://images.unsplash.com/photo-1586201375761-83865001b2d7",
                Category = CategoryEnum.Home
            },
            new Product
            {
                Id = 16,
                Name = "Gaming Console",
                Description = "Next-gen gaming console with 4K support",
                Price = 499.99M,
                ImageUrl = "https://images.unsplash.com/photo-1586201375761-83865001b2d7",
                Category = CategoryEnum.Electronics
            },
            new Product
            {
                Id = 17,
                Name = "Smart TV",
                Description = "Ultra HD smart TV with streaming capabilities",
                Price = 799.99M,
                ImageUrl = "https://images.unsplash.com/photo-1586201375761-83865001b2d7",
                Category = CategoryEnum.Electronics
            },
            new Product
            {
                Id = 18,
                Name = "Tablet",
                Description = "Lightweight tablet with high-resolution display",
                Price = 299.99M,
                ImageUrl = "https://images.unsplash.com/photo-1586201375761-83865001b2d7",
                Category = CategoryEnum.Electronics
            },
            new Product
            {
                Id = 19,
                Name = "Smart Speaker",
                Description = "Voice-controlled smart speaker with AI assistant",
                Price = 99.99M,
                ImageUrl = "https://images.unsplash.com/photo-1586201375761-83865001b2d7",
                Category = CategoryEnum.Electronics
            },
            new Product
            {
                Id = 20,
                Name = "Fitness Tracker",
                Description = "Wearable fitness tracker with heart rate monitor",
                Price = 79.99M,
                ImageUrl = "https://images.unsplash.com/photo-1586201375761-83865001b2d7",
                Category = CategoryEnum.Electronics
            }
        };
    }
}