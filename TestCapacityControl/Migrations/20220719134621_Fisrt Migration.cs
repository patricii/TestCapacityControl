using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestCapacityControl.Migrations
{
    public partial class FisrtMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CMW500",
                columns: table => new
                {
                    CMW_Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Updated = table.Column<DateTime>(nullable: false),
                    Site = table.Column<string>(nullable: true),
                    Group = table.Column<string>(nullable: true),
                    Last_Station = table.Column<string>(nullable: true),
                    Id_Motorola = table.Column<int>(nullable: false),
                    Id_Flex = table.Column<int>(nullable: false),
                    SerialNumber = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    KM550_LTE_TDD = table.Column<int>(nullable: false),
                    KM011_QC_CAL = table.Column<int>(nullable: false),
                    KV113_MTK_CAL = table.Column<int>(nullable: false),
                    KM800_CDMA = table.Column<int>(nullable: false),
                    KB036_6GHz = table.Column<int>(nullable: false),
                    KV120_Unisoc = table.Column<int>(nullable: false),
                    WiFi_KM650_KM610 = table.Column<int>(nullable: false),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMW500", x => x.CMW_Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    departments_Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    JobTitle = table.Column<string>(nullable: true),
                    Scope = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.departments_Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    products_Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductName = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.products_Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSetup",
                columns: table => new
                {
                    productSetup_Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Product = table.Column<string>(nullable: true),
                    TestSets = table.Column<string>(nullable: true),
                    PowerSupply = table.Column<string>(nullable: true),
                    License = table.Column<string>(nullable: true),
                    PSAUX = table.Column<string>(nullable: true),
                    TDD = table.Column<string>(nullable: true),
                    Freq6Ghz = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSetup", x => x.productSetup_Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductsTABLET",
                columns: table => new
                {
                    productTablet_Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductName = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsTABLET", x => x.productTablet_Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductUpdateCelular",
                columns: table => new
                {
                    pUC_Id = table.Column<int>(nullable: false)
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
                    table.PrimaryKey("PK_ProductUpdateCelular", x => x.pUC_Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductUpdateTablet",
                columns: table => new
                {
                    pUT_Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductNameUp = table.Column<string>(nullable: true),
                    YieldInline = table.Column<double>(nullable: false),
                    YieldWifi = table.Column<double>(nullable: false),
                    YieldRFCal = table.Column<double>(nullable: false),
                    YieldNSFT = table.Column<double>(nullable: false),
                    YieldRadCurr = table.Column<double>(nullable: false),
                    YieldTOF = table.Column<double>(nullable: false),
                    YieldANT = table.Column<double>(nullable: false),
                    YieldMMI1 = table.Column<double>(nullable: false),
                    YieldMMI2 = table.Column<double>(nullable: false),
                    YieldAudio = table.Column<double>(nullable: false),
                    YieldWriteNumber = table.Column<double>(nullable: false),
                    YieldCFCUp = table.Column<double>(nullable: false),
                    YieldMMI3 = table.Column<double>(nullable: false),
                    NtfInline = table.Column<double>(nullable: false),
                    NtfWifi = table.Column<double>(nullable: false),
                    NtfRFCal = table.Column<double>(nullable: false),
                    NtfNSFT = table.Column<double>(nullable: false),
                    NtfRadCurr = table.Column<double>(nullable: false),
                    NtfTOF = table.Column<double>(nullable: false),
                    NtfANT = table.Column<double>(nullable: false),
                    NtfMMI1 = table.Column<double>(nullable: false),
                    NtfMMI2 = table.Column<double>(nullable: false),
                    NtfAudio = table.Column<double>(nullable: false),
                    NtfWriteNumber = table.Column<double>(nullable: false),
                    NtfCFCUp = table.Column<double>(nullable: false),
                    NtfMMI3 = table.Column<double>(nullable: false),
                    MTimeInline = table.Column<double>(nullable: false),
                    MTimeWifi = table.Column<double>(nullable: false),
                    MTimeRFCal = table.Column<double>(nullable: false),
                    MTimeNSFT = table.Column<double>(nullable: false),
                    MTimeRadCurr = table.Column<double>(nullable: false),
                    MTimeTOF = table.Column<double>(nullable: false),
                    MTimeANT = table.Column<double>(nullable: false),
                    MTimeMMI1 = table.Column<double>(nullable: false),
                    MTimeMMI2 = table.Column<double>(nullable: false),
                    MTimeAudio = table.Column<double>(nullable: false),
                    MTimeWriteNumber = table.Column<double>(nullable: false),
                    MTimeCFCUp = table.Column<double>(nullable: false),
                    MTimeMMI3 = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductUpdateTablet", x => x.pUT_Id);
                });

            migrationBuilder.CreateTable(
                name: "TestProcess",
                columns: table => new
                {
                    testProcess_Id = table.Column<int>(nullable: false)
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
                    table.PrimaryKey("PK_TestProcess", x => x.testProcess_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CMW500");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductSetup");

            migrationBuilder.DropTable(
                name: "ProductsTABLET");

            migrationBuilder.DropTable(
                name: "ProductUpdateCelular");

            migrationBuilder.DropTable(
                name: "ProductUpdateTablet");

            migrationBuilder.DropTable(
                name: "TestProcess");
        }
    }
}
