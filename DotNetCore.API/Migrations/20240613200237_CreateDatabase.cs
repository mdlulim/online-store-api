using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DotNetCore.API.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VendorCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CostPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "CreatedDate", "Description", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("a083a8da-d9a1-4c2d-85e2-f6d1234a56b0"), "KZN", new DateTime(2024, 6, 13, 20, 2, 37, 687, DateTimeKind.Utc).AddTicks(570), "KwaZulu-Natal", "KwaZulu-Natal", new DateTime(2024, 6, 13, 20, 2, 37, 687, DateTimeKind.Utc).AddTicks(571) },
                    { new Guid("a083a8da-d9a1-4c2d-85e2-f6d1234a56b1"), "EC", new DateTime(2024, 6, 13, 20, 2, 37, 687, DateTimeKind.Utc).AddTicks(572), "Eastern Cape", "Eastern Cape", new DateTime(2024, 6, 13, 20, 2, 37, 687, DateTimeKind.Utc).AddTicks(572) },
                    { new Guid("a083a8da-d9a1-4c2d-85e2-f6d1234a56b2"), "FS", new DateTime(2024, 6, 13, 20, 2, 37, 687, DateTimeKind.Utc).AddTicks(574), "Free State", "Free State", new DateTime(2024, 6, 13, 20, 2, 37, 687, DateTimeKind.Utc).AddTicks(574) },
                    { new Guid("a083a8da-d9a1-4c2d-85e2-f6d1234a56b3"), "LP", new DateTime(2024, 6, 13, 20, 2, 37, 687, DateTimeKind.Utc).AddTicks(575), "Limpopo", "Limpopo", new DateTime(2024, 6, 13, 20, 2, 37, 687, DateTimeKind.Utc).AddTicks(575) },
                    { new Guid("a083a8da-d9a1-4c2d-85e2-f6d1234a56b4"), "MP", new DateTime(2024, 6, 13, 20, 2, 37, 687, DateTimeKind.Utc).AddTicks(577), "Mpumalanga", "Mpumalanga", new DateTime(2024, 6, 13, 20, 2, 37, 687, DateTimeKind.Utc).AddTicks(577) },
                    { new Guid("a083a8da-d9a1-4c2d-85e2-f6d1234a56b5"), "NW", new DateTime(2024, 6, 13, 20, 2, 37, 687, DateTimeKind.Utc).AddTicks(578), "North West", "North West", new DateTime(2024, 6, 13, 20, 2, 37, 687, DateTimeKind.Utc).AddTicks(579) },
                    { new Guid("a083a8da-d9a1-4c2d-85e2-f6d1234a56b6"), "NC", new DateTime(2024, 6, 13, 20, 2, 37, 687, DateTimeKind.Utc).AddTicks(580), "Northern Cape", "Northern Cape", new DateTime(2024, 6, 13, 20, 2, 37, 687, DateTimeKind.Utc).AddTicks(580) },
                    { new Guid("a083a8da-d9a1-4c2d-85e2-f6d1234a56b7"), "WC", new DateTime(2024, 6, 13, 20, 2, 37, 687, DateTimeKind.Utc).AddTicks(582), "Western Cape", "Western Cape", new DateTime(2024, 6, 13, 20, 2, 37, 687, DateTimeKind.Utc).AddTicks(582) },
                    { new Guid("f3604540-6c24-4959-ae2e-8047b7d9f1fb"), "GP", new DateTime(2024, 6, 13, 20, 2, 37, 687, DateTimeKind.Utc).AddTicks(567), "Gauteng Province", "Gauteng", new DateTime(2024, 6, 13, 20, 2, 37, 687, DateTimeKind.Utc).AddTicks(568) }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "CreatedDate", "IsActive", "Name", "UpdatedDate", "VendorCode" },
                values: new object[] { new Guid("a3a5f2d4-8e92-46c8-9232-f8de57f2c2af"), new DateTime(2024, 6, 13, 20, 2, 37, 687, DateTimeKind.Utc).AddTicks(680), 1, "The Prepaid Company", new DateTime(2024, 6, 13, 20, 2, 37, 687, DateTimeKind.Utc).AddTicks(681), "TPC" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierId",
                table: "Products",
                column: "SupplierId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
