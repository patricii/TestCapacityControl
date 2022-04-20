using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestCapacityControl.Models;

namespace TestCapacityControl.Models
{
    public class TestCapacityControlContext : DbContext
    {
        public TestCapacityControlContext (DbContextOptions<TestCapacityControlContext> options)
            : base(options)
        {
        }

        public DbSet<TestCapacityControl.Models.Departments> Departments { get; set; }

        public DbSet<TestCapacityControl.Models.TestRatesCelular> TestRatesCelular { get; set; }
    }
}
