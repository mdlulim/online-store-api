using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DotNetCore.API.Migrations
{
    /// <inheritdoc />
    public partial class AddInitialValueForRegions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
