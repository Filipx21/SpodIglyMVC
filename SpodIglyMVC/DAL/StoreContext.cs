using SpodIglyMVC.Models;
using System.Data.Entity;

namespace SpodIglyMVC.DAL
{
    public class StoreContext : DbContext
    {
        public StoreContext() : base("StoreContext") { }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

    }
}