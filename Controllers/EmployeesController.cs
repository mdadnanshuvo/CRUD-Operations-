using EmployeeAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EmployeeAPI.Controllers
{


    [ApiController]

    [Route("api/employees")]
    public class EmployeesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
    
            List<Employee> employees = new List<Employee>
            {
                new Employee { EmployeeId = 502030, EmployeeName = "Mehedi Hasan", EmployeeCode = "EMP319", EmployeeSalary = 50000 },
                new Employee { EmployeeId = 502031, EmployeeName = "Ashikur Rahman", EmployeeCode = "EMP321", EmployeeSalary = 45000 },
                new Employee { EmployeeId = 502032, EmployeeName = "RakibulIslam", EmployeeCode = "EMP322", EmployeeSalary = 52000 }
            };

            return Ok(employees);

            
        }

        
    }
}

