using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CleverStoreManager.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    Name = table.Column<string>(type: "varchar(256) CHARACTER SET utf8mb4", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "varchar(256) CHARACTER SET utf8mb4", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    FirstName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    LastName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    FullName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Address = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    AdditionalPhoneNumber = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ProfilePicture = table.Column<byte[]>(type: "longblob", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(256) CHARACTER SET utf8mb4", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "varchar(256) CHARACTER SET utf8mb4", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "varchar(256) CHARACTER SET utf8mb4", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "varchar(256) CHARACTER SET utf8mb4", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    SecurityStamp = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    PhoneNumber = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CleverStoreManagerCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CleverStoreManagerCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    ClaimType = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ClaimValue = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    ClaimType = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ClaimValue = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    ProviderKey = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    UserId = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    RoleId = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    LoginProvider = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    Name = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    Value = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CleverStoreManagerBusinesses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CompanyName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Address1 = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Address2 = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    City = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Country = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    PostalCode = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    CEOFirstName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    CEOMiddleName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    CEOLastName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    CEODateOfBirth = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    CEOGender = table.Column<int>(type: "int", nullable: false),
                    IdentityType = table.Column<int>(type: "int", nullable: false),
                    IdentityFile = table.Column<byte[]>(type: "longblob", nullable: true),
                    NoOfEmployee = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    CACRegNumber = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    CACCertificateFile = table.Column<byte[]>(type: "longblob", nullable: true),
                    TINCertificateFile = table.Column<byte[]>(type: "longblob", nullable: true),
                    TaxIDNumber = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    AgentId = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CleverStoreManagerBusinesses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CleverStoreManagerBusinesses_AspNetUsers_AgentId",
                        column: x => x.AgentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CleverStoreManagerCustomers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    MiddleName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    LastName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    PhoneNumber = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    EmailAddress = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Address = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    AgentId = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CleverStoreManagerCustomers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CleverStoreManagerCustomers_AspNetUsers_AgentId",
                        column: x => x.AgentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CleverStoreManagerPayments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AccountName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    AccountNumber = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    BankName = table.Column<int>(type: "int", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    AgentId = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CleverStoreManagerPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CleverStoreManagerPayments_AspNetUsers_AgentId",
                        column: x => x.AgentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CleverStoreManagerSellers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BusinessName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Address = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    EmailAddress = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    PhoneNumber = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    AgentId = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CleverStoreManagerSellers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CleverStoreManagerSellers_AspNetUsers_AgentId",
                        column: x => x.AgentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                    Weight = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    AgentId = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: true),
                    CleverStoreManagerCategoryId = table.Column<int>(type: "int", nullable: true),
                    CleverStoreManagerSellerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CleverStoreManagerProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CleverStoreManagerProducts_AspNetUsers_AgentId",
                        column: x => x.AgentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CleverStoreManagerProducts_CleverStoreManagerCategories_Clev~",
                        column: x => x.CleverStoreManagerCategoryId,
                        principalTable: "CleverStoreManagerCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CleverStoreManagerProducts_CleverStoreManagerSellers_CleverS~",
                        column: x => x.CleverStoreManagerSellerId,
                        principalTable: "CleverStoreManagerSellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CleverStoreManagerSales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Quantity = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    CleverStoreManagerProductId = table.Column<int>(type: "int", nullable: false),
                    CleverStoreManagerCustomerId = table.Column<int>(type: "int", nullable: false),
                    AgentId = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CleverStoreManagerSales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CleverStoreManagerSales_AspNetUsers_AgentId",
                        column: x => x.AgentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CleverStoreManagerSales_CleverStoreManagerCustomers_CleverSt~",
                        column: x => x.CleverStoreManagerCustomerId,
                        principalTable: "CleverStoreManagerCustomers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CleverStoreManagerSales_CleverStoreManagerProducts_CleverSto~",
                        column: x => x.CleverStoreManagerProductId,
                        principalTable: "CleverStoreManagerProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CleverStoreManagerBusinesses_AgentId",
                table: "CleverStoreManagerBusinesses",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_CleverStoreManagerCustomers_AgentId",
                table: "CleverStoreManagerCustomers",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_CleverStoreManagerPayments_AgentId",
                table: "CleverStoreManagerPayments",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_CleverStoreManagerProducts_AgentId",
                table: "CleverStoreManagerProducts",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_CleverStoreManagerProducts_CleverStoreManagerCategoryId",
                table: "CleverStoreManagerProducts",
                column: "CleverStoreManagerCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CleverStoreManagerProducts_CleverStoreManagerSellerId",
                table: "CleverStoreManagerProducts",
                column: "CleverStoreManagerSellerId");

            migrationBuilder.CreateIndex(
                name: "IX_CleverStoreManagerSales_AgentId",
                table: "CleverStoreManagerSales",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_CleverStoreManagerSales_CleverStoreManagerCustomerId",
                table: "CleverStoreManagerSales",
                column: "CleverStoreManagerCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CleverStoreManagerSales_CleverStoreManagerProductId",
                table: "CleverStoreManagerSales",
                column: "CleverStoreManagerProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CleverStoreManagerSellers_AgentId",
                table: "CleverStoreManagerSellers",
                column: "AgentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CleverStoreManagerBusinesses");

            migrationBuilder.DropTable(
                name: "CleverStoreManagerPayments");

            migrationBuilder.DropTable(
                name: "CleverStoreManagerSales");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "CleverStoreManagerCustomers");

            migrationBuilder.DropTable(
                name: "CleverStoreManagerProducts");

            migrationBuilder.DropTable(
                name: "CleverStoreManagerCategories");

            migrationBuilder.DropTable(
                name: "CleverStoreManagerSellers");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
