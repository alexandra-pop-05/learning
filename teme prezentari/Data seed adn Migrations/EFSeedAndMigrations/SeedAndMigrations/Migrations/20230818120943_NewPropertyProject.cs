using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeedAndMigrations.Migrations
{
    /// <inheritdoc />
    public partial class NewPropertyProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Version",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "MyEventId", "Date", "Description", "Name" },
                values: new object[] { 5, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Event4" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "Version",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "Version",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "MyEventId",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Projects");
        }
    }
}
