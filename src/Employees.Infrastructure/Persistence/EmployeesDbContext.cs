using Employees.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Employees.Infrastructure.Persistence;

public class EmployeesDbContext(DbContextOptions<EmployeesDbContext> options) : IdentityDbContext<Employee, ApplicationRole, int>(options)
{
    public DbSet<Employee> Employee { get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        optionsBuilder.UseNpgsql();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Employee>().Ignore(u => u.PhoneNumber);
        modelBuilder.Entity<Employee>().Ignore(u => u.PhoneNumberConfirmed);
        modelBuilder.Entity<Employee>().Ignore(u => u.TwoFactorEnabled);
        modelBuilder.Entity<Employee>().Ignore(u => u.LockoutEnabled);
        modelBuilder.Entity<Employee>().Ignore(u => u.LockoutEnd);
        modelBuilder.Entity<Employee>().Ignore(u => u.AccessFailedCount);
        modelBuilder.Entity<Employee>().Ignore(u => u.SecurityStamp);
        modelBuilder.Entity<Employee>().Ignore(u => u.ConcurrencyStamp);
    }
}
