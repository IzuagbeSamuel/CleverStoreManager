using Microsoft.EntityFrameworkCore.Migrations;

namespace CleverStoreManager.Migrations
{
    public partial class Product_Category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CleverStoreManagerCategoryId",
                table: "CleverStoreManagerProducts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CleverStoreManagerProducts_CleverStoreManagerCategoryId",
                table: "CleverStoreManagerProducts",
                column: "CleverStoreManagerCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_CleverStoreManagerProducts_CleverStoreManagerCategories_Clev~",
                table: "CleverStoreManagerProducts",
                column: "CleverStoreManagerCategoryId",
                principalTable: "CleverStoreManagerCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CleverStoreManagerProducts_CleverStoreManagerCategories_Clev~",
                table: "CleverStoreManagerProducts");

            migrationBuilder.DropIndex(
                name: "IX_CleverStoreManagerProducts_CleverStoreManagerCategoryId",
                table: "CleverStoreManagerProducts");

            migrationBuilder.DropColumn(
                name: "CleverStoreManagerCategoryId",
                table: "CleverStoreManagerProducts");
        }
    }
}
