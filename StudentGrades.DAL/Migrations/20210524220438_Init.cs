using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentGrades.DAL.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OwnerId = table.Column<int>(type: "INTEGER", nullable: false),
                    Value = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grades_Students_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "Name", "PhoneNumber", "Year" },
                values: new object[] { 1, new DateTime(2005, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teszt Elek", 36206547654L, 6 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "Name", "PhoneNumber", "Year" },
                values: new object[] { 2, new DateTime(2006, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bádog Béla", 36206526594L, 4 });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "OwnerId", "Value" },
                values: new object[] { 1, 1, 3 });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "OwnerId", "Value" },
                values: new object[] { 2, 1, 1 });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "OwnerId", "Value" },
                values: new object[] { 3, 1, 4 });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "OwnerId", "Value" },
                values: new object[] { 4, 2, 3 });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "OwnerId", "Value" },
                values: new object[] { 5, 2, 2 });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "OwnerId", "Value" },
                values: new object[] { 6, 2, 5 });

            migrationBuilder.CreateIndex(
                name: "IX_Grades_OwnerId",
                table: "Grades",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
