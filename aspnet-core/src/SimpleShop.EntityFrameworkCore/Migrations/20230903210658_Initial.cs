using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleShop.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "識別ID"),
                    Name = table.Column<string>(type: "nvarchar(20)", nullable: false, comment: "標籤名稱"),
                    Creator = table.Column<string>(type: "nvarchar(20)", nullable: true, comment: "建立者"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "建立日期"),
                    Updator = table.Column<string>(type: "nvarchar(20)", nullable: true, comment: "更新者"),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "更新日期")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "識別ID"),
                    Code = table.Column<string>(type: "nvarchar(20)", nullable: false, comment: "代碼"),
                    Name = table.Column<string>(type: "nvarchar(20)", nullable: false, comment: "名稱"),
                    Birth = table.Column<string>(type: "nvarchar(10)", nullable: false, comment: "生日"),
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: false, comment: "信箱"),
                    Password = table.Column<string>(type: "nvarchar(1000)", nullable: false, comment: "密碼"),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false, comment: "第一次登入"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, comment: "已註銷")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Goods",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "識別ID"),
                    Name = table.Column<string>(type: "nvarchar(20)", nullable: false, comment: "商品名稱"),
                    Category = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "商品標籤"),
                    Price = table.Column<decimal>(type: "decimal(10,0)", nullable: false, comment: "價錢"),
                    Quantity = table.Column<int>(type: "int", nullable: false, comment: "數量"),
                    Creator = table.Column<string>(type: "nvarchar(20)", nullable: true, comment: "建立者"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "建立日期"),
                    Updator = table.Column<string>(type: "nvarchar(20)", nullable: true, comment: "更新者"),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "更新日期")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Goods_Categories_Category",
                        column: x => x.Category,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "識別ID"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "購買者"),
                    TotalPrice = table.Column<decimal>(type: "decimal(10,0)", nullable: false, comment: "總價格"),
                    Creator = table.Column<string>(type: "nvarchar(20)", nullable: true, comment: "建立者"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "建立日期"),
                    Updator = table.Column<string>(type: "nvarchar(20)", nullable: true, comment: "更新者"),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "更新日期"),
                    Deletor = table.Column<string>(type: "nvarchar(20)", nullable: true, comment: "刪除者"),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "刪除日期")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "識別ID"),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "訂單ID"),
                    GoodName = table.Column<string>(type: "nvarchar(20)", nullable: false, comment: "商品名稱"),
                    GoodPrice = table.Column<decimal>(type: "decimal(10,0)", nullable: false, comment: "商品價格")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Name",
                table: "Categories",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Goods_Category",
                table: "Goods",
                column: "Category");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_Name_Category",
                table: "Goods",
                columns: new[] { "Name", "Category" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Id_UserId",
                table: "Orders",
                columns: new[] { "Id", "UserId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Id_Code_Email",
                table: "Users",
                columns: new[] { "Id", "Code", "Email" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Goods");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
