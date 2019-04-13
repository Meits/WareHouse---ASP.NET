using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WareHouse.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "stocks",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(maxLength: 64, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stocks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(maxLength: 64, nullable: true),
                    StockId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_products_stocks_StockId",
                        column: x => x.StockId,
                        principalTable: "stocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "stocks",
                columns: new[] { "Id", "name" },
                values: new object[] { new Guid("f86a4057-208e-49c9-946c-f86aa03c49d8"), "Stock 1" });

            migrationBuilder.InsertData(
                table: "stocks",
                columns: new[] { "Id", "name" },
                values: new object[] { new Guid("9e03399b-66a8-4e1e-90dc-46acb4abafb4"), "Stock 2" });

            migrationBuilder.InsertData(
                table: "stocks",
                columns: new[] { "Id", "name" },
                values: new object[] { new Guid("6276f645-9366-4a8a-992e-f6e267dca070"), "Stock 3" });

            migrationBuilder.CreateIndex(
                name: "IX_products_StockId",
                table: "products",
                column: "StockId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "stocks");
        }
    }
}
