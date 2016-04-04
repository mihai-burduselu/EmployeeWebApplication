using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmployeeWebApplication
{
    public class EmployeeContext:DbContext
    {
            public EmployeeContext() : base("name=EmployeeDbConnectionString")
            {
            }
            public DbSet<Employee> Employees { get; set; }
    }
}