using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    // public class Seed
    // {
    //     public static async Task SeedUser(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
    //     {
    //         if (await userManager.Users.AnyAsync()) return;

    //         var userData = await System.IO.File.ReadAllTextAsync("Data/UserSeedData.json");
    //         var users = JsonSerializer.Deserialize<List<AppUser>>(userData);
    //         if (users == null) return;

    //         var roles = new List<AppRole>{
    //             new AppRole{Name="Developer"},
    //             new AppRole{Name="Manager"},
    //             new AppRole{Name="Admin"}
    //         };

    //         foreach (var role in roles)
    //         {
    //             await roleManager.CreateAsync(role);

    //         }

    //         foreach (var user in users)
    //         {

    //             user.UserName = user.UserName.ToLower();


    //             await userManager.CreateAsync(user, "Pa$$w0rd");
    //             await userManager.AddToRoleAsync(user, "Developer");

    //         }

    //         var admin = new AppUser
    //         {
    //             UserName = "admin"
    //         };

    //         await userManager.CreateAsync(admin, "Pa$$w0rd");
    //         await userManager.AddToRolesAsync(admin, new[] { "Admin" });


    //     }
    // }
}