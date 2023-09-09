using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleShop.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class Update_TableSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                comment: "建立日期");

            migrationBuilder.AddColumn<string>(
                name: "Creator",
                table: "Users",
                type: "nvarchar(20)",
                nullable: true,
                comment: "建立者");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                comment: "刪除日期");

            migrationBuilder.AddColumn<string>(
                name: "Deletor",
                table: "Users",
                type: "nvarchar(20)",
                nullable: true,
                comment: "刪除者");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                comment: "更新日期");

            migrationBuilder.AddColumn<string>(
                name: "Updator",
                table: "Users",
                type: "nvarchar(20)",
                nullable: true,
                comment: "更新者");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Functions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "識別ID"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "使用者ID"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false, comment: "名稱"),
                    DisplayName = table.Column<string>(type: "nvarchar(20)", nullable: false, comment: "顯示名稱")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Functions", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Functions_Id_UserId",
                table: "Functions",
                columns: new[] { "Id", "UserId" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Functions_Id",
                table: "Users",
                column: "Id",
                principalTable: "Functions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Functions_Id",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Functions");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Creator",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Deletor",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Updator",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Orders");
        }
    }
}
