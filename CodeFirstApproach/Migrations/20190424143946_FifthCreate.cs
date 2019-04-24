using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApproach.Migrations
{
    public partial class FifthCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Student Profile",
                columns: new[] { "StudentId", "DOB", "Student Name" },
                values: new object[] { 1, new DateTime(2019, 4, 24, 19, 39, 46, 328, DateTimeKind.Local).AddTicks(6464), "William" });

            migrationBuilder.InsertData(
                table: "Student Profile",
                columns: new[] { "StudentId", "DOB", "Student Name" },
                values: new object[] { 2, new DateTime(2019, 4, 24, 19, 39, 46, 328, DateTimeKind.Local).AddTicks(6464), "Henry" });

            migrationBuilder.InsertData(
                table: "Student Profile",
                columns: new[] { "StudentId", "DOB", "Student Name" },
                values: new object[] { 3, new DateTime(2019, 4, 24, 19, 39, 46, 328, DateTimeKind.Local).AddTicks(6464), "Messi" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student Profile",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Student Profile",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Student Profile",
                keyColumn: "StudentId",
                keyValue: 3);
        }
    }
}
