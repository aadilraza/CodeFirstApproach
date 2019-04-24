using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstApproach.Migrations
{
    public partial class ThirdCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DOB",
                table: "Student Profile",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(2019, 4, 24, 18, 42, 20, 704, DateTimeKind.Local).AddTicks(724),
                oldClrType: typeof(DateTime),
                oldType: "DateTime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DOB",
                table: "Student Profile",
                type: "DateTime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime2",
                oldDefaultValue: new DateTime(2019, 4, 24, 18, 42, 20, 704, DateTimeKind.Local).AddTicks(724));
        }
    }
}
