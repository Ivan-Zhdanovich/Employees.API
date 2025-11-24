using Employees.Domain.Entities;
using Employees.Infrastructure.Persistence;
using Employees.Infrastructure.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Employees.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionsString = configuration.GetConnectionString("EmployeesDb");
            services.AddDbContext<EmployeesDbContext>(options => 
            options.UseNpgsql(connectionsString).EnableSensitiveDataLogging());

            services.AddIdentityApiEndpoints<Employee>().AddEntityFrameworkStores<EmployeesDbContext>();

            services.AddScoped<IEmployeeSeeder, EmployeeSeeder>();        
        }
    }
}
