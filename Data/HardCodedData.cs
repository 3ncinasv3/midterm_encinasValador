using Microsoft.AspNetCore.Identity;

namespace midterm_encinasValador.Data
{
    public class HardCodedData
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

            await CreateRole(roleManager, "Owner");
            await CreateRole(roleManager, "Buyer");

            await CreateUser(userManager, "owner@owner.com", "Test123!", "Owner");
            await CreateUser(userManager, "buyer@buyer.com", "Test123!", "Buyer");
        }

        private static async Task CreateRole(RoleManager<IdentityRole> roleManager, string role)
        {
            if (await roleManager.RoleExistsAsync(role))
            {
                await roleManager.CreateAsync(new IdentityRole(role));
            }
        }

        private static async Task CreateUser(UserManager<IdentityUser> userManager, string email, string password, string role)
        {
            var user = await userManager.FindByEmailAsync(email);

            if (user == null)
            {
                user = new IdentityUser { UserName = email, Email = email };

                await userManager.CreateAsync(user, password);
                await userManager.AddToRoleAsync(user, role);
            }
        }

    }
}
