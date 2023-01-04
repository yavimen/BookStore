using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Book",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "Genre", "Price", "PublishDate", "Title" },
                values: new object[] { 1, "Genre1", 20.0, new DateTime(2012, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book1" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "Genre", "Price", "PublishDate", "Title" },
                values: new object[] { 2, "Genre2", 30.0, new DateTime(2008, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Book",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
