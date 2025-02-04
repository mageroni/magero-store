using Microsoft.EntityFrameworkCore;
using magero_store.Models;

namespace magero_store.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Gaming Laptop",
                    Description = "High-performance gaming laptop with RTX 3080",
                    Price = 1999.99m,
                    ImageUrl = "https://images.unsplash.com/photo-1603302576837-37561b2e2302"
                },
                new Product
                {
                    Id = 2,
                    Name = "Wireless Earbuds",
                    Description = "Premium wireless earbuds with noise cancellation",
                    Price = 199.99m,
                    ImageUrl = "https://images.unsplash.com/photo-1590658087412-d1d9f559ef20"
                },
                new Product
                {
                    Id = 3,
                    Name = "4K Monitor",
                    Description = "32-inch 4K HDR Professional Monitor",
                    Price = 699.99m,
                    ImageUrl = "https://images.unsplash.com/photo-1527443224154-c4a3942d3acf"
                },
                new Product
                {
                    Id = 4,
                    Name = "Mechanical Keyboard",
                    Description = "RGB Mechanical Gaming Keyboard",
                    Price = 159.99m,
                    ImageUrl = "https://images.unsplash.com/photo-1595225476474-87563907a212"
                },
                new Product
                {
                    Id = 5,
                    Name = "Gaming Mouse",
                    Description = "Wireless Gaming Mouse with 25K DPI",
                    Price = 129.99m,
                    ImageUrl = "https://images.unsplash.com/photo-1527864550417-7fd91fc51a46"
                }
            );
        }
    }
}
