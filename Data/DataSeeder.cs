using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using PROG_7311_POE_Part_2.Models;

namespace PROG_7311_POE_Part_2.Data
{
    public static class DataSeeder
    {
        public static async Task SeedRolesAndAdminAsync(IServiceProvider services)
        {
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();

            string[] roles = { "Farmer", "Employee" };

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                    await roleManager.CreateAsync(new IdentityRole(role));
            }

            // Test Farmer
            var farmerUser = await userManager.FindByEmailAsync("farmer@test.com");
            if (farmerUser == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "farmer@test.com",
                    Email = "farmer@test.com",
                    RoleType = "Farmer",
                    EmailConfirmed = true
                };
                var result = await userManager.CreateAsync(user, "Password123!");
                if (result.Succeeded)
                    await userManager.AddToRoleAsync(user, "Farmer");
            }

            // Test Employee
            var employeeUser = await userManager.FindByEmailAsync("employee@test.com");
            if (employeeUser == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "employee@test.com",
                    Email = "employee@test.com",
                    RoleType = "Employee",
                    EmailConfirmed = true
                };
                var result = await userManager.CreateAsync(user, "Password123!");
                if (result.Succeeded)
                    await userManager.AddToRoleAsync(user, "Employee");
            }
        }
    }
}
