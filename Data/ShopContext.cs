using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class ShopContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Sale> Sales { get; set; }

        public ShopContext(DbContextOptions<ShopContext> options) : base(options) { }
    }
}
