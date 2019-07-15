using EmployeesManager;
using EmployeesManager.Aplication.Interfaces;
using EmployeesManager.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace DepartmentManager.Aplication
{
    public class DepartmentAplication : IDepartmentAplication
    {
        private IDepartmentRepository _departmentRepository;

        public DepartmentAplication(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public IEnumerable<Department> GetAllDepartments()
        {
            return _departmentRepository.GetAllDepartments();
        }
    }
}
