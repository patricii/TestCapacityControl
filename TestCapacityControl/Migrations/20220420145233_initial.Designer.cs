﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestCapacityControl.Models;

namespace TestCapacityControl.Migrations
{
    [DbContext(typeof(TestCapacityControlContext))]
    [Migration("20220420145233_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TestCapacityControl.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("JobTitle");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Departament");
                });
#pragma warning restore 612, 618
        }
    }
}
