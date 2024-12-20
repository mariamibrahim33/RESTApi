using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace RESTApi.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AdventureWorksDbContext>
    {
        public AdventureWorksDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AdventureWorksDbContext>();
            optionsBuilder.UseSqlite("Data Source=AdventureWorks.db"); // SQLite connection string
            return new AdventureWorksDbContext(optionsBuilder.Options);
        }
    }
}
