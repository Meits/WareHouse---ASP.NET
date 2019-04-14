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
    [Migration("20190414080044_AddUsers")]
    partial class AddUsers
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
                            Id = new Guid("6d709055-de72-4073-af14-1781787df078"),
                            Name = "Stock 1"
                        },
                        new
                        {
                            Id = new Guid("72ec42a0-b7c7-404f-aa2b-05062a0a87b9"),
                            Name = "Stock 2"
                        },
                        new
                        {
                            Id = new Guid("6d2ef824-392d-4b86-a88e-f9356829bb81"),
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