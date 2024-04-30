using Microsoft.EntityFrameworkCore;
using NorthwindInventoryAPI.Models;

namespace NorthwindInventoryAPI.Data
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext(DbContextOptions<NorthwindContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
    }
}
