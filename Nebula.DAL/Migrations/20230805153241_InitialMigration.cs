using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Nebula.DAL.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Type = table.Column<byte>(type: "smallint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Number = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Type = table.Column<byte>(type: "smallint", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cards_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreatedAt", "DateOfBirth", "FirstName", "IsDeleted", "LastName", "Phone", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 8, 5, 15, 32, 41, 737, DateTimeKind.Utc).AddTicks(8247), new DateTime(1988, 4, 6, 20, 0, 0, 0, DateTimeKind.Utc), "Avazbek", false, "Siddiqov", "+998973340334", (byte)3, null },
                    { 2L, new DateTime(2023, 8, 5, 15, 32, 41, 737, DateTimeKind.Utc).AddTicks(8251), new DateTime(1998, 7, 21, 20, 0, 0, 0, DateTimeKind.Utc), "Muqimjon", false, "Mamadaliyev", "+998937349808", (byte)4, null },
                    { 3L, new DateTime(2023, 8, 5, 15, 32, 41, 737, DateTimeKind.Utc).AddTicks(8254), new DateTime(2001, 11, 27, 21, 0, 0, 0, DateTimeKind.Utc), "Abdualim", false, "Normurodov", "+998950642799", (byte)1, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DateOfBirth", "FirstName", "IsDeleted", "LastName", "Phone", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 8, 5, 15, 32, 41, 737, DateTimeKind.Utc).AddTicks(8143), new DateTime(2006, 10, 12, 20, 0, 0, 0, DateTimeKind.Utc), "Iskandar", false, "Qodirov", "+998972350120", null },
                    { 2L, new DateTime(2023, 8, 5, 15, 32, 41, 737, DateTimeKind.Utc).AddTicks(8149), new DateTime(2005, 11, 3, 21, 0, 0, 0, DateTimeKind.Utc), "Madiyor", false, "Odilov", "+998903638333", null },
                    { 3L, new DateTime(2023, 8, 5, 15, 32, 41, 737, DateTimeKind.Utc).AddTicks(8154), new DateTime(2004, 2, 19, 21, 0, 0, 0, DateTimeKind.Utc), "Nodir", false, "Ollonazarov", "+998881813525", null },
                    { 4L, new DateTime(2023, 8, 5, 15, 32, 41, 737, DateTimeKind.Utc).AddTicks(8157), new DateTime(2003, 8, 15, 20, 0, 0, 0, DateTimeKind.Utc), "Nurullo", false, "Nurmatov", "+998330022816", null },
                    { 5L, new DateTime(2023, 8, 5, 15, 32, 41, 737, DateTimeKind.Utc).AddTicks(8161), new DateTime(2002, 8, 17, 20, 0, 0, 0, DateTimeKind.Utc), "Ravshanbek", false, "Isroilov", "+998902528196", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_UserId",
                table: "Cards",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
