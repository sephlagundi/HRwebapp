using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HRwebapp.Areas.Identity.Data
{
    public static class SeedData
    {
/*        private static string ManagerRoleId = Guid.NewGuid().ToString();
        private static string UserRoleId = Guid.NewGuid().ToString();
        private static string AdminRoleId = Guid.NewGuid().ToString();

        private static string User1Id = Guid.NewGuid().ToString();
      *//*  private static string User2Id = Guid.NewGuid().ToStrin*//*g();*/
        public static void SeedDefaultData(this ModelBuilder modelBuilder)
        {



/*
            //Seeding a  'Administrator' role to AspNetRoles table
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7210", Name = "Administrator", NormalizedName = "ADMINISTRATOR".ToUpper() });


            //a hasher to hash the password before seeding the user to the db
            var hasher = new PasswordHasher<IdentityUser>();


            //Seeding the User to AspNetUsers table
            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "8e445865-a24d-4543-a6c6-9443d048cdb9", // primary key
                    UserName = "myuser",
                    NormalizedUserName = "MYUSER",
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd")
                }
            );*/


/*            //Seeding the relation between our user and role to AspNetUserRoles table
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                }
            );*/


        }
    }
}


        /*            modelBuilder.Entity<IdentityRole<string>>().HasData(
            new IdentityRole<string> { Id = User1Id, Name = "Administrator", NormalizedName = "ADMINISTRATOR", ConcurrencyStamp = null },
            new IdentityRole<string> { Id = User2Id, Name = "User", NormalizedName = "USER", ConcurrencyStamp = null });*/

        /*            modelBuilder.Entity<IdentityRole<string>>().HasData(
                        new IdentityRole<string>("Administrator"));*/

/*        modelBuilder.Entity<IdentityRole>().HasData(
    new IdentityRole("Administrator"),
    new IdentityRole("User"));

            *//*            modelBuilder.Entity<IdentityUser>().HasData(
                            new IdentityUser("","",""));*//*

            modelBuilder.Entity<IdentityUser>().HasData(
    new IdentityUser
    {
        Id = User1Id,
        UserName = "admin@admin.com",
        NormalizedUserName = "ADMIN@ADMIN.COM",
        Email = "admin@admin.com",
        NormalizedEmail = "ADMIN@ADMIN.COM",
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Admin1!"),
        SecurityStamp = string.Empty,
        ConcurrencyStamp = string.Empty
    });*//*

        }
    }
}
*/