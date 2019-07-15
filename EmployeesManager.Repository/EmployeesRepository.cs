using EmployeesManager;
using EmployeesManager.Repository.Context;
using EmployeesManager.Repository.DataBase;
using EmployeesManager.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeesManager.Repository
{
    public class EmployeesRepository : IEmployeesRepository
    {
        private string[] args;
        public void AddEmployees(Employee employee)
        {
            using (var db = new DesignTimeDbContextFactory().CreateDbContext(args))
            {
                db.Add(employee);
                db.SaveChanges();
            }
        }

        public void DeleteEmployees(int Id)
        {

            using (var db = new DesignTimeDbContextFactory().CreateDbContext(args))
            {
                var employee = db.Employee.FirstOrDefault(x =>x.Id == Id);
                db.Employee.Remove(employee);
                db.SaveChanges();
            }
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            using (var db = new DesignTimeDbContextFactory().CreateDbContext(args))
            {
                return db.Employee.Include(e => e.Department).ToList();

            }
        }
    }
}
