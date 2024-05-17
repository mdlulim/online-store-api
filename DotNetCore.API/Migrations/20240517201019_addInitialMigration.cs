using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DotNetCore.API.Migrations
{
    /// <inheritdoc />
    public partial class addInitialMigration : Migration
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
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "CreatedDate", "Description", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("15eb53f2-37a8-4c13-b0c2-2e4aa4fc782d"), "NC", new DateTime(2024, 5, 17, 20, 10, 19, 30, DateTimeKind.Utc).AddTicks(9294), "Northern Cape", "Northern Cape", new DateTime(2024, 5, 17, 20, 10, 19, 30, DateTimeKind.Utc).AddTicks(9294) },
                    { new Guid("260ac91a-ab3f-4717-bfe9-13fc52c4d8d8"), "FS", new DateTime(2024, 5, 17, 20, 10, 19, 30, DateTimeKind.Utc).AddTicks(9280), "Free State", "Free State", new DateTime(2024, 5, 17, 20, 10, 19, 30, DateTimeKind.Utc).AddTicks(9281) },
                    { new Guid("31190107-d560-434e-959e-dafc7be85a98"), "GP", new DateTime(2024, 5, 17, 20, 10, 19, 30, DateTimeKind.Utc).AddTicks(9275), "Gauteng Province", "Gauteng", new DateTime(2024, 5, 17, 20, 10, 19, 30, DateTimeKind.Utc).AddTicks(9275) },
                    { new Guid("4bb05fd0-1489-4c49-ad27-8216b4d6a516"), "EC", new DateTime(2024, 5, 17, 20, 10, 19, 30, DateTimeKind.Utc).AddTicks(9279), "Eastern Cape", "Eastern Cape", new DateTime(2024, 5, 17, 20, 10, 19, 30, DateTimeKind.Utc).AddTicks(9279) },
                    { new Guid("724cb957-06c4-40de-aa86-b3ecf46b99f1"), "NW", new DateTime(2024, 5, 17, 20, 10, 19, 30, DateTimeKind.Utc).AddTicks(9292), "North West", "North West", new DateTime(2024, 5, 17, 20, 10, 19, 30, DateTimeKind.Utc).AddTicks(9292) },
                    { new Guid("7a799857-3ee9-4942-8f4e-eb70a02f2378"), "LP", new DateTime(2024, 5, 17, 20, 10, 19, 30, DateTimeKind.Utc).AddTicks(9282), "Limpopo", "Limpopo", new DateTime(2024, 5, 17, 20, 10, 19, 30, DateTimeKind.Utc).AddTicks(9282) },
                    { new Guid("8ab903a5-0b44-4c2f-8402-dfc7f3df8e5e"), "MP", new DateTime(2024, 5, 17, 20, 10, 19, 30, DateTimeKind.Utc).AddTicks(9291), "Mpumalanga", "Mpumalanga", new DateTime(2024, 5, 17, 20, 10, 19, 30, DateTimeKind.Utc).AddTicks(9291) },
                    { new Guid("c565f77b-b5e1-4025-8813-e99b621ad187"), "GP", new DateTime(2024, 5, 17, 20, 10, 19, 30, DateTimeKind.Utc).AddTicks(9277), "KwaZulu-Natal", "KwaZulu-Natal", new DateTime(2024, 5, 17, 20, 10, 19, 30, DateTimeKind.Utc).AddTicks(9277) },
                    { new Guid("cd6d1690-42fe-4194-9471-fd62062cb0ae"), "WC", new DateTime(2024, 5, 17, 20, 10, 19, 30, DateTimeKind.Utc).AddTicks(9295), "Western Cape", "Western Cape", new DateTime(2024, 5, 17, 20, 10, 19, 30, DateTimeKind.Utc).AddTicks(9295) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
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
        }
    }
}
