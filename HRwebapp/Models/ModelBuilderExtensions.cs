using HRwebapp.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HRwebapp.Models
{
    public static class ModelBuilderExtensions
    {

        public static void Seed(this ModelBuilder builder)
        {

            // Seed Roles

            List<IdentityRole> roles = new List<IdentityRole>()
    {
        new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" },
        new IdentityRole { Name = "User", NormalizedName = "USER" }
    };

            builder.Entity<IdentityRole>().HasData(roles);

            // -----------------------------------------------------------------------------

            // Seed Users

            var passwordHasher = new PasswordHasher<ApplicationUser>();

            List<ApplicationUser> users = new List<ApplicationUser>()
    {
         // imporant: don't forget NormalizedUserName, NormalizedEmail 
                 new ApplicationUser {
                     FirstName = "Admin",
                     LastName = "lastname",
                    UserName = "user2@hotmail.com",
                    NormalizedUserName = "USER2@HOTMAIL.COM",
                    Email = "user2@hotmail.com",
                    NormalizedEmail = "USER2@HOTMAIL.COM",
                },

                new ApplicationUser {
                    FirstName = "Admin2",
                    LastName = "lastname",
                    UserName = "user3@hotmail.com",
                    NormalizedUserName = "USER3@HOTMAIL.COM",
                    Email = "user3@hotmail.com",
                    NormalizedEmail = "USER3@HOTMAIL.COM",
                },
    };


            builder.Entity<ApplicationUser>().HasData(users);

            ///----------------------------------------------------

            // Seed UserRoles


            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>();

            // Add Password For All Users

            users[0].PasswordHash = passwordHasher.HashPassword(users[0], "User.123");
            users[1].PasswordHash = passwordHasher.HashPassword(users[1], "User.155");

            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[0].Id,
                RoleId =
            roles.First(q => q.Name == "User").Id
            });

            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[1].Id,
                RoleId =
            roles.First(q => q.Name == "Admin").Id
            });


            builder.Entity<IdentityUserRole<string>>().HasData(userRoles);

        }
    }
}