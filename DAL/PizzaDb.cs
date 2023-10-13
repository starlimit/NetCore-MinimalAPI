using Microsoft.EntityFrameworkCore;
using PizzaStore_Min_API.Models;

namespace PizzaStore_Min_API.DAL
{
    public class PizzaDb : DbContext
    {
        public PizzaDb(DbContextOptions options) : base(options) { }

        public DbSet<Pizza> Pizzas { get; set; } = null!;
    }
}
