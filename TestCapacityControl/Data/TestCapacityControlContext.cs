using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestCapacityControl.Models;
using TestCapacityControl.Models.ViewModels;

namespace TestCapacityControl.Models
{
    public class TestCapacityControlContext : DbContext
    {
        public TestCapacityControlContext (DbContextOptions<TestCapacityControlContext> options)
            : base(options)
        {
        }

        public DbSet<TestCapacityControl.Models.Departments> Departments { get; set; }

        public DbSet<TestCapacityControl.Models.TestProcess> TestProcess { get; set; }

        public DbSet<TestCapacityControl.Models.Products> Products { get; set; }

        public DbSet<TestCapacityControl.Models.ProductsTABLET> ProductsTABLET { get; set; }

        public DbSet<TestCapacityControl.Models.ProductSetup> ProductSetup { get; set; }

        public DbSet<TestCapacityControl.Models.CMW500> CMW500 { get; set; }

        public DbSet<TestCapacityControl.Models.ProductUpdateCelular> ProductUpdateCelular { get; set; }

        public DbSet<TestCapacityControl.Models.ProductUpdateTablet> ProductUpdateTablet { get; set; }

    }
}
