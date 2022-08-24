using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopSolution.Data.Migrations
{
    public partial class rollbackdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "925a64b7-4ddc-4842-97b0-22f673131c09");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3e3a6031-15f6-4337-bfa8-e82e410bcb06", "AQAAAAEAACcQAAAAEGZqutL9fpZl4NPQOJ1iN7fLpZL8nejTuRrfWEl6utJ3kldwf2sLSqxqqZmaWir/6Q==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 1,
                column: "SeoTitle",
                value: "Sản phẩm áo thời trang nam số 1");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 8, 12, 4, 18, 27, 108, DateTimeKind.Local).AddTicks(3633));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "a838977a-bb11-4edd-a9c9-c9a03a8f6c3c");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3248cf5a-8ceb-44be-99e8-8cc9ead91a44", "AQAAAAEAACcQAAAAEMkjzr4Z/DtMbwSKGO1Es1PEGSYNSXK4/nHjvSA5EZzGbkPzcrNLpXzGPSPg40vShA==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 1,
                column: "SeoTitle",
                value: "Sản phẩm áo thời trang nam");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 8, 11, 12, 23, 16, 401, DateTimeKind.Local).AddTicks(1525));
        }
    }
}
