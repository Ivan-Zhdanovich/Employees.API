using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employees.Domain.Entities
{
      public class ApplicationUser : IdentityUser<int>
    {
        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public required Employee Employee { get; set; }
    }
}
