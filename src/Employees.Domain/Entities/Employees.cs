using Employees.Domain.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

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
        public string ApplicationUserId { get; set; }
       
        [ForeignKey("ApplicationUserId")]
        public ApplicationUser ApplicationUser { get; set; }

        [SetsRequiredMembers]
        public Employee() : base() {}

        public Employee(string firstName, string lastName, string email, string password, EmployeeRole role, bool isActive)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Role = role;
            IsActive = isActive;
        }
    }
}
