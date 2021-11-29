using Microsoft.EntityFrameworkCore.Migrations;

namespace CleverStoreManager.Migrations
{
    public partial class Pjnnvbv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductDescription",
                table: "CleverStoreManagerPurchases",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductLabel",
                table: "CleverStoreManagerPurchases",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "CleverStoreManagerPurchases",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductDescription",
                table: "CleverStoreManagerPurchases");

            migrationBuilder.DropColumn(
                name: "ProductLabel",
                table: "CleverStoreManagerPurchases");

            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "CleverStoreManagerPurchases");
        }
    }
}
