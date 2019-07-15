using EmployeesManager;
using EmployeesManager.Repository.Context;
using EmployeesManager.Repository.DataBase;
using EmployeesManager.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeesManager.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private string[] args;

        public IEnumerable<Department> GetAllDepartments()
        {
            using (var db = new DesignTimeDbContextFactory().CreateDbContext(args))
            {
                return db.Department.ToList();
            }
        }

        private IDisposable CreateDbContext(object p)
        {
            throw new NotImplementedException();
        }
    }
}
