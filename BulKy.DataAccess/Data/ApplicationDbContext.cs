using BulkyBook.Models;

using Microsoft.EntityFrameworkCore;

namespace BulkyBook.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Duy", DisplayOrder = 4 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Fortune of time",
                    Author = "Billy Spark",
                    Description = "Description",
                    ISBM = "SWD99901",
                    ListPrice = 199,
                    Price = 99,
                    Price50 = 66,
                    Price100 = 100
                },

                 new Product
                 {
                     Id = 2,
                     Title = "The Great Adventure",
                     Author = "Alice Wonderland",
                     Description = "A thrilling adventure story",
                     ISBM = "ABC12345",
                     ListPrice = 109,
                     Price = 59.99,
                     Price50 = 45.99,
                     Price100 = 39.99
                 },
                new Product
                {
                    Id = 3,
                    Title = "Cooking Mastery",
                    Author = "Chef Gordon Ramsay",
                    Description = "A cookbook for aspiring chefs",
                    ISBM = "XYZ67890",
                    ListPrice = 399,
                    Price = 79.99,
                    Price50 = 65.99,
                    Price100 = 59.99
                },
                new Product
                {
                    Id = 4,
                    Title = "History Unveiled",
                    Author = "Historian Jane Smith",
                    Description = "A journey through history",
                    ISBM = "DEF54321",
                    ListPrice = 239,
                    Price = 49.99,
                    Price50 = 39.99,
                    Price100 = 34.99
                },
                new Product
                {
                    Id = 5,
                    Title = "Science Explained",
                    Author = "Dr. John Doe",
                    Description = "An introduction to science",
                    ISBM = "PQR98765",
                    ListPrice = 189,
                    Price = 69.99,
                    Price50 = 55.99,
                    Price100 = 49.99
                }

                );
        }


    }
}
