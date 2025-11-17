using Microsoft.EntityFrameworkCore;
using Employees.Domain.Entities;

namespace Employees.Infrastructure.Persistence;

internal class EmployeesDbContext(DbContextOptions<EmployeesDbContext> options : DbContext(options)
{
    internal DbSet<Employee> Employees { get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        optionsBuilder.UseNpgsql();
        }
}
