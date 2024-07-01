using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotNetCore.API.Migrations
{
    /// <inheritdoc />
    public partial class AddImageDBTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileExtemsion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileSizeInBytes = table.Column<long>(type: "bigint", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("a083a8da-d9a1-4c2d-85e2-f6d1234a56b0"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 15, 11, 42, 26, 184, DateTimeKind.Utc).AddTicks(3191), new DateTime(2024, 6, 15, 11, 42, 26, 184, DateTimeKind.Utc).AddTicks(3191) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("a083a8da-d9a1-4c2d-85e2-f6d1234a56b1"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 15, 11, 42, 26, 184, DateTimeKind.Utc).AddTicks(3193), new DateTime(2024, 6, 15, 11, 42, 26, 184, DateTimeKind.Utc).AddTicks(3193) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("a083a8da-d9a1-4c2d-85e2-f6d1234a56b2"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 15, 11, 42, 26, 184, DateTimeKind.Utc).AddTicks(3194), new DateTime(2024, 6, 15, 11, 42, 26, 184, DateTimeKind.Utc).AddTicks(3194) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("a083a8da-d9a1-4c2d-85e2-f6d1234a56b3"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 15, 11, 42, 26, 184, DateTimeKind.Utc).AddTicks(3195), new DateTime(2024, 6, 15, 11, 42, 26, 184, DateTimeKind.Utc).AddTicks(3196) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("a083a8da-d9a1-4c2d-85e2-f6d1234a56b4"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 15, 11, 42, 26, 184, DateTimeKind.Utc).AddTicks(3197), new DateTime(2024, 6, 15, 11, 42, 26, 184, DateTimeKind.Utc).AddTicks(3197) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("a083a8da-d9a1-4c2d-85e2-f6d1234a56b5"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 15, 11, 42, 26, 184, DateTimeKind.Utc).AddTicks(3198), new DateTime(2024, 6, 15, 11, 42, 26, 184, DateTimeKind.Utc).AddTicks(3198) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("a083a8da-d9a1-4c2d-85e2-f6d1234a56b6"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 15, 11, 42, 26, 184, DateTimeKind.Utc).AddTicks(3199), new DateTime(2024, 6, 15, 11, 42, 26, 184, DateTimeKind.Utc).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("a083a8da-d9a1-4c2d-85e2-f6d1234a56b7"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 15, 11, 42, 26, 184, DateTimeKind.Utc).AddTicks(3201), new DateTime(2024, 6, 15, 11, 42, 26, 184, DateTimeKind.Utc).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("f3604540-6c24-4959-ae2e-8047b7d9f1fb"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 15, 11, 42, 26, 184, DateTimeKind.Utc).AddTicks(3188), new DateTime(2024, 6, 15, 11, 42, 26, 184, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: new Guid("a3a5f2d4-8e92-46c8-9232-f8de57f2c2af"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 15, 11, 42, 26, 184, DateTimeKind.Utc).AddTicks(3219), new DateTime(2024, 6, 15, 11, 42, 26, 184, DateTimeKind.Utc).AddTicks(3220) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("a083a8da-d9a1-4c2d-85e2-f6d1234a56b0"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 15, 8, 38, 12, 797, DateTimeKind.Utc).AddTicks(5285), new DateTime(2024, 6, 15, 8, 38, 12, 797, DateTimeKind.Utc).AddTicks(5285) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("a083a8da-d9a1-4c2d-85e2-f6d1234a56b1"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 15, 8, 38, 12, 797, DateTimeKind.Utc).AddTicks(5287), new DateTime(2024, 6, 15, 8, 38, 12, 797, DateTimeKind.Utc).AddTicks(5287) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("a083a8da-d9a1-4c2d-85e2-f6d1234a56b2"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 15, 8, 38, 12, 797, DateTimeKind.Utc).AddTicks(5288), new DateTime(2024, 6, 15, 8, 38, 12, 797, DateTimeKind.Utc).AddTicks(5288) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("a083a8da-d9a1-4c2d-85e2-f6d1234a56b3"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 15, 8, 38, 12, 797, DateTimeKind.Utc).AddTicks(5289), new DateTime(2024, 6, 15, 8, 38, 12, 797, DateTimeKind.Utc).AddTicks(5290) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("a083a8da-d9a1-4c2d-85e2-f6d1234a56b4"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 15, 8, 38, 12, 797, DateTimeKind.Utc).AddTicks(5291), new DateTime(2024, 6, 15, 8, 38, 12, 797, DateTimeKind.Utc).AddTicks(5291) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("a083a8da-d9a1-4c2d-85e2-f6d1234a56b5"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 15, 8, 38, 12, 797, DateTimeKind.Utc).AddTicks(5292), new DateTime(2024, 6, 15, 8, 38, 12, 797, DateTimeKind.Utc).AddTicks(5292) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("a083a8da-d9a1-4c2d-85e2-f6d1234a56b6"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 15, 8, 38, 12, 797, DateTimeKind.Utc).AddTicks(5294), new DateTime(2024, 6, 15, 8, 38, 12, 797, DateTimeKind.Utc).AddTicks(5294) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("a083a8da-d9a1-4c2d-85e2-f6d1234a56b7"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 15, 8, 38, 12, 797, DateTimeKind.Utc).AddTicks(5295), new DateTime(2024, 6, 15, 8, 38, 12, 797, DateTimeKind.Utc).AddTicks(5295) });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("f3604540-6c24-4959-ae2e-8047b7d9f1fb"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 15, 8, 38, 12, 797, DateTimeKind.Utc).AddTicks(5281), new DateTime(2024, 6, 15, 8, 38, 12, 797, DateTimeKind.Utc).AddTicks(5283) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: new Guid("a3a5f2d4-8e92-46c8-9232-f8de57f2c2af"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 6, 15, 8, 38, 12, 797, DateTimeKind.Utc).AddTicks(5316), new DateTime(2024, 6, 15, 8, 38, 12, 797, DateTimeKind.Utc).AddTicks(5316) });
        }
    }
}
