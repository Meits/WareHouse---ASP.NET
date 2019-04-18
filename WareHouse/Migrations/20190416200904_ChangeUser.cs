using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WareHouse.Migrations
{
    public partial class ChangeUser : Migration
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

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    firstname = table.Column<string>(maxLength: 64, nullable: true),
                    lastname = table.Column<string>(maxLength: 64, nullable: true),
                    password = table.Column<string>(maxLength: 64, nullable: true),
                    salt = table.Column<string>(maxLength: 64, nullable: true),
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
                    { new Guid("17ecc703-4bdc-472b-90f6-328af258f1e1"), "Stock 1" },
                    { new Guid("541904cb-e31f-43a4-93cf-23c8837b4f7d"), "Stock 2" },
                    { new Guid("a2dccc9f-851f-489f-9cc6-978f0d3fbfa8"), "Stock 3" }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "email", "firstname", "lastname", "password", "salt", "token" },
                values: new object[] { new Guid("f426c63e-e558-4a81-80cf-8a1191c8a3f6"), "admin@admin.com", "Admin", "Admin", "a08Qsu+FQDmwDAjOUUnPMmqiARLAgp8wsnV++iqIOlY=", "pMA+IGiu5fcZBCj32yOcGQ==", "7d8das8tdasd8as7d8asygd8as7gd8sa" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DeleteData(
                table: "stocks",
                keyColumn: "Id",
                keyValue: new Guid("17ecc703-4bdc-472b-90f6-328af258f1e1"));

            migrationBuilder.DeleteData(
                table: "stocks",
                keyColumn: "Id",
                keyValue: new Guid("541904cb-e31f-43a4-93cf-23c8837b4f7d"));

            migrationBuilder.DeleteData(
                table: "stocks",
                keyColumn: "Id",
                keyValue: new Guid("a2dccc9f-851f-489f-9cc6-978f0d3fbfa8"));

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
