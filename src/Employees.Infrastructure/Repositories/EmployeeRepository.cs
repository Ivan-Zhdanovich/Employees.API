using Employees.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Employees.Domain.Interfaces;
using Employees.Domain.Entities;


namespace Employees.Infrastructure.Repositories
{
    public class EmployeeRepository(EmployeesDbContext dbContext) : IEmployeeRepository
    {
        private readonly EmployeesDbContext _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        public async Task<Employee> GetByIdAsync(int id)
        {
            var employee = await _dbContext.Employee.FindAsync(id) ?? throw new NotImplementedException();
            return employee;
        }
        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await _dbContext.Employee.ToListAsync();
        }
       
    }

}
