using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MultipleContexts.Migrations.Products
{
    /// <inheritdoc />
    public partial class AddProductEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { new Guid("0119866c-433c-47aa-8e56-eb18e7f3e03d"), new DateTime(2024, 1, 4, 18, 32, 25, 160, DateTimeKind.Utc).AddTicks(8318), "Product Seven", 777L, 7 },
                    { new Guid("0b39e809-6389-4d6e-9f2e-99513ea9d9d5"), new DateTime(2024, 1, 4, 18, 32, 25, 160, DateTimeKind.Utc).AddTicks(8303), "Product Three", 333L, 3 },
                    { new Guid("2545c8ba-656d-48c5-b5e3-30427281efb0"), new DateTime(2024, 1, 4, 18, 32, 25, 160, DateTimeKind.Utc).AddTicks(8301), "Product Two", 222L, 2 },
                    { new Guid("390dd7eb-023a-40c9-9c34-b7afd16e827e"), new DateTime(2024, 1, 4, 18, 32, 25, 160, DateTimeKind.Utc).AddTicks(8089), "Product One", 111L, 1 },
                    { new Guid("3c44d022-fea7-465e-b230-3a2d7de0da79"), new DateTime(2024, 1, 4, 18, 32, 25, 160, DateTimeKind.Utc).AddTicks(8320), "Product Eight", 888L, 8 },
                    { new Guid("5029e9cf-163f-4f03-a321-d306d4e022f5"), new DateTime(2024, 1, 4, 18, 32, 25, 160, DateTimeKind.Utc).AddTicks(8317), "Product Six", 666L, 6 },
                    { new Guid("c2717dc7-0fee-47d6-aefe-14614f1a54cf"), new DateTime(2024, 1, 4, 18, 32, 25, 160, DateTimeKind.Utc).AddTicks(8322), "Product Nine", 999L, 9 },
                    { new Guid("cb5bd7f2-7bb3-4a96-bcbb-9c7839cc9474"), new DateTime(2024, 1, 4, 18, 32, 25, 160, DateTimeKind.Utc).AddTicks(8304), "Product Four", 444L, 4 },
                    { new Guid("ec95a3c5-aba3-4470-9363-a95a238dd3ce"), new DateTime(2024, 1, 4, 18, 32, 25, 160, DateTimeKind.Utc).AddTicks(8315), "Product Five", 555L, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
