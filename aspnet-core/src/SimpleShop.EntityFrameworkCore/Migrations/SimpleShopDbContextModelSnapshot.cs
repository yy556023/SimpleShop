﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimpleShop.EntityFrameworkCore;

#nullable disable

namespace SimpleShop.EntityFrameworkCore.Migrations
{
    [DbContext(typeof(SimpleShopDbContext))]
    partial class SimpleShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SimpleShop.Domain.Categories.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id")
                        .HasComment("識別ID");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreateDate")
                        .HasComment("建立日期");

                    b.Property<string>("Creator")
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Creator")
                        .HasComment("建立者");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Name")
                        .HasComment("標籤名稱");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdateDate")
                        .HasComment("更新日期");

                    b.Property<string>("Updator")
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Updator")
                        .HasComment("更新者");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Categories", (string)null);
                });

            modelBuilder.Entity("SimpleShop.Domain.Goods.Good", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id")
                        .HasComment("識別ID");

                    b.Property<Guid>("Category")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Category")
                        .HasComment("商品標籤");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreateDate")
                        .HasComment("建立日期");

                    b.Property<string>("Creator")
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Creator")
                        .HasComment("建立者");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Name")
                        .HasComment("商品名稱");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10,0)")
                        .HasColumnName("Price")
                        .HasComment("價錢");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("Quantity")
                        .HasComment("數量");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdateDate")
                        .HasComment("更新日期");

                    b.Property<string>("Updator")
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Updator")
                        .HasComment("更新者");

                    b.HasKey("Id");

                    b.HasIndex("Category");

                    b.HasIndex("Name", "Category")
                        .IsUnique();

                    b.ToTable("Goods", (string)null);
                });

            modelBuilder.Entity("SimpleShop.Domain.OrderDetails.OrderDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id")
                        .HasComment("識別ID");

                    b.Property<string>("GoodName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("GoodName")
                        .HasComment("商品名稱");

                    b.Property<decimal>("GoodPrice")
                        .HasColumnType("decimal(10,0)")
                        .HasColumnName("GoodPrice")
                        .HasComment("商品價格");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("OrderId")
                        .HasComment("訂單ID");

                    b.HasKey("Id");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("OrderDetails", (string)null);
                });

            modelBuilder.Entity("SimpleShop.Domain.Orders.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id")
                        .HasComment("識別ID");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreateDate")
                        .HasComment("建立日期");

                    b.Property<string>("Creator")
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Creator")
                        .HasComment("建立者");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeleteDate")
                        .HasComment("刪除日期");

                    b.Property<string>("Deletor")
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Deletor")
                        .HasComment("刪除者");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(10,0)")
                        .HasColumnName("TotalPrice")
                        .HasComment("總價格");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdateDate")
                        .HasComment("更新日期");

                    b.Property<string>("Updator")
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Updator")
                        .HasComment("更新者");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UserId")
                        .HasComment("購買者");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("Id", "UserId")
                        .IsUnique();

                    b.ToTable("Orders", (string)null);
                });

            modelBuilder.Entity("SimpleShop.Domain.Users.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id")
                        .HasComment("識別ID");

                    b.Property<string>("Birth")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("Birth")
                        .HasComment("生日");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Code")
                        .HasComment("代碼");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Email")
                        .HasComment("信箱");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit")
                        .HasColumnName("IsDefault")
                        .HasComment("第一次登入");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit")
                        .HasColumnName("IsDelete")
                        .HasComment("已註銷");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Name")
                        .HasComment("名稱");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("Password")
                        .HasComment("密碼");

                    b.HasKey("Id");

                    b.HasIndex("Id", "Code", "Email")
                        .IsUnique();

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("SimpleShop.Domain.Goods.Good", b =>
                {
                    b.HasOne("SimpleShop.Domain.Categories.Category", null)
                        .WithMany()
                        .HasForeignKey("Category")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SimpleShop.Domain.OrderDetails.OrderDetail", b =>
                {
                    b.HasOne("SimpleShop.Domain.Orders.Order", null)
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SimpleShop.Domain.Orders.Order", b =>
                {
                    b.HasOne("SimpleShop.Domain.Users.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
