using Microsoft.EntityFrameworkCore.Migrations;

namespace CleverStoreManager.Migrations
{
    public partial class Seller_Details : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Seller_CleverStoreManagerProducts_CleverStoreManage~",
                table: "Products_Seller");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Seller_CleverStoreManagerSellers_CleverStoreManager~",
                table: "Products_Seller");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products_Seller",
                table: "Products_Seller");

            migrationBuilder.RenameTable(
                name: "Products_Seller",
                newName: "Products_Sellers");

            migrationBuilder.RenameIndex(
                name: "IX_Products_Seller_CleverStoreManagerSellerId",
                table: "Products_Sellers",
                newName: "IX_Products_Sellers_CleverStoreManagerSellerId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_Seller_CleverStoreManagerProductId",
                table: "Products_Sellers",
                newName: "IX_Products_Sellers_CleverStoreManagerProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products_Sellers",
                table: "Products_Sellers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Sellers_CleverStoreManagerProducts_CleverStoreManag~",
                table: "Products_Sellers",
                column: "CleverStoreManagerProductId",
                principalTable: "CleverStoreManagerProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Sellers_CleverStoreManagerSellers_CleverStoreManage~",
                table: "Products_Sellers",
                column: "CleverStoreManagerSellerId",
                principalTable: "CleverStoreManagerSellers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Sellers_CleverStoreManagerProducts_CleverStoreManag~",
                table: "Products_Sellers");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Sellers_CleverStoreManagerSellers_CleverStoreManage~",
                table: "Products_Sellers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products_Sellers",
                table: "Products_Sellers");

            migrationBuilder.RenameTable(
                name: "Products_Sellers",
                newName: "Products_Seller");

            migrationBuilder.RenameIndex(
                name: "IX_Products_Sellers_CleverStoreManagerSellerId",
                table: "Products_Seller",
                newName: "IX_Products_Seller_CleverStoreManagerSellerId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_Sellers_CleverStoreManagerProductId",
                table: "Products_Seller",
                newName: "IX_Products_Seller_CleverStoreManagerProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products_Seller",
                table: "Products_Seller",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Seller_CleverStoreManagerProducts_CleverStoreManage~",
                table: "Products_Seller",
                column: "CleverStoreManagerProductId",
                principalTable: "CleverStoreManagerProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Seller_CleverStoreManagerSellers_CleverStoreManager~",
                table: "Products_Seller",
                column: "CleverStoreManagerSellerId",
                principalTable: "CleverStoreManagerSellers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
