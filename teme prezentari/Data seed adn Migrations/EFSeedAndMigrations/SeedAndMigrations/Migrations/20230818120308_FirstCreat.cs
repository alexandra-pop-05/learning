using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SeedAndMigrations.Migrations
{
    /// <inheritdoc />
    public partial class FirstCreat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    MyEventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.MyEventId);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    MyEventId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Events_MyEventId",
                        column: x => x.MyEventId,
                        principalTable: "Events",
                        principalColumn: "MyEventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "MyEventId", "Date", "Description", "Name" },
                values: new object[,]
                {
                    { 2, new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Event2" },
                    { 3, new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Event3" },
                    { 4, new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Event4" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "Name" },
                values: new object[,]
                {
                    { 1, "Project1" },
                    { 2, "Project1" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "LastName", "MyEventId", "ProjectId" },
                values: new object[,]
                {
                    { 1, "Maria", "Pop", 2, 1 },
                    { 2, "Alex", "Muresan", 3, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_MyEventId",
                table: "Users",
                column: "MyEventId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ProjectId",
                table: "Users",
                column: "ProjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
