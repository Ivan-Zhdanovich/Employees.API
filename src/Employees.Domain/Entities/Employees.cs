using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Employees.Domain.Enums;

namespace Employees.Domain.Entities
{
    public class Employee
    {
        public int Id { get; set; } 
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required EmployeeRole Role { get; set; }
        public bool IsActive { get; set; }

    }
}
