using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesManager.Repository.DataBase
{
    public static class DataBaseMok
    {
        public static IEnumerable<Employee> TbEmployees { get; set; }
        public static IEnumerable<Department> TbDepartments => new List<Department> {
            new Department { Id=1,Name="Architecture"},
            new Department { Id=1,Name="E-commerce"},
            new Department { Id=1,Name="Mobile"}
        };
    }
}
