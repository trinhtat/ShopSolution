using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopSolution.Data.Migrations
{
    public partial class updatedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_AppUsers_UserId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AppUsers_UserId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_AppUsers_UserId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_UserId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Carts_UserId",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "AppRoles");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "AppRoles");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "AppRoles");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "AppRoles");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "AppRoles");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "AppRoles");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "AppRoles");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "AppRoles");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "AppRoles");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "AppRoles");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "AppRoles");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "AppRoles");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "AppRoles");

            migrationBuilder.AddColumn<Guid>(
                name: "AppUserId",
                table: "Transactions",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AppUserId",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AppUserId",
                table: "Carts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AppRoles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedName",
                table: "AppRoles",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "b7583d77-2f5d-4df6-89c3-24982338aff5");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "735684b7-ab69-4a94-8c2e-d4c6348bd298", "AQAAAAEAACcQAAAAENA89idNUhVBp54DniHX0NOCgiilSTI3yPj0Ynk1BRw+Xia8lzhaaFPT0IX1TWYZbg==" });

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
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 8, 12, 20, 23, 54, 752, DateTimeKind.Local).AddTicks(7344));

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_AppUserId",
                table: "Transactions",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AppUserId",
                table: "Orders",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_AppUserId",
                table: "Carts",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_AppUsers_AppUserId",
                table: "Carts",
                column: "AppUserId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AppUsers_AppUserId",
                table: "Orders",
                column: "AppUserId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_AppUsers_AppUserId",
                table: "Transactions",
                column: "AppUserId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_AppUsers_AppUserId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AppUsers_AppUserId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_AppUsers_AppUserId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_AppUserId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Orders_AppUserId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Carts_AppUserId",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AppRoles");

            migrationBuilder.DropColumn(
                name: "NormalizedName",
                table: "AppRoles");

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "AppRoles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "AppRoles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "AppRoles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "AppRoles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "AppRoles",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "AppRoles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "AppRoles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "AppRoles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "AppRoles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "AppRoles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "AppRoles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "AppRoles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "AppRoles",
                type: "nvarchar(max)",
                nullable: true);

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
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 8, 12, 4, 18, 27, 108, DateTimeKind.Local).AddTicks(3633));

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_UserId",
                table: "Transactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_AppUsers_UserId",
                table: "Carts",
                column: "UserId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AppUsers_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_AppUsers_UserId",
                table: "Transactions",
                column: "UserId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
