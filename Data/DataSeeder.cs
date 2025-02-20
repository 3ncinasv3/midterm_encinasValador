using Microsoft.AspNetCore.Identity;

namespace midterm_encinasValador.Data
{
    public class DataSeeder
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();


            await CreateRole(roleManager, "Owner");
            await CreateRole(roleManager, "Buyer");


            await CreateUser(userManager, "owner@example.com", "Password123!", "Owner");


            await CreateUser(userManager, "buyer@example.com", "Password123!", "Buyer");
        }

        private static async Task CreateRole(RoleManager<IdentityRole> roleManager, string roleName)
        {
            if (!await roleManager.RoleExistsAsync(roleName))
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            }
        }
        private static async Task CreateUser(UserManager<IdentityUser> userManager,
          string email, string password, string role)
        {
            var user = await userManager.FindByEmailAsync(email);
            if (user == null)
            {
                user = new IdentityUser { UserName = email, Email = email, EmailConfirmed = true };
                await userManager.CreateAsync(user, password);
                await userManager.AddToRoleAsync(user, role);
            }
        }

    }
}
