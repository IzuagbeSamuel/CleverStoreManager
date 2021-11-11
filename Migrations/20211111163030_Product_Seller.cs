using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CleverStoreManager.Migrations
{
    public partial class Product_Seller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products_Seller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CleverStoreManagerProductId = table.Column<int>(type: "int", nullable: false),
                    CleverStoreManagerSellerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products_Seller", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Seller_CleverStoreManagerProducts_CleverStoreManage~",
                        column: x => x.CleverStoreManagerProductId,
                        principalTable: "CleverStoreManagerProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Seller_CleverStoreManagerSellers_CleverStoreManager~",
                        column: x => x.CleverStoreManagerSellerId,
                        principalTable: "CleverStoreManagerSellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_Seller_CleverStoreManagerProductId",
                table: "Products_Seller",
                column: "CleverStoreManagerProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Seller_CleverStoreManagerSellerId",
                table: "Products_Seller",
                column: "CleverStoreManagerSellerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products_Seller");
        }
    }
}
