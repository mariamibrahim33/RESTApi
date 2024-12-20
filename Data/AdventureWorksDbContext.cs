using Microsoft.EntityFrameworkCore;

namespace RESTApi.Data
{
    public class AdventureWorksDbContext : DbContext
    {
        public AdventureWorksDbContext(DbContextOptions<AdventureWorksDbContext> options) : base(options) { }

        // DbSet to interact with Product table
        public DbSet<Product> Products { get; set; } = null!;
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
    }
}


