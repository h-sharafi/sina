using Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Persistence
{
    public class Seed
    {

        public static async Task SeedData(DataContext context, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {

            if (!context.Roles.Any())
            {
                var list = new List<AppRole>
                {
                    new AppRole {Name = "Administrator"}
                };
                foreach (var role in list)
                    await roleManager.CreateAsync(role);
                await context.SaveChangesAsync();
            };

            if (!userManager.Users.Any())
            {
                var users = new List<AppUser>
                {
                    new AppUser
                    {
                        UserName = "h.sharafi@hotmail.com",
                        Email = "h.sharafi@hotmail.com",
                        DisplayName="سینا نجفیان"
                    }
                };
                foreach (var user in users)
                    await userManager.CreateAsync(user, "Pa$$w0rd");


                var appUser = userManager.Users.FirstOrDefault();
                await userManager.AddToRoleAsync(appUser, "Administrator");

                var team = new Team
                {
                    TeamAppUserId = appUser.Id,
                    BreifKnowledge = "توضیحات"
                };
                context.Teams.Add(team);
                await context.SaveChangesAsync();


            }
        }
    }
}
