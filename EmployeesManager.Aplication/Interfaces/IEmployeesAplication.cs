using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesManager.Aplication.Interfaces
{
    public interface IEmployeesAplication
    {
        IEnumerable<Employee> GetAllEmployees();
        void AddEmployees(Employee employee);
        void DeleteEmployees(int Id);
    }
}