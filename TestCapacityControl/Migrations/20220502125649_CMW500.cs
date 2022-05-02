using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestCapacityControl.Migrations
{
    public partial class CMW500 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CMW500",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
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
                    table.PrimaryKey("PK_CMW500", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CMW500");
        }
    }
}
