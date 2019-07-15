using EmployeesManager.Aplication.Interfaces;
using EmployeesManager.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace EmployeesManager.Aplication
{
    public class EmployeesAplication : IEmployeesAplication
    {
        private IEmployeesRepository _employeesRepository;

        public EmployeesAplication(IEmployeesRepository employeesRepository)
        {
            _employeesRepository = employeesRepository;
        }

        public void AddEmployees(Employee employee)
        {
            _employeesRepository.AddEmployees(employee);
        }

        public void DeleteEmployees(int id)
        {
            _employeesRepository.DeleteEmployees(id);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeesRepository.GetAllEmployees();
        }
    }
}
