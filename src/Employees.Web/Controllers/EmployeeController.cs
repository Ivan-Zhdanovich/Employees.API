using Microsoft.AspNetCore.Mvc;
using Employees.Domain.Entities;
using Employees.Infrastructure.Persistence;
using System.Collections.Generic;

namespace Employees.Web.Controllers
{
    public class EmployeeController(EmployeesDbContext employeesDbContext): ControllerBase
    {
        private readonly EmployeesDbContext _employeesDbContext = employeesDbContext;


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
        {
            return await _employeesDbContext.Employee.ToListAsync();
        }
  
    }
}
