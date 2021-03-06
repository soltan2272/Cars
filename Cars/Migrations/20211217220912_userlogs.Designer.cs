// <auto-generated />
using System;
using Cars.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Cars.Migrations
{
    [DbContext(typeof(CarsContext))]
    [Migration("20211217220912_userlogs")]
    partial class userlogs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Cars.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LocationIP")
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SeconedName")
                        .HasColumnType("text");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Cars.Models.Customer", b =>
                {
                    b.Property<long>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DTsCreate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DTsUpdate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("SystemUserCreate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SystemUserUpdate")
                        .HasColumnType("text");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Cars.Models.CustomerContact", b =>
                {
                    b.Property<long>("CustomerContactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("CustomerID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DTsCreate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DTsUpdate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("HasTelegram")
                        .HasColumnType("boolean");

                    b.Property<bool>("HasWhatsapp")
                        .HasColumnType("boolean");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SystemUserCreate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SystemUserUpdate")
                        .HasColumnType("text");

                    b.HasKey("CustomerContactID");

                    b.HasIndex("CustomerID");

                    b.ToTable("CustomerContacts");
                });

            modelBuilder.Entity("Cars.Models.DraftOrder", b =>
                {
                    b.Property<long>("DraftOrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("text");

                    b.Property<string>("Chases")
                        .HasColumnType("text");

                    b.Property<DateTime>("DTsCreate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DTsUpdate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("EmployeeBranchID")
                        .HasColumnType("bigint");

                    b.Property<bool>("Enable")
                        .HasColumnType("boolean");

                    b.Property<string>("Model")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<string>("SystemUserCreate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SystemUserUpdate")
                        .HasColumnType("text");

                    b.Property<bool?>("WithMaintenance")
                        .HasColumnType("boolean");

                    b.Property<string>("Year")
                        .HasColumnType("text");

                    b.HasKey("DraftOrderID");

                    b.ToTable("DraftOrders");
                });

            modelBuilder.Entity("Cars.Models.DraftOrderDetails", b =>
                {
                    b.Property<long>("DraftOrderDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DTsCreate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DTsUpdate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("DraftOrderID")
                        .HasColumnType("bigint");

                    b.Property<string>("Items")
                        .HasColumnType("text");

                    b.Property<int?>("OrderDetailsTypeID")
                        .HasColumnType("integer");

                    b.Property<int?>("Quantity")
                        .HasColumnType("integer");

                    b.Property<string>("SystemUserCreate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SystemUserUpdate")
                        .HasColumnType("text");

                    b.HasKey("DraftOrderDetailsId");

                    b.HasIndex("DraftOrderID");

                    b.HasIndex("OrderDetailsTypeID");

                    b.ToTable("DraftOrderDetails");
                });

            modelBuilder.Entity("Cars.Models.Layer", b =>
                {
                    b.Property<int>("LayerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LayerID");

                    b.ToTable("Layers");
                });

            modelBuilder.Entity("Cars.Models.Order", b =>
                {
                    b.Property<long>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("CustomerID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DTsCreate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DTsUpdate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("EmployeeBranchID")
                        .HasColumnType("bigint");

                    b.Property<bool?>("Enabled")
                        .HasColumnType("boolean");

                    b.Property<string>("Prefix")
                        .HasColumnType("text");

                    b.Property<string>("SystemUserCreate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SystemUserUpdate")
                        .HasColumnType("text");

                    b.Property<long>("VehicleID")
                        .HasColumnType("bigint");

                    b.Property<bool?>("WithMaintenance")
                        .HasColumnType("boolean");

                    b.HasKey("OrderID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("VehicleID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Cars.Models.OrderDetails", b =>
                {
                    b.Property<long>("OrderDetailsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("BranchID")
                        .HasColumnType("integer");

                    b.Property<string>("Comments")
                        .HasColumnType("text");

                    b.Property<DateTime>("DTsCreate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DTsUpdate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool?>("Enabled")
                        .HasColumnType("boolean");

                    b.Property<bool?>("IsApproved")
                        .HasColumnType("boolean");

                    b.Property<string>("Items")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("LayerID")
                        .HasColumnType("integer");

                    b.Property<int>("OrderDetailsTypeID")
                        .HasColumnType("integer");

                    b.Property<long>("OrderID")
                        .HasColumnType("bigint");

                    b.Property<long?>("ParentOrderDetailsID")
                        .HasColumnType("bigint");

                    b.Property<string>("PartNumber")
                        .HasColumnType("text");

                    b.Property<string>("Prefix")
                        .HasColumnType("text");

                    b.Property<decimal?>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<string>("SystemUserCreate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SystemUserUpdate")
                        .HasColumnType("text");

                    b.Property<string>("UsedByUser")
                        .HasColumnType("text");

                    b.Property<int?>("VendorLocationID")
                        .HasColumnType("integer");

                    b.HasKey("OrderDetailsID");

                    b.HasIndex("LayerID");

                    b.HasIndex("OrderDetailsTypeID");

                    b.HasIndex("OrderID");

                    b.HasIndex("VendorLocationID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Cars.Models.OrderDetailsType", b =>
                {
                    b.Property<int>("OrderDetailsTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DTsCreate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DTsUpdate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Details")
                        .HasColumnType("text");

                    b.Property<string>("NameAr")
                        .HasColumnType("text");

                    b.Property<string>("NameEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SystemUserCreate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SystemUserUpdate")
                        .HasColumnType("text");

                    b.HasKey("OrderDetailsTypeID");

                    b.ToTable("OrderDetailsType");
                });

            modelBuilder.Entity("Cars.Models.UsersLogs", b =>
                {
                    b.Property<int>("UsersLogsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreateDts")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UserCity")
                        .HasColumnType("text");

                    b.Property<string>("UserID")
                        .HasColumnType("text");

                    b.Property<string>("UserIP")
                        .HasColumnType("text");

                    b.Property<string>("UserRegion")
                        .HasColumnType("text");

                    b.HasKey("UsersLogsID");

                    b.HasIndex("UserID");

                    b.ToTable("UsersLogs");
                });

            modelBuilder.Entity("Cars.Models.Vehicle", b =>
                {
                    b.Property<long>("VehicleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("text");

                    b.Property<string>("Chases")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DTsCreate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DTsUpdate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Model")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SystemUserCreate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SystemUserUpdate")
                        .HasColumnType("text");

                    b.Property<string>("Year")
                        .HasColumnType("text");

                    b.HasKey("VehicleID");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("Cars.Models.VendorLocation", b =>
                {
                    b.Property<int>("VendorLocationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("NameAr")
                        .HasColumnType("text");

                    b.Property<string>("NameEn")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("VendorLocationID");

                    b.ToTable("VendorLocations");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

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
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Cars.Models.CustomerContact", b =>
                {
                    b.HasOne("Cars.Models.Customer", "Customer")
                        .WithMany("CustomerContacts")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Cars.Models.DraftOrderDetails", b =>
                {
                    b.HasOne("Cars.Models.DraftOrder", "DraftOrder")
                        .WithMany()
                        .HasForeignKey("DraftOrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cars.Models.OrderDetailsType", "OrderDetailsType")
                        .WithMany()
                        .HasForeignKey("OrderDetailsTypeID");

                    b.Navigation("DraftOrder");

                    b.Navigation("OrderDetailsType");
                });

            modelBuilder.Entity("Cars.Models.Order", b =>
                {
                    b.HasOne("Cars.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cars.Models.Vehicle", "Vehicle")
                        .WithMany("Orders")
                        .HasForeignKey("VehicleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("Cars.Models.OrderDetails", b =>
                {
                    b.HasOne("Cars.Models.Layer", "Layer")
                        .WithMany()
                        .HasForeignKey("LayerID");

                    b.HasOne("Cars.Models.OrderDetailsType", "OrderDetailsType")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderDetailsTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cars.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cars.Models.VendorLocation", "VendorLocation")
                        .WithMany()
                        .HasForeignKey("VendorLocationID");

                    b.Navigation("Layer");

                    b.Navigation("Order");

                    b.Navigation("OrderDetailsType");

                    b.Navigation("VendorLocation");
                });

            modelBuilder.Entity("Cars.Models.UsersLogs", b =>
                {
                    b.HasOne("Cars.Models.ApplicationUser", "User")
                        .WithMany("UsersLogs")
                        .HasForeignKey("UserID");

                    b.Navigation("User");
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
                    b.HasOne("Cars.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Cars.Models.ApplicationUser", null)
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

                    b.HasOne("Cars.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Cars.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cars.Models.ApplicationUser", b =>
                {
                    b.Navigation("UsersLogs");
                });

            modelBuilder.Entity("Cars.Models.Customer", b =>
                {
                    b.Navigation("CustomerContacts");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Cars.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("Cars.Models.OrderDetailsType", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("Cars.Models.Vehicle", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
