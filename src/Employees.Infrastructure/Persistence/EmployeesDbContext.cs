using Microsoft.EntityFrameworkCore;
using Employees.Domain.Entities

namespace Employees.Infrastructure.Persistence;

internal class EmployeesDbContext : DbContext
{
    internal DbSet<Employee> Employees { get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        optionsBuilder.UseNpgsql("Host = localhost; Port = 5432; Database = EmploeesDb; Username = user; Password = password");
        }
}
