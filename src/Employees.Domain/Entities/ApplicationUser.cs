using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Employees.Domain.Entities
{
    [method: SetsRequiredMembers]
    public class ApplicationUser() : IdentityUser<int>()
    {
        public int EmployeeId { get; set; }
        public required bool IsActive { get; set; } = true;

        [ForeignKey("EmployeeId")]
        public required Employee Employee { get; set; }
    }
}
