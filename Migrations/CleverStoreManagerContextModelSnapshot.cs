﻿// <auto-generated />
using System;
using CleverStoreManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CleverStoreManager.Migrations
{
    [DbContext(typeof(CleverStoreManagerContext))]
    partial class CleverStoreManagerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CleverStoreManager.Models.CleverStoreManagerBusiness", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address1")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Address2")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("AgentId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<byte[]>("CACCertificateFile")
                        .HasColumnType("longblob");

                    b.Property<string>("CACRegNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CEODateOfBirth")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CEOFirstName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("CEOGender")
                        .HasColumnType("int");

                    b.Property<string>("CEOLastName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CEOMiddleName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("City")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CompanyName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Country")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime(6)");

                    b.Property<byte[]>("IdentityFile")
                        .HasColumnType("longblob");

                    b.Property<int>("IdentityType")
                        .HasColumnType("int");

                    b.Property<string>("NoOfEmployee")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PostalCode")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<byte[]>("TINCertificateFile")
                        .HasColumnType("longblob");

                    b.Property<string>("TaxIDNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("AgentId");

                    b.ToTable("CleverStoreManagerBusinesses");
                });

            modelBuilder.Entity("CleverStoreManager.Models.CleverStoreManagerCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("CleverStoreManagerCategories");
                });

            modelBuilder.Entity("CleverStoreManager.Models.CleverStoreManagerCustomer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("AgentId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("MiddleName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("AgentId");

                    b.ToTable("CleverStoreManagerCustomers");
                });

            modelBuilder.Entity("CleverStoreManager.Models.CleverStoreManagerPayment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AccountName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("AccountNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("AgentId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<int>("BankName")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("AgentId");

                    b.ToTable("CleverStoreManagerPayments");
                });

            modelBuilder.Entity("CleverStoreManager.Models.CleverStoreManagerProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AgentId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Barcode")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("CleverStoreManagerCategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("CleverStoreManagerSellerId")
                        .HasColumnType("int");

                    b.Property<string>("CostPrice")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("DiscountPrice")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ExpiringDate")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Label")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("MadeDate")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Quantity")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("SalesPrice")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Size")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("StockKeepingUnit")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Weight")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("AgentId");

                    b.HasIndex("CleverStoreManagerCategoryId");

                    b.HasIndex("CleverStoreManagerSellerId");

                    b.ToTable("CleverStoreManagerProducts");
                });

            modelBuilder.Entity("CleverStoreManager.Models.CleverStoreManagerSale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AgentId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<int>("CleverStoreManagerCustomerId")
                        .HasColumnType("int");

                    b.Property<int>("CleverStoreManagerProductId")
                        .HasColumnType("int");

                    b.Property<string>("Quantity")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("AgentId");

                    b.HasIndex("CleverStoreManagerCustomerId");

                    b.HasIndex("CleverStoreManagerProductId");

                    b.ToTable("CleverStoreManagerSales");
                });

            modelBuilder.Entity("CleverStoreManager.Models.CleverStoreManagerSeller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("AgentId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("BusinessName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("AgentId");

                    b.ToTable("CleverStoreManagerSellers");
                });

            modelBuilder.Entity("CleverStoreManager.Models.CleverStoreManagerUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("AdditionalPhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Address")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FullName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<byte[]>("ProfilePicture")
                        .HasColumnType("longblob");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Value")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CleverStoreManager.Models.CleverStoreManagerBusiness", b =>
                {
                    b.HasOne("CleverStoreManager.Models.CleverStoreManagerUser", "Agent")
                        .WithMany()
                        .HasForeignKey("AgentId");

                    b.Navigation("Agent");
                });

            modelBuilder.Entity("CleverStoreManager.Models.CleverStoreManagerCustomer", b =>
                {
                    b.HasOne("CleverStoreManager.Models.CleverStoreManagerUser", "Agent")
                        .WithMany()
                        .HasForeignKey("AgentId");

                    b.Navigation("Agent");
                });

            modelBuilder.Entity("CleverStoreManager.Models.CleverStoreManagerPayment", b =>
                {
                    b.HasOne("CleverStoreManager.Models.CleverStoreManagerUser", "Agent")
                        .WithMany()
                        .HasForeignKey("AgentId");

                    b.Navigation("Agent");
                });

            modelBuilder.Entity("CleverStoreManager.Models.CleverStoreManagerProduct", b =>
                {
                    b.HasOne("CleverStoreManager.Models.CleverStoreManagerUser", "Agent")
                        .WithMany()
                        .HasForeignKey("AgentId");

                    b.HasOne("CleverStoreManager.Models.CleverStoreManagerCategory", "CleverStoreManagerCategory")
                        .WithMany("CleverStoreManagerProducts")
                        .HasForeignKey("CleverStoreManagerCategoryId");

                    b.HasOne("CleverStoreManager.Models.CleverStoreManagerSeller", "CleverStoreManagerSeller")
                        .WithMany("CleverStoreManagerProducts")
                        .HasForeignKey("CleverStoreManagerSellerId");

                    b.Navigation("Agent");

                    b.Navigation("CleverStoreManagerCategory");

                    b.Navigation("CleverStoreManagerSeller");
                });

            modelBuilder.Entity("CleverStoreManager.Models.CleverStoreManagerSale", b =>
                {
                    b.HasOne("CleverStoreManager.Models.CleverStoreManagerUser", "Agent")
                        .WithMany()
                        .HasForeignKey("AgentId");

                    b.HasOne("CleverStoreManager.Models.CleverStoreManagerCustomer", "CleverStoreManagerCustomer")
                        .WithMany("CleverStoreManagerSales")
                        .HasForeignKey("CleverStoreManagerCustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CleverStoreManager.Models.CleverStoreManagerProduct", "CleverStoreManagerProduct")
                        .WithMany("CleverStoreManagerSales")
                        .HasForeignKey("CleverStoreManagerProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agent");

                    b.Navigation("CleverStoreManagerCustomer");

                    b.Navigation("CleverStoreManagerProduct");
                });

            modelBuilder.Entity("CleverStoreManager.Models.CleverStoreManagerSeller", b =>
                {
                    b.HasOne("CleverStoreManager.Models.CleverStoreManagerUser", "Agent")
                        .WithMany()
                        .HasForeignKey("AgentId");

                    b.Navigation("Agent");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CleverStoreManager.Models.CleverStoreManagerUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CleverStoreManager.Models.CleverStoreManagerUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CleverStoreManager.Models.CleverStoreManagerUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CleverStoreManager.Models.CleverStoreManagerUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CleverStoreManager.Models.CleverStoreManagerCategory", b =>
                {
                    b.Navigation("CleverStoreManagerProducts");
                });

            modelBuilder.Entity("CleverStoreManager.Models.CleverStoreManagerCustomer", b =>
                {
                    b.Navigation("CleverStoreManagerSales");
                });

            modelBuilder.Entity("CleverStoreManager.Models.CleverStoreManagerProduct", b =>
                {
                    b.Navigation("CleverStoreManagerSales");
                });

            modelBuilder.Entity("CleverStoreManager.Models.CleverStoreManagerSeller", b =>
                {
                    b.Navigation("CleverStoreManagerProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
