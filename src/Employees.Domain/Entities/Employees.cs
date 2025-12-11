using Employees.Domain.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Employees.Domain.Entities
{
    public class Employee : IdentityUser<int>
    {
         public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public EmployeeRole Role { get; set; } = default!;
        public bool IsActive { get; set; } = true;
      
    }
}
