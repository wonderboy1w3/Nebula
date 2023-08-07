using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nebula.DAL.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "UserId1",
                table: "Cards",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 6, 12, 28, 59, 862, DateTimeKind.Utc).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 6, 12, 28, 59, 862, DateTimeKind.Utc).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 6, 12, 28, 59, 862, DateTimeKind.Utc).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 6, 12, 28, 59, 862, DateTimeKind.Utc).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 6, 12, 28, 59, 862, DateTimeKind.Utc).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 6, 12, 28, 59, 862, DateTimeKind.Utc).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 6, 12, 28, 59, 862, DateTimeKind.Utc).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 6, 12, 28, 59, 862, DateTimeKind.Utc).AddTicks(5725));

            migrationBuilder.CreateIndex(
                name: "IX_Cards_UserId1",
                table: "Cards",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Users_UserId1",
                table: "Cards",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Users_UserId1",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Cards_UserId1",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Cards");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 5, 15, 32, 41, 737, DateTimeKind.Utc).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 5, 15, 32, 41, 737, DateTimeKind.Utc).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 5, 15, 32, 41, 737, DateTimeKind.Utc).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 5, 15, 32, 41, 737, DateTimeKind.Utc).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 5, 15, 32, 41, 737, DateTimeKind.Utc).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 5, 15, 32, 41, 737, DateTimeKind.Utc).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 5, 15, 32, 41, 737, DateTimeKind.Utc).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 5, 15, 32, 41, 737, DateTimeKind.Utc).AddTicks(8161));
        }
    }
}
