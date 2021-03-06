// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestCapacityControl.Models;

namespace TestCapacityControl.Migrations
{
    [DbContext(typeof(TestCapacityControlContext))]
    [Migration("20220719134621_Fisrt Migration")]
    partial class FisrtMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TestCapacityControl.Models.CMW500", b =>
                {
                    b.Property<int>("CMW_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comments");

                    b.Property<string>("Group");

                    b.Property<int>("Id_Flex");

                    b.Property<int>("Id_Motorola");

                    b.Property<int>("KB036_6GHz");

                    b.Property<int>("KM011_QC_CAL");

                    b.Property<int>("KM550_LTE_TDD");

                    b.Property<int>("KM800_CDMA");

                    b.Property<int>("KV113_MTK_CAL");

                    b.Property<int>("KV120_Unisoc");

                    b.Property<string>("Last_Station");

                    b.Property<int>("SerialNumber");

                    b.Property<string>("Site");

                    b.Property<string>("Type");

                    b.Property<DateTime>("Updated");

                    b.Property<int>("WiFi_KM650_KM610");

                    b.HasKey("CMW_Id");

                    b.ToTable("CMW500");
                });

            modelBuilder.Entity("TestCapacityControl.Models.Departments", b =>
                {
                    b.Property<int>("departments_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("JobTitle");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Scope");

                    b.HasKey("departments_Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("TestCapacityControl.Models.Products", b =>
                {
                    b.Property<int>("products_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Model");

                    b.Property<string>("ProductName");

                    b.Property<string>("Status");

                    b.HasKey("products_Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("TestCapacityControl.Models.ProductSetup", b =>
                {
                    b.Property<int>("productSetup_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Freq6Ghz");

                    b.Property<string>("License");

                    b.Property<string>("PSAUX");

                    b.Property<string>("PowerSupply");

                    b.Property<string>("Product");

                    b.Property<string>("TDD");

                    b.Property<string>("TestSets");

                    b.HasKey("productSetup_Id");

                    b.ToTable("ProductSetup");
                });

            modelBuilder.Entity("TestCapacityControl.Models.ProductsTABLET", b =>
                {
                    b.Property<int>("productTablet_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Model");

                    b.Property<string>("ProductName");

                    b.Property<string>("Status");

                    b.HasKey("productTablet_Id");

                    b.ToTable("ProductsTABLET");
                });

            modelBuilder.Entity("TestCapacityControl.Models.ProductUpdateCelular", b =>
                {
                    b.Property<int>("pUC_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("MTime5GFR");

                    b.Property<double>("MTimeARSlim");

                    b.Property<double>("MTimeBoardTst");

                    b.Property<double>("MTimeBrdTest");

                    b.Property<double>("MTimeCFC");

                    b.Property<double>("MTimeCamCAL");

                    b.Property<double>("MTimeCamVAL");

                    b.Property<double>("MTimeDCAL");

                    b.Property<double>("MTimeDVAL");

                    b.Property<double>("MTimeInline");

                    b.Property<double>("MTimeJOT");

                    b.Property<double>("MTimeJotSlim");

                    b.Property<double>("MTimeL2AR");

                    b.Property<double>("MTimeL2Vision");

                    b.Property<double>("MTimeM2AR");

                    b.Property<double>("MTimeM2Cam");

                    b.Property<double>("MTimePatsJot");

                    b.Property<double>("MTimePatsM2");

                    b.Property<double>("MTimePatsSlim");

                    b.Property<double>("Ntf5GFR");

                    b.Property<double>("NtfARSlim");

                    b.Property<double>("NtfBoardTst");

                    b.Property<double>("NtfBrdTest");

                    b.Property<double>("NtfCFC");

                    b.Property<double>("NtfCamCAL");

                    b.Property<double>("NtfCamVAL");

                    b.Property<double>("NtfDCAL");

                    b.Property<double>("NtfDVAL");

                    b.Property<double>("NtfInline");

                    b.Property<double>("NtfJOT");

                    b.Property<double>("NtfJotSlim");

                    b.Property<double>("NtfL2AR");

                    b.Property<double>("NtfL2Vision");

                    b.Property<double>("NtfM2AR");

                    b.Property<double>("NtfM2Cam");

                    b.Property<double>("NtfPatsJot");

                    b.Property<double>("NtfPatsM2");

                    b.Property<double>("NtfPatsSlim");

                    b.Property<string>("ProductNameUp");

                    b.Property<double>("Yield5GFR");

                    b.Property<double>("YieldARSlim");

                    b.Property<double>("YieldBoardTst");

                    b.Property<double>("YieldBrdTest");

                    b.Property<double>("YieldCFC");

                    b.Property<double>("YieldCamCAL");

                    b.Property<double>("YieldCamVAL");

                    b.Property<double>("YieldDCAL");

                    b.Property<double>("YieldDVAL");

                    b.Property<double>("YieldInline");

                    b.Property<double>("YieldJOT");

                    b.Property<double>("YieldJotSlim");

                    b.Property<double>("YieldL2AR");

                    b.Property<double>("YieldL2Vision");

                    b.Property<double>("YieldM2AR");

                    b.Property<double>("YieldM2Cam");

                    b.Property<double>("YieldPatsJot");

                    b.Property<double>("YieldPatsM2");

                    b.Property<double>("YieldPatsSlim");

                    b.HasKey("pUC_Id");

                    b.ToTable("ProductUpdateCelular");
                });

            modelBuilder.Entity("TestCapacityControl.Models.ProductUpdateTablet", b =>
                {
                    b.Property<int>("pUT_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("MTimeANT");

                    b.Property<double>("MTimeAudio");

                    b.Property<double>("MTimeCFCUp");

                    b.Property<double>("MTimeInline");

                    b.Property<double>("MTimeMMI1");

                    b.Property<double>("MTimeMMI2");

                    b.Property<double>("MTimeMMI3");

                    b.Property<double>("MTimeNSFT");

                    b.Property<double>("MTimeRFCal");

                    b.Property<double>("MTimeRadCurr");

                    b.Property<double>("MTimeTOF");

                    b.Property<double>("MTimeWifi");

                    b.Property<double>("MTimeWriteNumber");

                    b.Property<double>("NtfANT");

                    b.Property<double>("NtfAudio");

                    b.Property<double>("NtfCFCUp");

                    b.Property<double>("NtfInline");

                    b.Property<double>("NtfMMI1");

                    b.Property<double>("NtfMMI2");

                    b.Property<double>("NtfMMI3");

                    b.Property<double>("NtfNSFT");

                    b.Property<double>("NtfRFCal");

                    b.Property<double>("NtfRadCurr");

                    b.Property<double>("NtfTOF");

                    b.Property<double>("NtfWifi");

                    b.Property<double>("NtfWriteNumber");

                    b.Property<string>("ProductNameUp");

                    b.Property<double>("YieldANT");

                    b.Property<double>("YieldAudio");

                    b.Property<double>("YieldCFCUp");

                    b.Property<double>("YieldInline");

                    b.Property<double>("YieldMMI1");

                    b.Property<double>("YieldMMI2");

                    b.Property<double>("YieldMMI3");

                    b.Property<double>("YieldNSFT");

                    b.Property<double>("YieldRFCal");

                    b.Property<double>("YieldRadCurr");

                    b.Property<double>("YieldTOF");

                    b.Property<double>("YieldWifi");

                    b.Property<double>("YieldWriteNumber");

                    b.HasKey("pUT_Id");

                    b.ToTable("ProductUpdateTablet");
                });

            modelBuilder.Entity("TestCapacityControl.Models.TestProcess", b =>
                {
                    b.Property<int>("testProcess_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("JOT");

                    b.Property<string>("JOT_Slim");

                    b.Property<string>("L2");

                    b.Property<string>("M2");

                    b.Property<string>("Technology");

                    b.Property<string>("WUHAN_JOT");

                    b.Property<string>("WUHAN_JOT_Slim");

                    b.Property<string>("WUHAN_L2");

                    b.HasKey("testProcess_Id");

                    b.ToTable("TestProcess");
                });
#pragma warning restore 612, 618
        }
    }
}
