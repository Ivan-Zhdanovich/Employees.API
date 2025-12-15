namespace Employees.Web.Dtos
{
    public class EmployeeProfileDto
    {
        public int Id { get; set; }
        //public string UserName { get; set; } = default!;
        //public string Email { get; set; } = default!;
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public bool IsActive { get; set; } = default!;
        public int Role { get; set; }

    }
}
