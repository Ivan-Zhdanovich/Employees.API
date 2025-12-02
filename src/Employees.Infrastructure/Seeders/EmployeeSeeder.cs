using Employees.Domain.Entities;
using Employees.Domain.Enums;
using Employees.Infrastructure.Persistence;

namespace Employees.Infrastructure.Seeders
{
    internal class EmployeeSeeder(EmployeesDbContext dbContext) : IEmployeeSeeder
    {
        public async Task Seed()
        {
            if (await dbContext.Database.CanConnectAsync())
            {
                if (dbContext.Employee.Any())
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

            Password = "1234567",

            Role = EmployeeRole.Admin,

            IsActive = true,
            },

           new Employee()
           {
               FirstName = "Andrey",

               LastName = "Smirnoff",

               Email = "Smirnoff@mail.ru",

               Password = "1234567",

               Role = EmployeeRole.User,

               IsActive = true,
           },

          ];

            return employees;

        }

    }
}
