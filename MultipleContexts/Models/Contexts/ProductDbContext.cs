using Microsoft.EntityFrameworkCore;

namespace MultipleContexts.Models.Contexts
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(SeedProducts);
        }

        private static readonly Product[] SeedProducts =
        {
            new() { Id = Guid.NewGuid(), Name = "Product One", Price = 111, Stock = 1, CreatedDate = DateTime.UtcNow },
            new() { Id = Guid.NewGuid(), Name = "Product Two", Price = 222, Stock = 2, CreatedDate = DateTime.UtcNow },
            new() { Id = Guid.NewGuid(), Name = "Product Three", Price = 333, Stock = 3, CreatedDate = DateTime.UtcNow },
            new() { Id = Guid.NewGuid(), Name = "Product Four", Price = 444, Stock = 4, CreatedDate = DateTime.UtcNow },
            new() { Id = Guid.NewGuid(), Name = "Product Five", Price = 555, Stock = 5, CreatedDate = DateTime.UtcNow },
            new() { Id = Guid.NewGuid(), Name = "Product Six", Price = 666, Stock = 6, CreatedDate = DateTime.UtcNow },
            new() { Id = Guid.NewGuid(), Name = "Product Seven", Price = 777, Stock = 7, CreatedDate = DateTime.UtcNow },
            new() { Id = Guid.NewGuid(), Name = "Product Eight", Price = 888, Stock = 8, CreatedDate = DateTime.UtcNow },
            new() { Id = Guid.NewGuid(), Name = "Product Nine", Price = 999, Stock = 9, CreatedDate = DateTime.UtcNow }
        };
    }
}
