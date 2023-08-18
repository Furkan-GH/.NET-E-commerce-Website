using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Utility
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<FastFoodDetail> FastFoodDetail { get; set;}
        public DbSet<JunkFoodDetail> JunkFoodDetail { get;set; }
        public DbSet<CleaningDetail> CleaningDetail { get; set; }
        public DbSet<ToysDetail> ToysDetail { get; set; }
        public DbSet<Order> Order { get; set; }





    }
}
