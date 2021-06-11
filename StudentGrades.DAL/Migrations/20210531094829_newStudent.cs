using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentGrades.DAL.Migrations
{
    public partial class newStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Students",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhoneNumber",
                value: "36206547654");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhoneNumber",
                value: "36206526594");

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "Name", "PhoneNumber", "Year" },
                values: new object[] { 3, new DateTime(2003, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kala Pál", "36207629921", 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<long>(
                name: "PhoneNumber",
                table: "Students",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhoneNumber",
                value: 36206547654L);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhoneNumber",
                value: 36206526594L);
        }
    }
}
