using Microsoft.EntityFrameworkCore.Migrations;

namespace TestCapacityControl.Migrations
{
    public partial class Department_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "scope",
                table: "Departments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "scope",
                table: "Departments");
        }
    }
}
