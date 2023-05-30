using Microsoft.EntityFrameworkCore;

namespace BurgerRestaurant.Data
{
    public class BurgerContext : DbContext
    {
        public BurgerContext(DbContextOptions<BurgerContext> options) : base(options) {}

        public DbSet<BurgerRestaurant.Models.Burger> Burgers { get; set; }
    }
}
