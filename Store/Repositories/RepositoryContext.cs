using Entities.Models;
using Microsoft.EntityFrameworkCore;
namespace Repositories;


public class RepositoryContext : DbContext
{
    public DbSet<Product> Products { get; set; }
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().
            HasData(
                new Product { ProductId = 1, ProductName = "Computer", Price = 17_000 },
                new Product { ProductId = 2, ProductName = "Keyboard", Price = 300 },
                new Product { ProductId = 3, ProductName = "Mouse", Price = 400 },
                new Product { ProductId = 4, ProductName = "Headphones", Price = 1_200 },
                new Product { ProductId = 5, ProductName = "Monitor", Price = 3_000 }
            );
        }
}
