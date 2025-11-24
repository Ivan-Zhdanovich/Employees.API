using Microsoft.EntityFrameworkCore;
using Employees.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Employees.Infrastructure.Persistence;

internal class EmployeesDbContext(DbContextOptions<EmployeesDbContext> options) : IdentityDbContext<Employee>(options)
{
    internal DbSet<Employee> Employees { get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        optionsBuilder.UseNpgsql();
        }
}
