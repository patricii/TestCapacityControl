using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TestCapacityControl.Models
{
    public class TestCapacityControlContext : DbContext
    {
        public TestCapacityControlContext (DbContextOptions<TestCapacityControlContext> options)
            : base(options)
        {
        }

        public DbSet<TestCapacityControl.Models.Departments> Departments { get; set; }
    }
}
