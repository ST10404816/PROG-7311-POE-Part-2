using Microsoft.AspNetCore.Identity;

namespace PROG_7311_POE_Part_2.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string RoleType { get; set; }
    }
}
