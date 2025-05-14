using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PROG_7311_POE_Part_2.Models;

namespace PROG_7311_POE_Part_2.Data;

public class PROG_7311_POE_Part_2Context : IdentityDbContext<ApplicationUser>
{
    public PROG_7311_POE_Part_2Context(DbContextOptions<PROG_7311_POE_Part_2Context> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
