using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DotNetCore.API.Migrations
{
    /// <inheritdoc />
    public partial class udateSupplierIdField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "Suppiers",
                keyColumn: "Id",
                keyValue: new Guid("f684b2b1-ec31-40d6-9693-c70c76860e45"));

            migrationBuilder.RenameColumn(
                name: "SuppierId",
                table: "Products",
                newName: "SupplierId");

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "CreatedDate", "Description", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1cb39730-ba8b-4192-9cb3-f904bf08ce36"), "FS", new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4809), "Free State", "Free State", new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4809) },
                    { new Guid("2ad69f04-3f02-4b63-a8b0-a56b0ac57ed2"), "LP", new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4810), "Limpopo", "Limpopo", new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4811) },
                    { new Guid("4c09933a-5c31-4a21-9a39-ac277f26ba2d"), "GP", new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4793), "Gauteng Province", "Gauteng", new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4794) },
                    { new Guid("54d4f86d-3e8e-4ecb-9bc8-b25371e85c7d"), "EC", new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4807), "Eastern Cape", "Eastern Cape", new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4807) },
                    { new Guid("80c2cef2-fe86-4853-8388-a5e21868cfee"), "NW", new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4814), "North West", "North West", new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4814) },
                    { new Guid("95f410ba-df39-40bc-8246-e380c2374747"), "MP", new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4812), "Mpumalanga", "Mpumalanga", new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4812) },
                    { new Guid("ce4d77f5-924b-45d5-bbec-783203cd7381"), "WC", new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4817), "Western Cape", "Western Cape", new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4817) },
                    { new Guid("e663f227-29b6-45f7-8d29-d113323364c0"), "NC", new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4816), "Northern Cape", "Northern Cape", new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4816) },
                    { new Guid("f97bd724-d791-49eb-b573-9677f7c954aa"), "GP", new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4797), "KwaZulu-Natal", "KwaZulu-Natal", new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4797) }
                });

            migrationBuilder.InsertData(
                table: "Suppiers",
                columns: new[] { "Id", "CreatedDate", "IsActive", "Name", "UpdatedDate", "VendorCode" },
                values: new object[] { new Guid("26fd66b3-8a2f-4315-b26f-b748f82f2149"), new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4924), 1, "The Prepaid Company", new DateTime(2024, 5, 24, 12, 14, 47, 98, DateTimeKind.Utc).AddTicks(4925), "TPC" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierId",
                table: "Products",
                column: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Suppiers_SupplierId",
                table: "Products",
                column: "SupplierId",
                principalTable: "Suppiers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Suppiers_SupplierId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SupplierId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("1cb39730-ba8b-4192-9cb3-f904bf08ce36"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("2ad69f04-3f02-4b63-a8b0-a56b0ac57ed2"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("4c09933a-5c31-4a21-9a39-ac277f26ba2d"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("54d4f86d-3e8e-4ecb-9bc8-b25371e85c7d"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("80c2cef2-fe86-4853-8388-a5e21868cfee"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("95f410ba-df39-40bc-8246-e380c2374747"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("ce4d77f5-924b-45d5-bbec-783203cd7381"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("e663f227-29b6-45f7-8d29-d113323364c0"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("f97bd724-d791-49eb-b573-9677f7c954aa"));

            migrationBuilder.DeleteData(
                table: "Suppiers",
                keyColumn: "Id",
                keyValue: new Guid("26fd66b3-8a2f-4315-b26f-b748f82f2149"));

            migrationBuilder.RenameColumn(
                name: "SupplierId",
                table: "Products",
                newName: "SuppierId");

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
    }
}
