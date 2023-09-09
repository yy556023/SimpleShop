using Microsoft.EntityFrameworkCore;
using SimpleShop.Domain.Categories;
using SimpleShop.Domain.Functions;
using SimpleShop.Domain.Goods;
using SimpleShop.Domain.OrderDetails;
using SimpleShop.Domain.Orders;
using SimpleShop.Domain.Users;

namespace SimpleShop.EntityFrameworkCore
{
    public static class SimpleShopDbContextCreatingExtension
    {
        public static void ConfigureSimpleShop(this ModelBuilder builder)
        {
            builder.Entity<User>(b =>
            {
                b.ToTable("Users");

                b.Property(user => user.Id).HasColumnName(nameof(User.Id)).HasComment("識別ID");
                b.Property(user => user.Code).HasColumnName(nameof(User.Code)).HasComment("代碼").HasColumnType("nvarchar(20)");
                b.Property(user => user.Name).HasColumnName(nameof(User.Name)).HasComment("名稱").HasColumnType("nvarchar(20)");
                b.Property(user => user.Birth).HasColumnName(nameof(User.Birth)).HasComment("生日").HasColumnType("nvarchar(10)");
                b.Property(user => user.Email).HasColumnName(nameof(User.Email)).HasComment("信箱").HasColumnType("nvarchar(50)");
                b.Property(user => user.Password).HasColumnName(nameof(User.Password)).HasComment("密碼").HasColumnType("nvarchar(1000)");
                b.Property(user => user.IsDefault).HasColumnName(nameof(User.IsDefault)).HasComment("第一次登入");
                b.Property(user => user.IsDelete).HasColumnName(nameof(User.IsDelete)).HasComment("已註銷");
                b.Property(user => user.Creator).HasColumnName(nameof(User.Creator)).HasComment("建立者").HasColumnType("nvarchar(20)");
                b.Property(user => user.CreateDate).HasColumnName(nameof(User.CreateDate)).HasComment("建立日期");
                b.Property(user => user.Updator).HasColumnName(nameof(User.Updator)).HasComment("更新者").HasColumnType("nvarchar(20)");
                b.Property(user => user.UpdateDate).HasColumnName(nameof(User.UpdateDate)).HasComment("更新日期");
                b.Property(user => user.Deletor).HasColumnName(nameof(User.Deletor)).HasComment("刪除者").HasColumnType("nvarchar(20)");
                b.Property(user => user.DeleteDate).HasColumnName(nameof(User.DeleteDate)).HasComment("刪除日期");

                b.HasMany<Order>().WithOne().HasForeignKey(order => order.UserId);

                b.HasIndex(user => new
                {
                    user.Id,
                    user.Code,
                    user.Email
                }).IsUnique();
            });

            builder.Entity<Function>(b =>
            {
                b.ToTable("Functions");

                b.Property(function => function.Id).HasColumnName(nameof(Function.Id)).HasComment("識別ID");
                b.Property(function => function.UserId).HasColumnName(nameof(Function.UserId)).HasComment("使用者ID");
                b.Property(function => function.Name).HasColumnName(nameof(Function.Name)).HasComment("名稱").HasColumnType("nvarchar(50)");
                b.Property(function => function.DisplayName).HasColumnName(nameof(Function.DisplayName)).HasComment("顯示名稱").HasColumnType("nvarchar(20)");

                b.HasMany<User>().WithOne().HasForeignKey(user => user.Id);

                b.HasIndex(function => new {
                    function.Id,
                    function.UserId
                }).IsUnique();
            });

            builder.Entity<Good>(b =>
            {
                b.ToTable("Goods");

                b.Property(good => good.Id).HasColumnName(nameof(Good.Id)).HasComment("識別ID");
                b.Property(good => good.Name).HasColumnName(nameof(Good.Name)).HasComment("商品名稱").HasColumnType("nvarchar(20)");
                b.Property(good => good.Category).HasColumnName(nameof(Good.Category)).HasComment("商品標籤");
                b.Property(good => good.Price).HasColumnName(nameof(Good.Price)).HasComment("價錢").HasColumnType("decimal(10,0)");
                b.Property(good => good.Quantity).HasColumnName(nameof(Good.Quantity)).HasComment("數量").HasColumnType("int");
                b.Property(good => good.Creator).HasColumnName(nameof(Good.Creator)).HasComment("建立者").HasColumnType("nvarchar(20)");
                b.Property(good => good.CreateDate).HasColumnName(nameof(Good.CreateDate)).HasComment("建立日期");
                b.Property(good => good.Updator).HasColumnName(nameof(Good.Updator)).HasComment("更新者").HasColumnType("nvarchar(20)");
                b.Property(good => good.UpdateDate).HasColumnName(nameof(Good.UpdateDate)).HasComment("更新日期");

                b.HasOne<Category>().WithMany().HasForeignKey(good => good.Category);

                b.HasIndex(good => new
                {
                    good.Name,
                    good.Category
                }).IsUnique();
            });

            builder.Entity<Category>(b =>
            {
                b.ToTable("Categories");

                b.Property(category => category.Id).HasColumnName(nameof(Category.Id)).HasComment("識別ID");
                b.Property(category => category.Name).HasColumnName(nameof(Category.Name)).HasComment("標籤名稱").HasColumnType("nvarchar(20)");
                b.Property(category => category.Creator).HasColumnName(nameof(Category.Creator)).HasComment("建立者").HasColumnType("nvarchar(20)");
                b.Property(category => category.CreateDate).HasColumnName(nameof(Category.CreateDate)).HasComment("建立日期");
                b.Property(category => category.Updator).HasColumnName(nameof(Category.Updator)).HasComment("更新者").HasColumnType("nvarchar(20)");
                b.Property(category => category.UpdateDate).HasColumnName(nameof(Category.UpdateDate)).HasComment("更新日期");

                b.HasMany<Good>().WithOne().HasForeignKey(good => good.Category);

                b.HasIndex(category => category.Name).IsUnique();
            });

            builder.Entity<Order>(b =>
            {
                b.ToTable("Orders");

                b.Property(order => order.Id).HasColumnName(nameof(Order.Id)).HasComment("識別ID");
                b.Property(order => order.UserId).HasColumnName(nameof(Order.UserId)).HasComment("購買者");
                b.Property(order => order.TotalPrice).HasColumnName(nameof(Order.TotalPrice)).HasComment("總價格").HasColumnType("decimal(10,0)");
                b.Property(order => order.Creator).HasColumnName(nameof(Order.Creator)).HasComment("建立者").HasColumnType("nvarchar(20)");
                b.Property(order => order.CreateDate).HasColumnName(nameof(Order.CreateDate)).HasComment("建立日期");
                b.Property(order => order.Updator).HasColumnName(nameof(Order.Updator)).HasComment("更新者").HasColumnType("nvarchar(20)");
                b.Property(order => order.UpdateDate).HasColumnName(nameof(Order.UpdateDate)).HasComment("更新日期");
                b.Property(order => order.Deletor).HasColumnName(nameof(Order.Deletor)).HasComment("刪除者").HasColumnType("nvarchar(20)");
                b.Property(order => order.DeleteDate).HasColumnName(nameof(Order.DeleteDate)).HasComment("刪除日期");

                b.HasOne<User>().WithMany().HasForeignKey(order => order.UserId);
                b.HasMany<OrderDetail>().WithOne().HasForeignKey(od => od.OrderId);

                b.HasIndex(order => new
                {
                    order.Id,
                    order.UserId
                }).IsUnique();
            });

            builder.Entity<OrderDetail>(b =>
            {
                b.ToTable("OrderDetails");

                b.Property(od => od.Id).HasColumnName(nameof(OrderDetail.Id)).HasComment("識別ID");
                b.Property(od => od.OrderId).HasColumnName(nameof(OrderDetail.OrderId)).HasComment("訂單ID");
                b.Property(od => od.GoodName).HasColumnName(nameof(OrderDetail.GoodName)).HasComment("商品名稱").HasColumnType("nvarchar(20)");
                b.Property(od => od.GoodPrice).HasColumnName(nameof(OrderDetail.GoodPrice)).HasComment("商品價格").HasColumnType("decimal(10,0)");

                b.HasOne<Order>().WithMany().HasForeignKey(od => od.OrderId);

                b.HasIndex(od => od.OrderId).IsUnique();
            });
        }
    }
}