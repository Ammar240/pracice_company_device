using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCorePractice.Migrations
{
    /// <inheritdoc />
    public partial class DepartmentMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DeptId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dept_Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValue: "Dept"),
                    DateOfCreation = table.Column<DateTime>(type: "DateTime", nullable: false, defaultValue: new DateTime(2026, 9, 7, 14, 53, 32, 45, DateTimeKind.Local).AddTicks(6555))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DeptId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
