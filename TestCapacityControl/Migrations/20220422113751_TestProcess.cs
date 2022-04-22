using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestCapacityControl.Migrations
{
    public partial class TestProcess : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TestProcess",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Technology = table.Column<string>(nullable: true),
                    L2 = table.Column<string>(nullable: true),
                    M2 = table.Column<string>(nullable: true),
                    JOT_Slim = table.Column<string>(nullable: true),
                    JOT = table.Column<string>(nullable: true),
                    WUHAN_L2 = table.Column<string>(nullable: true),
                    WUHAN_JOT_Slim = table.Column<string>(nullable: true),
                    WUHAN_JOT = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestProcess", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestProcess");
        }
    }
}
