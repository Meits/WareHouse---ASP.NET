﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WareHouse.AppContext;

namespace WareHouse.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190413162635_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WareHouse.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(64);

                    b.Property<Guid>("StockId");

                    b.HasKey("Id");

                    b.HasIndex("StockId");

                    b.ToTable("products");
                });

            modelBuilder.Entity("WareHouse.Entities.Stock", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("stocks");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f86a4057-208e-49c9-946c-f86aa03c49d8"),
                            Name = "Stock 1"
                        },
                        new
                        {
                            Id = new Guid("9e03399b-66a8-4e1e-90dc-46acb4abafb4"),
                            Name = "Stock 2"
                        },
                        new
                        {
                            Id = new Guid("6276f645-9366-4a8a-992e-f6e267dca070"),
                            Name = "Stock 3"
                        });
                });

            modelBuilder.Entity("WareHouse.Entities.Product", b =>
                {
                    b.HasOne("WareHouse.Entities.Stock", "Stock")
                        .WithMany("Products")
                        .HasForeignKey("StockId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}