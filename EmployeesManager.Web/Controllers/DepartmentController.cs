using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeesManager.Aplication.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesManager.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private IDepartmentAplication _departmentAplication;

        public DepartmentController(IDepartmentAplication departmentAplication)
        {
            _departmentAplication = departmentAplication;
        }


        // GET: api/Employee
        [HttpGet]
        public IEnumerable<Department> Get()
        {
            return _departmentAplication.GetAllDepartments();
        }
    }
}
