using Microsoft.EntityFrameworkCore.Migrations;

namespace CleverStoreManager.Migrations
{
    public partial class fgfg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AgentId",
                table: "CleverStoreManagerProducts",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CleverStoreManagerProducts_AgentId",
                table: "CleverStoreManagerProducts",
                column: "AgentId");

            migrationBuilder.AddForeignKey(
                name: "FK_CleverStoreManagerProducts_AspNetUsers_AgentId",
                table: "CleverStoreManagerProducts",
                column: "AgentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CleverStoreManagerProducts_AspNetUsers_AgentId",
                table: "CleverStoreManagerProducts");

            migrationBuilder.DropIndex(
                name: "IX_CleverStoreManagerProducts_AgentId",
                table: "CleverStoreManagerProducts");

            migrationBuilder.DropColumn(
                name: "AgentId",
                table: "CleverStoreManagerProducts");
        }
    }
}
