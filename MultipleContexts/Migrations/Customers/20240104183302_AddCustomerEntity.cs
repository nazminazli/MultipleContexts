using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MultipleContexts.Migrations.Customers
{
    /// <inheritdoc />
    public partial class AddCustomerEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedDate", "Name", "Surname" },
                values: new object[,]
                {
                    { new Guid("3f9283b9-89ba-4c3e-8765-955c07c83a53"), new DateTime(2024, 1, 4, 18, 33, 1, 580, DateTimeKind.Utc).AddTicks(6296), "Customer One", "Surname One" },
                    { new Guid("ad26f214-9cd9-4f0f-a1b1-37f886701607"), new DateTime(2024, 1, 4, 18, 33, 1, 580, DateTimeKind.Utc).AddTicks(6521), "Customer Two", "Surname Two" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
