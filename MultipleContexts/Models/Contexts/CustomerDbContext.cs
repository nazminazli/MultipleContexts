using Microsoft.EntityFrameworkCore;

namespace MultipleContexts.Models.Contexts
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(SeedCustomers);
        }

        private static readonly Customer[] SeedCustomers =
        {
            new() { Id = Guid.NewGuid(), Name = "Customer One", Surname="Surname One", CreatedDate = DateTime.UtcNow },
            new() { Id = Guid.NewGuid(), Name = "Customer Two", Surname="Surname Two", CreatedDate = DateTime.UtcNow }
        };
    }
}
