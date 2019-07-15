using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesManager.Repository.Context
{
    public class EmployeeContext : DbContext
    {
       
        public EmployeeContext(DbContextOptions<EmployeeContext> opcoes)
            : base(opcoes)
        {
        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }
    }
}
