using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestCapacityControl.Migrations
{
    public partial class ProductUpgradeCelular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductUpdateCelular",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductNameUp = table.Column<string>(nullable: true),
                    YieldInline = table.Column<double>(nullable: false),
                    YieldBrdTest = table.Column<double>(nullable: false),
                    YieldBoardTst = table.Column<double>(nullable: false),
                    Yield5GFR = table.Column<double>(nullable: false),
                    YieldDCAL = table.Column<double>(nullable: false),
                    YieldDVAL = table.Column<double>(nullable: false),
                    YieldCamCAL = table.Column<double>(nullable: false),
                    YieldCamVAL = table.Column<double>(nullable: false),
                    YieldJOT = table.Column<double>(nullable: false),
                    YieldL2Vision = table.Column<double>(nullable: false),
                    YieldL2AR = table.Column<double>(nullable: false),
                    YieldM2Cam = table.Column<double>(nullable: false),
                    YieldM2AR = table.Column<double>(nullable: false),
                    YieldJotSlim = table.Column<double>(nullable: false),
                    YieldARSlim = table.Column<double>(nullable: false),
                    YieldCFC = table.Column<double>(nullable: false),
                    YieldPatsJot = table.Column<double>(nullable: false),
                    YieldPatsM2 = table.Column<double>(nullable: false),
                    YieldPatsSlim = table.Column<double>(nullable: false),
                    NtfInline = table.Column<double>(nullable: false),
                    NtfBrdTest = table.Column<double>(nullable: false),
                    NtfBoardTst = table.Column<double>(nullable: false),
                    Ntf5GFR = table.Column<double>(nullable: false),
                    NtfDCAL = table.Column<double>(nullable: false),
                    NtfDVAL = table.Column<double>(nullable: false),
                    NtfCamCAL = table.Column<double>(nullable: false),
                    NtfCamVAL = table.Column<double>(nullable: false),
                    NtfJOT = table.Column<double>(nullable: false),
                    NtfL2Vision = table.Column<double>(nullable: false),
                    NtfL2AR = table.Column<double>(nullable: false),
                    NtfM2Cam = table.Column<double>(nullable: false),
                    NtfM2AR = table.Column<double>(nullable: false),
                    NtfJotSlim = table.Column<double>(nullable: false),
                    NtfARSlim = table.Column<double>(nullable: false),
                    NtfCFC = table.Column<double>(nullable: false),
                    NtfPatsJot = table.Column<double>(nullable: false),
                    NtfPatsM2 = table.Column<double>(nullable: false),
                    NtfPatsSlim = table.Column<double>(nullable: false),
                    MTimeInline = table.Column<double>(nullable: false),
                    MTimeBrdTest = table.Column<double>(nullable: false),
                    MTimeBoardTst = table.Column<double>(nullable: false),
                    MTime5GFR = table.Column<double>(nullable: false),
                    MTimeDCAL = table.Column<double>(nullable: false),
                    MTimeDVAL = table.Column<double>(nullable: false),
                    MTimeCamCAL = table.Column<double>(nullable: false),
                    MTimeCamVAL = table.Column<double>(nullable: false),
                    MTimeJOT = table.Column<double>(nullable: false),
                    MTimeL2Vision = table.Column<double>(nullable: false),
                    MTimeL2AR = table.Column<double>(nullable: false),
                    MTimeM2Cam = table.Column<double>(nullable: false),
                    MTimeM2AR = table.Column<double>(nullable: false),
                    MTimeJotSlim = table.Column<double>(nullable: false),
                    MTimeARSlim = table.Column<double>(nullable: false),
                    MTimeCFC = table.Column<double>(nullable: false),
                    MTimePatsJot = table.Column<double>(nullable: false),
                    MTimePatsM2 = table.Column<double>(nullable: false),
                    MTimePatsSlim = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductUpdateCelular", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductUpdateCelular");
        }
    }
}
