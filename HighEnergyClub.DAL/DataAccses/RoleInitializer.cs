using HighEnergyClub.DAL.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighEnergyClub.DAL.DataAccses
{
    public static class RoleInitializer
    {
        public static async Task InitializeAsync(UserManager<UserEntity> userManager, RoleManager<IdentityRole<Guid>> roleManager)
        {
            string adminEmail = "admin@gmail.com";
            string password = "_Aa123456";

            if (await roleManager.FindByNameAsync("admin") == null)
            {
                await roleManager.CreateAsync(new IdentityRole<Guid>("admin"));
            }

            if (await roleManager.FindByNameAsync("coach") == null)
            {
                await roleManager.CreateAsync(new IdentityRole<Guid>("coach"));
            }

            if (await userManager.FindByNameAsync(adminEmail) == null)
            {
                UserEntity admin = new UserEntity { Email = adminEmail, UserName = adminEmail };
                IdentityResult adminResult = await userManager.CreateAsync(admin, password);

                if (adminResult.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, "admin");
                }
            }
        }
    }
}
