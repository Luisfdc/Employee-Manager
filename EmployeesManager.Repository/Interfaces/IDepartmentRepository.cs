
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesManager.Repository.Interfaces
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments();
    }
}
