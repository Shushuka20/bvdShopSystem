using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class ShopContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ShopContext(DbContextOptions<ShopContext> options) : base(options) { }
    }
}
