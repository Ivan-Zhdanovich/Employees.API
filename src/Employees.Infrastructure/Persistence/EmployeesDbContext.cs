using Employees.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Employees.Infrastructure.Persistence;

public class EmployeesDbContext(DbContextOptions<EmployeesDbContext> options) : IdentityDbContext<ApplicationUser, ApplicationRole, int>(options)
{
    public DbSet<Employee> Employee { get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        optionsBuilder.UseNpgsql();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Employee>()
            .HasOne(e => e.ApplicationUser)
            .WithOne(au => au.Employee)
            .HasForeignKey<Employee>(e => e.ApplicationUserId);
    }
}
