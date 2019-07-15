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
    public class EmployeeController : ControllerBase
    {
        private IEmployeesAplication _employeesAplication;

        public EmployeeController(IEmployeesAplication employeesAplication)
        {
            _employeesAplication = employeesAplication;
        }

        // GET: api/Employee
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _employeesAplication.GetAllEmployees();
        }

        // POST: api/Employee
        [HttpPost]
        public void Post([FromBody] Employee value)
        {
            _employeesAplication.AddEmployees(value);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _employeesAplication.DeleteEmployees(id);
        }
    }
}
