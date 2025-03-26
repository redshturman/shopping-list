using Microsoft.EntityFrameworkCore;
using shopping_list.Models.Database;

namespace shopping_list.Modules
{
    public class ShoppingListDbContext : DbContext
    {
        public ShoppingListDbContext(DbContextOptions<ShoppingListDbContext> options) : base(options)
        {
        }
        public DbSet<Products> Products { get; set; }
    }
}
