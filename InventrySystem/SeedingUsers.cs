using Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace InventrySystem
{
    public static class SeedingUsers
    {
        public static async Task SeedUsers(UserManager<User> userManager)
        {
            if (await userManager.FindByNameAsync("admin001") == null)
            {
                var adminUser = new User
                {
                    FirstName = "AdminFirstName",
                    LastName = "AdminLastName",
                    UserName = "admin001",
                    Email = "admin001@matech.com",
                    EmailConfirmed = true,
                };

                var result = await userManager.CreateAsync(adminUser, "AdminPassword123");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, "Admin");
                }
            }

            if (await userManager.FindByNameAsync("user002") == null)
            {
                var normalUser = new User
                {
                    FirstName = "UserFirstName",
                    LastName = "UserLastName",
                    UserName = "user002",
                    Email = "user002@matech.com",
                    EmailConfirmed = true,
                };

                var result = await userManager.CreateAsync(normalUser, "UserPassword123");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(normalUser, "User");
                }
            }
        }
    }
}
