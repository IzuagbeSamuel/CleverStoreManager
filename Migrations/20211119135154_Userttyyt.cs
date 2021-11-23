using Microsoft.EntityFrameworkCore.Migrations;

namespace CleverStoreManager.Migrations
{
    public partial class Userttyyt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Quantity",
                table: "CleverStoreManagerPurchases",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "QuantityBulk",
                table: "CleverStoreManagerPurchases",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "CleverStoreManagerPurchases");

            migrationBuilder.DropColumn(
                name: "QuantityBulk",
                table: "CleverStoreManagerPurchases");
        }
    }
}
