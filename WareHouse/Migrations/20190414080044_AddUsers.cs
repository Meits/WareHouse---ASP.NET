using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WareHouse.Migrations
{
    public partial class AddUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "stocks",
                keyColumn: "Id",
                keyValue: new Guid("6276f645-9366-4a8a-992e-f6e267dca070"));

            migrationBuilder.DeleteData(
                table: "stocks",
                keyColumn: "Id",
                keyValue: new Guid("9e03399b-66a8-4e1e-90dc-46acb4abafb4"));

            migrationBuilder.DeleteData(
                table: "stocks",
                keyColumn: "Id",
                keyValue: new Guid("f86a4057-208e-49c9-946c-f86aa03c49d8"));

            migrationBuilder.InsertData(
                table: "stocks",
                columns: new[] { "Id", "name" },
                values: new object[] { new Guid("6d709055-de72-4073-af14-1781787df078"), "Stock 1" });

            migrationBuilder.InsertData(
                table: "stocks",
                columns: new[] { "Id", "name" },
                values: new object[] { new Guid("72ec42a0-b7c7-404f-aa2b-05062a0a87b9"), "Stock 2" });

            migrationBuilder.InsertData(
                table: "stocks",
                columns: new[] { "Id", "name" },
                values: new object[] { new Guid("6d2ef824-392d-4b86-a88e-f9356829bb81"), "Stock 3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "stocks",
                keyColumn: "Id",
                keyValue: new Guid("6d2ef824-392d-4b86-a88e-f9356829bb81"));

            migrationBuilder.DeleteData(
                table: "stocks",
                keyColumn: "Id",
                keyValue: new Guid("6d709055-de72-4073-af14-1781787df078"));

            migrationBuilder.DeleteData(
                table: "stocks",
                keyColumn: "Id",
                keyValue: new Guid("72ec42a0-b7c7-404f-aa2b-05062a0a87b9"));

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
        }
    }
}
