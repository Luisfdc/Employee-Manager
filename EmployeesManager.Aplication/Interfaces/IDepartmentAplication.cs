using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesManager.Aplication.Interfaces
{
    public interface IDepartmentAplication
    {
        IEnumerable<Department> GetAllDepartments();
    }
}
