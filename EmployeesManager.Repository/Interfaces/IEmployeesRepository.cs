
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesManager.Repository.Interfaces
{
    public interface IEmployeesRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        void AddEmployees(Employee employee);
        void DeleteEmployees(int Id);
    }
}
