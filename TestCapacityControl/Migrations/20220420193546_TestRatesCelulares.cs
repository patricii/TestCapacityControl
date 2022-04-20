using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestCapacityControl.Migrations
{
    public partial class TestRatesCelulares : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TestRatesCelular",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    product = table.Column<string>(nullable: true),
                    CFCUph = table.Column<double>(nullable: false),
                    CFCNt = table.Column<double>(nullable: false),
                    PatsJotUph = table.Column<double>(nullable: false),
                    PatsM2Uph = table.Column<double>(nullable: false),
                    JOTSlimUph = table.Column<double>(nullable: false),
                    JOTSlimPsps = table.Column<int>(nullable: false),
                    JotSlimSpr = table.Column<int>(nullable: false),
                    JOTSlimTotalUph = table.Column<double>(nullable: false),
                    JOTSlimNt = table.Column<double>(nullable: false),
                    L2ArSlimUph = table.Column<double>(nullable: false),
                    L2ArSlimFxt = table.Column<int>(nullable: false),
                    L2ArSlimSpr = table.Column<int>(nullable: false),
                    L2ArSlimTotalUph = table.Column<double>(nullable: false),
                    L2ArSlimNt = table.Column<double>(nullable: false),
                    PATSSlimUph = table.Column<double>(nullable: false),
                    CAMVALSlimUph = table.Column<double>(nullable: false),
                    CAMVALSlimFxt = table.Column<int>(nullable: false),
                    CAMVALSlimSpr = table.Column<int>(nullable: false),
                    CAMVALSlimTotalUph = table.Column<double>(nullable: false),
                    CAMVALSlimNt = table.Column<double>(nullable: false),
                    CAMCALSlimUph = table.Column<double>(nullable: false),
                    CAMCALSlimFxt = table.Column<int>(nullable: false),
                    CAMCALSlimSpr = table.Column<int>(nullable: false),
                    CAMCALSlimTotalUph = table.Column<double>(nullable: false),
                    CAMCALSlimNt = table.Column<double>(nullable: false),
                    FODSlimUph = table.Column<double>(nullable: false),
                    FODSlimFxt = table.Column<int>(nullable: false),
                    FODSlimSpr = table.Column<int>(nullable: false),
                    FODSlimTotalUph = table.Column<double>(nullable: false),
                    FODSlimNt = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestRatesCelular", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestRatesCelular");
        }
    }
}
