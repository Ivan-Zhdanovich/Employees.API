using Microsoft.EntityFrameworkCore;
using Employees.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Employees.Infrastructure.Persistence;

public class EmployeesDbContext(DbContextOptions<EmployeesDbContext> options) : IdentityDbContext<Employee>(options)
{
    public DbSet<Employee> Employee { get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        optionsBuilder.UseNpgsql();
        }
}
