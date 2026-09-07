using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCorePractice.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEmployeeModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreation",
                table: "Departments",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2026, 9, 7, 14, 53, 32, 45, DateTimeKind.Local).AddTicks(6555));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreation",
                table: "Departments",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2026, 9, 7, 14, 53, 32, 45, DateTimeKind.Local).AddTicks(6555),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
