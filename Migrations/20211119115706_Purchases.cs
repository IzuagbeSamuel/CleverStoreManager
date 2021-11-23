using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CleverStoreManager.Migrations
{
    public partial class Purchases : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CleverStoreManagerPurchases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DateOrdered = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateToDeliver = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    CleverStoreManagerProductId = table.Column<int>(type: "int", nullable: false),
                    CleverStoreManagerSellerId = table.Column<int>(type: "int", nullable: false),
                    AgentId = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CleverStoreManagerPurchases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CleverStoreManagerPurchases_AspNetUsers_AgentId",
                        column: x => x.AgentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CleverStoreManagerPurchases_CleverStoreManagerProducts_Cleve~",
                        column: x => x.CleverStoreManagerProductId,
                        principalTable: "CleverStoreManagerProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CleverStoreManagerPurchases_CleverStoreManagerSellers_Clever~",
                        column: x => x.CleverStoreManagerSellerId,
                        principalTable: "CleverStoreManagerSellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CleverStoreManagerPurchases_AgentId",
                table: "CleverStoreManagerPurchases",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_CleverStoreManagerPurchases_CleverStoreManagerProductId",
                table: "CleverStoreManagerPurchases",
                column: "CleverStoreManagerProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CleverStoreManagerPurchases_CleverStoreManagerSellerId",
                table: "CleverStoreManagerPurchases",
                column: "CleverStoreManagerSellerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CleverStoreManagerPurchases");
        }
    }
}
