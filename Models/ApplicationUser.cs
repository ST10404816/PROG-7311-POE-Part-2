using Microsoft.AspNetCore.Identity;

namespace PROG_7311_POE_Part_2.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Custom property to store the user's role type 
        public string RoleType { get; set; }
    }
}
