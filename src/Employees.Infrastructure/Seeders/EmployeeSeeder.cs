using Employees.Domain.Entities;
using Employees.Domain.Enums;
using Employees.Infrastructure.Persistence;
using System.ComponentModel.DataAnnotations;

namespace Employees.Infrastructure.Seeders
{
    internal class EmployeeSeeder(EmployeesDbContext dbContext) : IEmployeeSeeder
    {
        public async Task Seed()
        {
            if (await dbContext.Database.CanConnectAsync())
            {
                if (!dbContext.Employee.Any())
                {
                    var employees = GetEmployees();
                    dbContext.Employee.AddRange(employees);
                    await dbContext.SaveChangesAsync();
                }
            }
        }

        private static IEnumerable<Employee> GetEmployees()
        {
            List<Employee> employees = [

            new Employee()
            {
            FirstName = "Ivan",

            LastName = "Ivankoff",

            Email = "Ivankoff@mail.ru",

            Role = EmployeeRole.Admin,

            },

           new Employee()
           {
               FirstName = "Andrey",

               LastName = "Smirnoff",

               Email = "Smirnoff@mail.ru",

               PasswordHash = "1234567#!",

               Role = EmployeeRole.User,

           },

          ];

            return employees;

        }

    }
}
