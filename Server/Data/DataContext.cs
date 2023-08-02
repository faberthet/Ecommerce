

using BlazorEcommerce.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Books",
                    Url = "books"
                },
                new Category
                  {
                    Id = 2,
                    Name = "Movies",
                    Url = "movies"
                  },
                new Category
                  {
                    Id = 3,
                    Name = "Video Games",
                    Url = "video-games"
                  }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "product1",
                    Description = "description ...",
                    ImageUrl = "https://d12ggcde3o3sl5.cloudfront.net/assets/images/memogame.jpg",
                    Price = 9.99m,
                    CategoryId=1
                },
                new Product
                {
                    Id = 2,
                    Name = "product2",
                    Description = "description ...",
                    ImageUrl = "https://d12ggcde3o3sl5.cloudfront.net/assets/images/meteo.jpg",
                    Price = 8.85m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Name = "product3",
                    Description = "description ...",
                    ImageUrl = "https://d12ggcde3o3sl5.cloudfront.net/assets/images/blog.jpg",
                    Price = 5.49m,
                    CategoryId = 1
                }
                    );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
