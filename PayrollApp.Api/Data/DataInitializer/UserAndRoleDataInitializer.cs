using Microsoft.AspNetCore.Identity;
using PayrollApp.Api.Data.Entities;
using PayrollApp.Api.Data.Enums;

namespace PayrollApp.Api.Data.DataInitializer
{
    public static class UserAndRoleDataInitializer
    {
        public static void SeedData(UserManager<User> userManager, RoleManager<IdentityRole> roleManager, PayrollContext context)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager, context);
        }

        private static void SeedUsers (UserManager<User> userManager, PayrollContext context)
        {
            if (userManager.FindByEmailAsync("alex@localhost").Result == null)
            {
                User user = new User();
                user.UserName = "alex@localhost";
                user.Email = "alex@localhost";
                user.FirstName = "Alex";
                user.LastName = "Calingasan";

                IdentityResult result = userManager.CreateAsync(user, "P@ssw0rd1!").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                    context.Employees.Add(new Employee
                    {
                        User = user,
                        EmployeeNumber = "EMP-00001",
                        EmploymentStatus = EmploymentStatus.Regular
                    });
                    context.SaveChanges();
                }
            }
        }

        private static void SeedRoles (RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("User").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "User";
                IdentityResult roleResult = roleManager.
                CreateAsync(role).Result;
            }


            if (!roleManager.RoleExistsAsync("Admin").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Admin";
                IdentityResult roleResult = roleManager.
                CreateAsync(role).Result;
            }
        }
    }
}