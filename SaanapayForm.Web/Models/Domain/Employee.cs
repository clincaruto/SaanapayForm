using Microsoft.AspNetCore.Identity;
using SaanapayForm.Web.Models.Domain.Enums;

namespace SaanapayForm.Web.Models.Domain
{
    public class Employee : IdentityUser
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? TaxId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; }
        public UserRoleEnum UserRole { get; set; }
        public string strUserRole { get; set; }

    }
}
