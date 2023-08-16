using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppEfCodeFirst.Models;

namespace WebAppEfCodeFirst.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext (DbContextOptions<EmployeeDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppEfCodeFirst.Models.Employee> Employee { get; set; } = default!;
    }
}
