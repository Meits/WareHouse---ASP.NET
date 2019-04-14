using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WareHouse.Migrations
{
    public partial class AddUsers2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    firstname = table.Column<string>(maxLength: 64, nullable: true),
                    lastname = table.Column<string>(maxLength: 64, nullable: true),
                    password = table.Column<string>(maxLength: 64, nullable: true),
                    email = table.Column<string>(maxLength: 64, nullable: true),
                    token = table.Column<string>(maxLength: 64, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "stocks",
                columns: new[] { "Id", "name" },
                values: new object[,]
                {
                    { new Guid("eea422be-a37e-4593-b9d5-0dadd1d66496"), "Stock 1" },
                    { new Guid("508516f0-7b69-4ea7-9d8f-9d8fceacd6bc"), "Stock 2" },
                    { new Guid("db46e9f4-0c9d-47d3-87df-2ba622493da6"), "Stock 3" }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "email", "firstname", "lastname", "password", "token" },
                values: new object[] { new Guid("0761ba0c-fa50-4e4a-8b38-29bb0f8e3753"), "admin@admin.com", "Admin", "Admin", "gwBdINtuCcv9k+V3I2z1vRMkKHxJ0/VOWxFhUArEuz8=", "7d8das8tdasd8as7d8asygd8as7gd8sa" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DeleteData(
                table: "stocks",
                keyColumn: "Id",
                keyValue: new Guid("508516f0-7b69-4ea7-9d8f-9d8fceacd6bc"));

            migrationBuilder.DeleteData(
                table: "stocks",
                keyColumn: "Id",
                keyValue: new Guid("db46e9f4-0c9d-47d3-87df-2ba622493da6"));

            migrationBuilder.DeleteData(
                table: "stocks",
                keyColumn: "Id",
                keyValue: new Guid("eea422be-a37e-4593-b9d5-0dadd1d66496"));

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
    }
}
