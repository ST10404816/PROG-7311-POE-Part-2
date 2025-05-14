using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PROG_7311_POE_Part_2.Models;

namespace PROG_7311_POE_Part_2.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        // Constructor that passes options to the base DbContext constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        // DbSet for accessing the Farmer table in the database
        public DbSet<Farmer> Farmers { get; set; }

        // DbSet for accessing the Employee table in the database
        public DbSet<Employee> Employees { get; set; }

        // DbSet for accessing the Product table in the database
        public DbSet<Product> Products { get; set; }
    }
}
