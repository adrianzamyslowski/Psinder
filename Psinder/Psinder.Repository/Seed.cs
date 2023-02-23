using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Psinder.Core.Model;
using Psinder.Core.Model.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Psinder.Repository
{
    public static class Seed
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            List<IdentityRole> roles = new()
            {
                new IdentityRole {Name = "Admin", NormalizedName = "ADMIN"},
                new IdentityRole {Name = "Moderator", NormalizedName = "MODERATOR"},
                new IdentityRole {Name = "RegularUser", NormalizedName = "REGULARUSER"},
            };

            modelBuilder.Entity<IdentityRole>().HasData(roles);

            List<User> users = new()
            {
                new User {UserName = "admin", Email = "admin@admin.pl", NormalizedUserName = "ADMIN", NormalizedEmail = "ADMIN@ADMIN.PL"},
                new User {UserName = "moderator", Email = "moderator@moderator.pl", NormalizedUserName = "MODERATOR", NormalizedEmail = "MODERATOR@MODERATOR.PL"},
                new User {UserName = "regular", Email = "regular@regular.pl", NormalizedUserName = "REGULAR", NormalizedEmail = "REGULAR@REGULAR.PL"},
            };

            modelBuilder.Entity<User>().HasData(users);

            List<IdentityUserRole<string>> userRoles = new()
            {
                new IdentityUserRole<string> {UserId = users[0].Id, RoleId = roles.First(r=>r.Name == "Admin").Id},
                new IdentityUserRole<string> {UserId = users[1].Id, RoleId = roles.First(r=>r.Name == "Moderator").Id},
                new IdentityUserRole<string> {UserId = users[2].Id, RoleId = roles.First(r=>r.Name == "RegularUser").Id},
            };

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);

            PasswordHasher<User> passwordHasher = new();

            users[0].PasswordHash = passwordHasher.HashPassword(users[0], "Haslo1!");
            users[1].PasswordHash = passwordHasher.HashPassword(users[1], "Haslo1!");
            users[2].PasswordHash = passwordHasher.HashPassword(users[2], "Haslo1!");

            modelBuilder.Entity<Park>().HasData
               (
                new Park { Id = 1, NamePark = "Psi wybieg", Street = "Krakowska 2", City = "Kraków", PostalCode = "00-000", Country = "Polska", },
                 new Park { Id = 2, NamePark = "Krakowski Park", Street = "Mogilska 2", City = "Kraków", PostalCode = "32-000", Country = "Polska", },
                  new Park { Id = 3, NamePark = "Lubostroń", Street = "Karlemicka 22", City = "Kraków", PostalCode = "00-000", Country = "Polska", },
                   new Park { Id = 4, NamePark = "Nowa Huta", Street = "Nowohucka 2", City = "Kraków", PostalCode = "11-544", Country = "Polska", }



               );

            modelBuilder.Entity<DogBreeds>().HasData
                (
                new DogBreeds { Id = 1, Name = "Owczarek" },
                new DogBreeds { Id = 2, Name = "Jamnik" },
                new DogBreeds { Id = 3, Name = "Mops" },
                new DogBreeds { Id = 4, Name = "Samoyed" },
                new DogBreeds { Id = 5, Name = "Jack Russel Terrier" }
                );
        }
    }
}
