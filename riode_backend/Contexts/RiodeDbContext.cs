using Microsoft.EntityFrameworkCore;
using riode_backend.Models;

namespace riode_backend.Contexts
{
    public class RiodeDbContext : DbContext
    {
        public RiodeDbContext(DbContextOptions<RiodeDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; } = null!;   
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Brand> Brands { get; set; } = null!;
        public DbSet<ProductImage> ProductImages { get; set; } = null!;
    }
}
