using Microsoft.AspNetCore.Mvc;
using Employees.Domain.Entities;
using Employees.Infrastructure.Persistence;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Employees.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(EmployeesDbContext employeesDbContext): ControllerBase
    {
        private readonly EmployeesDbContext _employeesDbContext = employeesDbContext;


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
        {
            return await _employeesDbContext.Employee.ToListAsync();
        }

        [HttpGet]
        public async Task<ActionResult<Employee>> GetEmployeeById(int id)
        {
            var employee = await _employeesDbContext.Employee.FindAsync(id);
            if(employee is null)
            {
                return NotFound();
;            }
            return employee;
        }

        [HttpPost]

        public async Task<ActionResult<Employee>> CreateEmployee(Employee employee) 
        {
            _employeesDbContext.Employee.Add(employee);
            await _employeesDbContext.SaveChangesAsync();
            return CreatedAtAction(nameof(GetEmployeeById), new { id = employee.Id });
        }
  
    }
}
