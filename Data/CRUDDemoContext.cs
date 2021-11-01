using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUDDemo.Models;

namespace CRUDDemo.Data
{
    public class CRUDDemoContext : DbContext
    {
        public CRUDDemoContext (DbContextOptions<CRUDDemoContext> options)
            : base(options)
        {
        }

        public DbSet<CRUDDemo.Models.Employee> Employees { get; set; }
        public DbSet<CRUDDemo.Models.Department> Departments { get; set; }
    }
}
