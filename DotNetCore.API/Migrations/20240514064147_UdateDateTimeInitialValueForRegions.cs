using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DotNetCore.API.Migrations
{
    /// <inheritdoc />
    public partial class UdateDateTimeInitialValueForRegions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("10045b8d-eab8-443a-9a00-a89cea107ceb"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("14005786-9e8a-40fc-81e7-786a8126c849"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("61651895-cbe3-4374-b78c-27cc43875e10"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("6184cb87-e003-4d32-b015-fdd5b1c426b8"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("8288bee7-1bc0-4486-b6dd-0d5314beb8c3"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("83b431a4-adb5-47aa-bdbc-5725434e9adc"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("91f159fa-e0fc-405a-b514-eaeb402a3f94"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("bcfdc662-dd43-4c31-9886-7cfe79403dc0"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("d6599809-fc21-463c-8e6e-48f0f69d6676"));

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "CreatedDate", "Description", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1592448c-d360-4923-a215-9a0d3b72ce04"), "FS", new DateTime(2024, 5, 14, 6, 41, 46, 898, DateTimeKind.Utc).AddTicks(5939), "Free State", "Free State", new DateTime(2024, 5, 14, 6, 41, 46, 898, DateTimeKind.Utc).AddTicks(5940) },
                    { new Guid("34a5804b-2d2d-46d4-a392-88db2c61e74a"), "NC", new DateTime(2024, 5, 14, 6, 41, 46, 898, DateTimeKind.Utc).AddTicks(5954), "Northern Cape", "Northern Cape", new DateTime(2024, 5, 14, 6, 41, 46, 898, DateTimeKind.Utc).AddTicks(5955) },
                    { new Guid("6d2d4562-bda8-47c1-99bf-269fe0f4e316"), "MP", new DateTime(2024, 5, 14, 6, 41, 46, 898, DateTimeKind.Utc).AddTicks(5951), "Mpumalanga", "Mpumalanga", new DateTime(2024, 5, 14, 6, 41, 46, 898, DateTimeKind.Utc).AddTicks(5951) },
                    { new Guid("73152684-a021-4570-9c65-a25ac464a95f"), "LP", new DateTime(2024, 5, 14, 6, 41, 46, 898, DateTimeKind.Utc).AddTicks(5949), "Limpopo", "Limpopo", new DateTime(2024, 5, 14, 6, 41, 46, 898, DateTimeKind.Utc).AddTicks(5949) },
                    { new Guid("97db5a1f-16b1-4c37-b65c-1b71c42d3c96"), "EC", new DateTime(2024, 5, 14, 6, 41, 46, 898, DateTimeKind.Utc).AddTicks(5938), "Eastern Cape", "Eastern Cape", new DateTime(2024, 5, 14, 6, 41, 46, 898, DateTimeKind.Utc).AddTicks(5938) },
                    { new Guid("abf169d4-1b6c-4df8-9340-6e1d909d037e"), "GP", new DateTime(2024, 5, 14, 6, 41, 46, 898, DateTimeKind.Utc).AddTicks(5933), "Gauteng Province", "Gauteng", new DateTime(2024, 5, 14, 6, 41, 46, 898, DateTimeKind.Utc).AddTicks(5934) },
                    { new Guid("f812bcff-cf06-4139-8072-ab9337cf46d4"), "NW", new DateTime(2024, 5, 14, 6, 41, 46, 898, DateTimeKind.Utc).AddTicks(5952), "North West", "North West", new DateTime(2024, 5, 14, 6, 41, 46, 898, DateTimeKind.Utc).AddTicks(5953) },
                    { new Guid("fce71014-9759-4fa3-8acb-235a49d10e70"), "WC", new DateTime(2024, 5, 14, 6, 41, 46, 898, DateTimeKind.Utc).AddTicks(5956), "Western Cape", "Western Cape", new DateTime(2024, 5, 14, 6, 41, 46, 898, DateTimeKind.Utc).AddTicks(5956) },
                    { new Guid("fd618ce5-294e-4a62-bbfb-c43ae0f013c8"), "GP", new DateTime(2024, 5, 14, 6, 41, 46, 898, DateTimeKind.Utc).AddTicks(5936), "KwaZulu-Natal", "KwaZulu-Natal", new DateTime(2024, 5, 14, 6, 41, 46, 898, DateTimeKind.Utc).AddTicks(5937) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("1592448c-d360-4923-a215-9a0d3b72ce04"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("34a5804b-2d2d-46d4-a392-88db2c61e74a"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("6d2d4562-bda8-47c1-99bf-269fe0f4e316"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("73152684-a021-4570-9c65-a25ac464a95f"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("97db5a1f-16b1-4c37-b65c-1b71c42d3c96"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("abf169d4-1b6c-4df8-9340-6e1d909d037e"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("f812bcff-cf06-4139-8072-ab9337cf46d4"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("fce71014-9759-4fa3-8acb-235a49d10e70"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("fd618ce5-294e-4a62-bbfb-c43ae0f013c8"));

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "CreatedDate", "Description", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("10045b8d-eab8-443a-9a00-a89cea107ceb"), "GP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gauteng Province", "Gauteng", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("14005786-9e8a-40fc-81e7-786a8126c849"), "LP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Limpopo", "Limpopo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("61651895-cbe3-4374-b78c-27cc43875e10"), "KZN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KwaZulu-Natal", "KwaZulu-Natal", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6184cb87-e003-4d32-b015-fdd5b1c426b8"), "WC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Western Cape", "Western Cape", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8288bee7-1bc0-4486-b6dd-0d5314beb8c3"), "MP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mpumalanga", "Mpumalanga", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("83b431a4-adb5-47aa-bdbc-5725434e9adc"), "NW", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "North West", "North West", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("91f159fa-e0fc-405a-b514-eaeb402a3f94"), "NC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Northern Cape", "Northern Cape", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bcfdc662-dd43-4c31-9886-7cfe79403dc0"), "EC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eastern Cape", "Eastern Cape", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d6599809-fc21-463c-8e6e-48f0f69d6676"), "FS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Free State", "Free State", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
