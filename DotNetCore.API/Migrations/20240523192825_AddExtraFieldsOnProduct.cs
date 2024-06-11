using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DotNetCore.API.Migrations
{
    /// <inheritdoc />
    public partial class AddExtraFieldsOnProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("15eb53f2-37a8-4c13-b0c2-2e4aa4fc782d"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("260ac91a-ab3f-4717-bfe9-13fc52c4d8d8"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("31190107-d560-434e-959e-dafc7be85a98"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("4bb05fd0-1489-4c49-ad27-8216b4d6a516"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("724cb957-06c4-40de-aa86-b3ecf46b99f1"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("7a799857-3ee9-4942-8f4e-eb70a02f2378"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("8ab903a5-0b44-4c2f-8402-dfc7f3df8e5e"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("c565f77b-b5e1-4025-8813-e99b621ad187"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("cd6d1690-42fe-4194-9471-fd62062cb0ae"));

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Products",
                newName: "SalePrice");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "CostPrice",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "IsActive",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "SupplierId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CostPrice",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "SalePrice",
                table: "Products",
                newName: "Price");

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
        }
    }
}
