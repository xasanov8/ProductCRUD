using Microsoft.EntityFrameworkCore;

namespace Product.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product.API.Models.Product> Products { get; set; }
    }
}
