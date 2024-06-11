using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DotNetCore.API.Migrations
{
    /// <inheritdoc />
    public partial class AddSupplierTableAndInitialValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("1b5e4d54-0042-46ad-8324-99948f886b99"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("48c98496-9e0c-4017-801e-b2baf497d352"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("5d702b3c-68d5-4fc7-ab3b-016e1bb80c08"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("72caccf4-cd44-4684-9768-2b8f86b6666b"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("cd634cd7-c855-4a3a-bcc4-f7c1247566c0"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("cdc8d7fa-61b1-4e9e-ba0b-e1e5002d5a9a"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("dfef6e13-3902-40af-8d3d-a7508aec8141"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("f5eb077e-aa22-44b0-897b-b58a1b279573"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("f7058303-095f-4d35-9d35-fe6248445746"));

            migrationBuilder.CreateTable(
                name: "Suppiers",
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
                    table.PrimaryKey("PK_Suppiers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "CreatedDate", "Description", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("13d510fc-80ed-43f0-9601-d0d88d092e39"), "EC", new DateTime(2024, 5, 23, 20, 16, 2, 318, DateTimeKind.Utc).AddTicks(8418), "Eastern Cape", "Eastern Cape", new DateTime(2024, 5, 23, 20, 16, 2, 318, DateTimeKind.Utc).AddTicks(8419) },
                    { new Guid("2e43d2da-85ee-4f05-9847-7b07cc5e0719"), "GP", new DateTime(2024, 5, 23, 20, 16, 2, 318, DateTimeKind.Utc).AddTicks(8392), "Gauteng Province", "Gauteng", new DateTime(2024, 5, 23, 20, 16, 2, 318, DateTimeKind.Utc).AddTicks(8393) },
                    { new Guid("455268eb-3cc5-434c-9771-a64d8343507a"), "WC", new DateTime(2024, 5, 23, 20, 16, 2, 318, DateTimeKind.Utc).AddTicks(8450), "Western Cape", "Western Cape", new DateTime(2024, 5, 23, 20, 16, 2, 318, DateTimeKind.Utc).AddTicks(8450) },
                    { new Guid("480165f1-9781-4e8d-b90c-0253ea900fd2"), "NW", new DateTime(2024, 5, 23, 20, 16, 2, 318, DateTimeKind.Utc).AddTicks(8425), "North West", "North West", new DateTime(2024, 5, 23, 20, 16, 2, 318, DateTimeKind.Utc).AddTicks(8425) },
                    { new Guid("496aa535-e342-4c25-a37b-f0288a5507a4"), "LP", new DateTime(2024, 5, 23, 20, 16, 2, 318, DateTimeKind.Utc).AddTicks(8422), "Limpopo", "Limpopo", new DateTime(2024, 5, 23, 20, 16, 2, 318, DateTimeKind.Utc).AddTicks(8422) },
                    { new Guid("9ca66e8a-ade1-415d-b008-05f792038fd6"), "FS", new DateTime(2024, 5, 23, 20, 16, 2, 318, DateTimeKind.Utc).AddTicks(8420), "Free State", "Free State", new DateTime(2024, 5, 23, 20, 16, 2, 318, DateTimeKind.Utc).AddTicks(8421) },
                    { new Guid("c3a1c7bb-f832-415e-acd7-d0b2654ea868"), "NC", new DateTime(2024, 5, 23, 20, 16, 2, 318, DateTimeKind.Utc).AddTicks(8426), "Northern Cape", "Northern Cape", new DateTime(2024, 5, 23, 20, 16, 2, 318, DateTimeKind.Utc).AddTicks(8426) },
                    { new Guid("d42863e6-238b-4c7a-a556-3a4bf4d31a6f"), "GP", new DateTime(2024, 5, 23, 20, 16, 2, 318, DateTimeKind.Utc).AddTicks(8395), "KwaZulu-Natal", "KwaZulu-Natal", new DateTime(2024, 5, 23, 20, 16, 2, 318, DateTimeKind.Utc).AddTicks(8395) },
                    { new Guid("f1c7c74e-a72f-4fc0-bd62-87e41940056a"), "MP", new DateTime(2024, 5, 23, 20, 16, 2, 318, DateTimeKind.Utc).AddTicks(8423), "Mpumalanga", "Mpumalanga", new DateTime(2024, 5, 23, 20, 16, 2, 318, DateTimeKind.Utc).AddTicks(8423) }
                });

            migrationBuilder.InsertData(
                table: "Suppiers",
                columns: new[] { "Id", "CreatedDate", "IsActive", "Name", "UpdatedDate", "VendorCode" },
                values: new object[] { new Guid("f684b2b1-ec31-40d6-9693-c70c76860e45"), new DateTime(2024, 5, 23, 20, 16, 2, 318, DateTimeKind.Utc).AddTicks(8532), 1, "The Prepaid Company", new DateTime(2024, 5, 23, 20, 16, 2, 318, DateTimeKind.Utc).AddTicks(8533), "TPC" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Suppiers");

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("13d510fc-80ed-43f0-9601-d0d88d092e39"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("2e43d2da-85ee-4f05-9847-7b07cc5e0719"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("455268eb-3cc5-434c-9771-a64d8343507a"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("480165f1-9781-4e8d-b90c-0253ea900fd2"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("496aa535-e342-4c25-a37b-f0288a5507a4"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("9ca66e8a-ade1-415d-b008-05f792038fd6"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("c3a1c7bb-f832-415e-acd7-d0b2654ea868"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("d42863e6-238b-4c7a-a556-3a4bf4d31a6f"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("f1c7c74e-a72f-4fc0-bd62-87e41940056a"));

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "CreatedDate", "Description", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1b5e4d54-0042-46ad-8324-99948f886b99"), "EC", new DateTime(2024, 5, 23, 19, 28, 24, 725, DateTimeKind.Utc).AddTicks(9552), "Eastern Cape", "Eastern Cape", new DateTime(2024, 5, 23, 19, 28, 24, 725, DateTimeKind.Utc).AddTicks(9552) },
                    { new Guid("48c98496-9e0c-4017-801e-b2baf497d352"), "WC", new DateTime(2024, 5, 23, 19, 28, 24, 725, DateTimeKind.Utc).AddTicks(9588), "Western Cape", "Western Cape", new DateTime(2024, 5, 23, 19, 28, 24, 725, DateTimeKind.Utc).AddTicks(9589) },
                    { new Guid("5d702b3c-68d5-4fc7-ab3b-016e1bb80c08"), "GP", new DateTime(2024, 5, 23, 19, 28, 24, 725, DateTimeKind.Utc).AddTicks(9550), "KwaZulu-Natal", "KwaZulu-Natal", new DateTime(2024, 5, 23, 19, 28, 24, 725, DateTimeKind.Utc).AddTicks(9550) },
                    { new Guid("72caccf4-cd44-4684-9768-2b8f86b6666b"), "FS", new DateTime(2024, 5, 23, 19, 28, 24, 725, DateTimeKind.Utc).AddTicks(9554), "Free State", "Free State", new DateTime(2024, 5, 23, 19, 28, 24, 725, DateTimeKind.Utc).AddTicks(9554) },
                    { new Guid("cd634cd7-c855-4a3a-bcc4-f7c1247566c0"), "GP", new DateTime(2024, 5, 23, 19, 28, 24, 725, DateTimeKind.Utc).AddTicks(9539), "Gauteng Province", "Gauteng", new DateTime(2024, 5, 23, 19, 28, 24, 725, DateTimeKind.Utc).AddTicks(9544) },
                    { new Guid("cdc8d7fa-61b1-4e9e-ba0b-e1e5002d5a9a"), "MP", new DateTime(2024, 5, 23, 19, 28, 24, 725, DateTimeKind.Utc).AddTicks(9557), "Mpumalanga", "Mpumalanga", new DateTime(2024, 5, 23, 19, 28, 24, 725, DateTimeKind.Utc).AddTicks(9557) },
                    { new Guid("dfef6e13-3902-40af-8d3d-a7508aec8141"), "NC", new DateTime(2024, 5, 23, 19, 28, 24, 725, DateTimeKind.Utc).AddTicks(9587), "Northern Cape", "Northern Cape", new DateTime(2024, 5, 23, 19, 28, 24, 725, DateTimeKind.Utc).AddTicks(9587) },
                    { new Guid("f5eb077e-aa22-44b0-897b-b58a1b279573"), "LP", new DateTime(2024, 5, 23, 19, 28, 24, 725, DateTimeKind.Utc).AddTicks(9555), "Limpopo", "Limpopo", new DateTime(2024, 5, 23, 19, 28, 24, 725, DateTimeKind.Utc).AddTicks(9556) },
                    { new Guid("f7058303-095f-4d35-9d35-fe6248445746"), "NW", new DateTime(2024, 5, 23, 19, 28, 24, 725, DateTimeKind.Utc).AddTicks(9585), "North West", "North West", new DateTime(2024, 5, 23, 19, 28, 24, 725, DateTimeKind.Utc).AddTicks(9585) }
                });
        }
    }
}
