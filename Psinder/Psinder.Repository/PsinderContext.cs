using Psinder.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Psinder.Core.Model.Enums;

namespace Psinder.Repository
{
    public class PsinderContext : IdentityDbContext<User>
    {
        public PsinderContext() { }
        public PsinderContext(DbContextOptions<PsinderContext> options) : base(options) { }

        public DbSet<User> Users => Set<User>();
        public DbSet<Dog> Dogs => Set<Dog>();
        public DbSet<Park> Parks => Set<Park>();
        public DbSet<DogOnMeeting> DogOnMeeting => Set<DogOnMeeting>();
        public DbSet<Meeting> Meetings => Set<Meeting>();
        public DbSet<UserOnMeeting> UserOnMeetings => Set<UserOnMeeting>();


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

            modelBuilder.Entity<DogOnMeeting>()
                .HasOne(dom => dom.Dog)
                .WithMany(d => d.DogOnMeetings)
                .OnDelete(DeleteBehavior.ClientNoAction);

            modelBuilder.Entity<DogOnMeeting>()
                .HasOne(dom => dom.Meeting)
                .WithMany(m => m.DogOnMeetings)
                .OnDelete(DeleteBehavior.ClientNoAction);

            modelBuilder.Entity<UserOnMeeting>()
               .HasOne(uom => uom.User)
               .WithMany(u => u.UsersOnMeeting)
               .OnDelete(DeleteBehavior.ClientNoAction);

            modelBuilder.Entity<UserOnMeeting>()
                .HasOne(uom => uom.Meeting)
                .WithMany(m => m.UsersOnMeeting)
                .OnDelete(DeleteBehavior.ClientNoAction);
        }
    }
}
