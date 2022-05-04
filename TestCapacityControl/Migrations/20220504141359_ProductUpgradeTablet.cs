using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestCapacityControl.Migrations
{
    public partial class ProductUpgradeTablet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Departments",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ProductUpdateTablet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
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
                    table.PrimaryKey("PK_ProductUpdateTablet", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductUpdateTablet");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Departments",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
