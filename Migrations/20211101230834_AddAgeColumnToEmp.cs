using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUDDemo.Migrations
{
    public partial class AddAgeColumnToEmp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "age",
                table: "Departments");

            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "Employees",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "age",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
