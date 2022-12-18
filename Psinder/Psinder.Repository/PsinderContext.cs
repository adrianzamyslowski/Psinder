using Psinder.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Psinder.Repository
{
    public class PsinderContext : IdentityDbContext<User>
    {
        public PsinderContext() { }
        public PsinderContext(DbContextOptions<PsinderContext> options) : base(options) { }

        public DbSet<User> Users => Set<User>();
        public DbSet<Dog> Dogs => Set<Dog>();
        public DbSet<Park> Parks => Set<Park>();


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder
                .UseSqlServer(
                    "Server=localhost; Database=PiesDB; Trusted_Connection=True; MultipleActiveResultSets=True;Trust Server Certificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            //modelBuilder.Entity<User>().HasData(
            //    new User
            //    {
            //        Id = 1,
            //        UserName = "Kowalski",
            //        DateOfBirth = new DateTime(2000, 01, 01),
            //        Dogs = new List<Dog>()
            //        {
            //            new Dog
            //            {
            //                Id = 1, Name = "rex", DateOfBirth = new DateTime(2020, 10, 10),
            //                DogBreeds = DogBreeds.Owczarek, Gender = Gender.Male
            //            },
            //            new Dog
            //            {
            //            Id = 2, Name = "azor", DateOfBirth = new DateTime(2021, 10, 10),
            //            DogBreeds = DogBreeds.Mops, Gender = Gender.Female
            //        }
            //        },
            //    });

            //modelBuilder.Entity<Dog>().HasData(

            //    new Dog() { DateOfBirth = new DateTime(2020, 10, 10), DogBreeds = DogBreeds.Owczarek, Gender = Gender.Male, Id = 1, Name = "rex", });


        }
    }
}
