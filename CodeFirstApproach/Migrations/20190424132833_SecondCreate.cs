using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApproach.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Student Profile");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "Course Details");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Student Profile",
                newName: "Student Name");

            migrationBuilder.AddColumn<DateTime>(
                name: "DOB",
                table: "Student Profile",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student Profile",
                table: "Student Profile",
                column: "StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course Details",
                table: "Course Details",
                column: "CourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Student Profile",
                table: "Student Profile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course Details",
                table: "Course Details");

            migrationBuilder.DropColumn(
                name: "DOB",
                table: "Student Profile");

            migrationBuilder.RenameTable(
                name: "Student Profile",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "Course Details",
                newName: "Courses");

            migrationBuilder.RenameColumn(
                name: "Student Name",
                table: "Students",
                newName: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "CourseId");
        }
    }
}
