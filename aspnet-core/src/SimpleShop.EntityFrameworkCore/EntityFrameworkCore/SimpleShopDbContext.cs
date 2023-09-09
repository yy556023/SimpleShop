using Microsoft.EntityFrameworkCore;
using SimpleShop.Domain.Categories;
using SimpleShop.Domain.Functions;
using SimpleShop.Domain.Goods;
using SimpleShop.Domain.OrderDetails;
using SimpleShop.Domain.Orders;
using SimpleShop.Domain.Users;

namespace SimpleShop.EntityFrameworkCore
{
    public class SimpleShopDbContext : DbContext
    {
        public SimpleShopDbContext(DbContextOptions<SimpleShopDbContext> options)
         : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Good> Goods { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Function> Functions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureSimpleShop();
        }
    }
}