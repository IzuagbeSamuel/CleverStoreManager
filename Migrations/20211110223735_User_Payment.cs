using Microsoft.EntityFrameworkCore.Migrations;

namespace CleverStoreManager.Migrations
{
    public partial class User_Payment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AgentId",
                table: "CleverStoreManagerPayments",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CleverStoreManagerPayments_AgentId",
                table: "CleverStoreManagerPayments",
                column: "AgentId");

            migrationBuilder.AddForeignKey(
                name: "FK_CleverStoreManagerPayments_AspNetUsers_AgentId",
                table: "CleverStoreManagerPayments",
                column: "AgentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CleverStoreManagerPayments_AspNetUsers_AgentId",
                table: "CleverStoreManagerPayments");

            migrationBuilder.DropIndex(
                name: "IX_CleverStoreManagerPayments_AgentId",
                table: "CleverStoreManagerPayments");

            migrationBuilder.DropColumn(
                name: "AgentId",
                table: "CleverStoreManagerPayments");
        }
    }
}
