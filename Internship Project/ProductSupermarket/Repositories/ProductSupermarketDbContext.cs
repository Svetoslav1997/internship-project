using ProductSupermarket.Entities;
using System.Data.Entity;

namespace ProductSupermarket.Repositories
{
    public class ProductSupermarketDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        public ProductSupermarketDbContext()
            : base("AssignmentManagerDb")
        {

        }
    }
}
