using Employees.Domain.Entities;
using Employees.Infrastructure.Extensions;
using Employees.Infrastructure.Seeders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddControllers();

builder.Services.AddOpenApi();

builder.Configuration.GetConnectionString("EmployeesDb");

builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

var scope = app.Services.CreateScope();
var seeder = scope.ServiceProvider.GetRequiredService<IEmployeeSeeder>();
await seeder.Seed();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapIdentityApi<Employee>();

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();
