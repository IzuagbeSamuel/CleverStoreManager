using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CleverStoreManager.Migrations
{
    public partial class User_Product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CleverStoreManagerProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Barcode = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Label = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Description = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    MadeDate = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ExpiringDate = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Size = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Quantity = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    SalesPrice = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    CostPrice = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    DiscountPrice = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    StockKeepingUnit = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Weight = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CleverStoreManagerProducts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CleverStoreManagerProducts");
        }
    }
}
