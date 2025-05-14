using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using PROG_7311_POE_Part_2.Models;

namespace PROG_7311_POE_Part_2.Data
{
    public static class DataSeeder
    {
        // This method seeds roles and two default users (Farmer and Employee)
        public static async Task SeedRolesAndAdminAsync(IServiceProvider services)
        {
            // Retrieve the RoleManager and UserManager from the service provider
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();

            // Define the roles that should exist in the system
            string[] roles = { "Farmer", "Employee" };

            // Loop through each role and create it if it doesn't already exist
            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                    await roleManager.CreateAsync(new IdentityRole(role));
            }

            // Check if the test farmer user already exists
            var farmerUser = await userManager.FindByEmailAsync("farmer@test.com");
            if (farmerUser == null)
            {
                // Create a new ApplicationUser for the farmer
                var user = new ApplicationUser
                {
                    UserName = "farmer@test.com",
                    Email = "farmer@test.com",
                    RoleType = "Farmer", 
                    EmailConfirmed = true 
                };

                // Attempt to create the user with a default password
                var result = await userManager.CreateAsync(user, "Password123!");
                if (result.Succeeded)
                    // Add the new user to the "Farmer" role
                    await userManager.AddToRoleAsync(user, "Farmer");
            }

            // Check if the test employee user already exists
            var employeeUser = await userManager.FindByEmailAsync("employee@test.com");
            if (employeeUser == null)
            {
                // Create a new ApplicationUser for the employee
                var user = new ApplicationUser
                {
                    UserName = "employee@test.com",
                    Email = "employee@test.com",
                    RoleType = "Employee", 
                    EmailConfirmed = true 
                };

                // Attempt to create the user with a default password
                var result = await userManager.CreateAsync(user, "Password123!");
                if (result.Succeeded)
                    // Add the new user to the "Employee" role
                    await userManager.AddToRoleAsync(user, "Employee");
            }
        }
    }
}
