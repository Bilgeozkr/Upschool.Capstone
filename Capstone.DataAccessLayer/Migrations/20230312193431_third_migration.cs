using Microsoft.EntityFrameworkCore.Migrations;

namespace Capstone.DataAccessLayer.Migrations
{
    public partial class third_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeStatus",
                table: "Employees",
                newName: "EmployeeStatus");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeeStatus",
                table: "Employees",
                newName: "EmployeStatus");
        }
    }
}
