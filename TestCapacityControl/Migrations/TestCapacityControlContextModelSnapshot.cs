﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestCapacityControl.Models;

namespace TestCapacityControl.Migrations
{
    [DbContext(typeof(TestCapacityControlContext))]
    partial class TestCapacityControlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TestCapacityControl.Models.Departments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("JobTitle");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("TestCapacityControl.Models.TestProcess", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("JOT");

                    b.Property<string>("JOT_Slim");

                    b.Property<string>("L2");

                    b.Property<string>("M2");

                    b.Property<string>("Technology");

                    b.Property<string>("WUHAN_JOT");

                    b.Property<string>("WUHAN_JOT_Slim");

                    b.Property<string>("WUHAN_L2");

                    b.HasKey("Id");

                    b.ToTable("TestProcess");
                });

            modelBuilder.Entity("TestCapacityControl.Models.TestRatesCelular", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CAMCALSlimFxt");

                    b.Property<double>("CAMCALSlimNt");

                    b.Property<int>("CAMCALSlimSpr");

                    b.Property<double>("CAMCALSlimTotalUph");

                    b.Property<double>("CAMCALSlimUph");

                    b.Property<int>("CAMVALSlimFxt");

                    b.Property<double>("CAMVALSlimNt");

                    b.Property<int>("CAMVALSlimSpr");

                    b.Property<double>("CAMVALSlimTotalUph");

                    b.Property<double>("CAMVALSlimUph");

                    b.Property<double>("CFCNt");

                    b.Property<double>("CFCUph");

                    b.Property<int>("FODSlimFxt");

                    b.Property<double>("FODSlimNt");

                    b.Property<int>("FODSlimSpr");

                    b.Property<double>("FODSlimTotalUph");

                    b.Property<double>("FODSlimUph");

                    b.Property<double>("JOTSlimNt");

                    b.Property<int>("JOTSlimPsps");

                    b.Property<double>("JOTSlimTotalUph");

                    b.Property<double>("JOTSlimUph");

                    b.Property<int>("JotSlimSpr");

                    b.Property<int>("L2ArSlimFxt");

                    b.Property<double>("L2ArSlimNt");

                    b.Property<int>("L2ArSlimSpr");

                    b.Property<double>("L2ArSlimTotalUph");

                    b.Property<double>("L2ArSlimUph");

                    b.Property<double>("PATSSlimUph");

                    b.Property<double>("PatsJotUph");

                    b.Property<double>("PatsM2Uph");

                    b.Property<string>("product");

                    b.HasKey("Id");

                    b.ToTable("TestRatesCelular");
                });
#pragma warning restore 612, 618
        }
    }
}
