using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CleverStoreManager.Migrations
{
    public partial class Product_Seller_Rename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products_Sellers");

            migrationBuilder.AddColumn<int>(
                name: "CleverStoreManagerSellerId",
                table: "CleverStoreManagerProducts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CleverStoreManagerProducts_CleverStoreManagerSellerId",
                table: "CleverStoreManagerProducts",
                column: "CleverStoreManagerSellerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CleverStoreManagerProducts_CleverStoreManagerSellers_CleverS~",
                table: "CleverStoreManagerProducts",
                column: "CleverStoreManagerSellerId",
                principalTable: "CleverStoreManagerSellers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CleverStoreManagerProducts_CleverStoreManagerSellers_CleverS~",
                table: "CleverStoreManagerProducts");

            migrationBuilder.DropIndex(
                name: "IX_CleverStoreManagerProducts_CleverStoreManagerSellerId",
                table: "CleverStoreManagerProducts");

            migrationBuilder.DropColumn(
                name: "CleverStoreManagerSellerId",
                table: "CleverStoreManagerProducts");

            migrationBuilder.CreateTable(
                name: "Products_Sellers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CleverStoreManagerProductId = table.Column<int>(type: "int", nullable: false),
                    CleverStoreManagerSellerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products_Sellers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Sellers_CleverStoreManagerProducts_CleverStoreManag~",
                        column: x => x.CleverStoreManagerProductId,
                        principalTable: "CleverStoreManagerProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Sellers_CleverStoreManagerSellers_CleverStoreManage~",
                        column: x => x.CleverStoreManagerSellerId,
                        principalTable: "CleverStoreManagerSellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_Sellers_CleverStoreManagerProductId",
                table: "Products_Sellers",
                column: "CleverStoreManagerProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Sellers_CleverStoreManagerSellerId",
                table: "Products_Sellers",
                column: "CleverStoreManagerSellerId");
        }
    }
}
