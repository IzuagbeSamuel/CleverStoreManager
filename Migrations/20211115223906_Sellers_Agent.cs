using Microsoft.EntityFrameworkCore.Migrations;

namespace CleverStoreManager.Migrations
{
    public partial class Sellers_Agent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AgentId",
                table: "CleverStoreManagerSellers",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CleverStoreManagerSellers_AgentId",
                table: "CleverStoreManagerSellers",
                column: "AgentId");

            migrationBuilder.AddForeignKey(
                name: "FK_CleverStoreManagerSellers_AspNetUsers_AgentId",
                table: "CleverStoreManagerSellers",
                column: "AgentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CleverStoreManagerSellers_AspNetUsers_AgentId",
                table: "CleverStoreManagerSellers");

            migrationBuilder.DropIndex(
                name: "IX_CleverStoreManagerSellers_AgentId",
                table: "CleverStoreManagerSellers");

            migrationBuilder.DropColumn(
                name: "AgentId",
                table: "CleverStoreManagerSellers");
        }
    }
}
