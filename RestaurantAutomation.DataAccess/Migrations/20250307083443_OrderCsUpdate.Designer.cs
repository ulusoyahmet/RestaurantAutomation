﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantAutomation.DataAccess.Context;

#nullable disable

namespace RestaurantAutomation.DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250307083443_OrderCsUpdate")]
    partial class OrderCsUpdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RestaurantAutomation.Entities.Models.Category", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("RestaurantAutomation.Entities.Models.MenuItem", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("MenuItems");
                });

            modelBuilder.Entity("RestaurantAutomation.Entities.Models.Order", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPayment")
                        .HasColumnType("bit");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TableID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("TableID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("RestaurantAutomation.Entities.Models.OrderDetail", b =>
                {
                    b.Property<Guid>("OrderID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MenuItemID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderID", "MenuItemID");

                    b.HasIndex("MenuItemID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("RestaurantAutomation.Entities.Models.Payment", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("OrderID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("OrderID")
                        .IsUnique();

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("RestaurantAutomation.Entities.Models.Role", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("RestaurantAutomation.Entities.Models.Table", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TableCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TableNumber")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Tables");
                });

            modelBuilder.Entity("RestaurantAutomation.Entities.Models.User", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("RoleID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RestaurantAutomation.Entities.Models.MenuItem", b =>
                {
                    b.HasOne("RestaurantAutomation.Entities.Models.Category", "Category")
                        .WithMany("MenuItems")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("RestaurantAutomation.Entities.Models.Order", b =>
                {
                    b.HasOne("RestaurantAutomation.Entities.Models.Table", "Table")
                        .WithMany("Orders")
                        .HasForeignKey("TableID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Table");
                });

            modelBuilder.Entity("RestaurantAutomation.Entities.Models.OrderDetail", b =>
                {
                    b.HasOne("RestaurantAutomation.Entities.Models.MenuItem", "MenuItem")
                        .WithMany()
                        .HasForeignKey("MenuItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantAutomation.Entities.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MenuItem");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("RestaurantAutomation.Entities.Models.Payment", b =>
                {
                    b.HasOne("RestaurantAutomation.Entities.Models.Order", "Order")
                        .WithOne("Payment")
                        .HasForeignKey("RestaurantAutomation.Entities.Models.Payment", "OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("RestaurantAutomation.Entities.Models.User", b =>
                {
                    b.HasOne("RestaurantAutomation.Entities.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("RestaurantAutomation.Entities.Models.Category", b =>
                {
                    b.Navigation("MenuItems");
                });

            modelBuilder.Entity("RestaurantAutomation.Entities.Models.Order", b =>
                {
                    b.Navigation("Payment");
                });

            modelBuilder.Entity("RestaurantAutomation.Entities.Models.Table", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
