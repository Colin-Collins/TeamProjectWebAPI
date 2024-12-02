using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using Microsoft.EntityFrameworkCore;
using TeamProjectWebAPI.Models;

namespace TeamProjectWebAPI.Data
{
    public class TeamContext : DbContext
    {
        public TeamContext(DbContextOptions<TeamContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hobby>();
            modelBuilder.Entity<TeamMember>();
            modelBuilder.Entity<Sport>();
            modelBuilder.Entity<Food>();

            modelBuilder.Seed();
        }

        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Sport> Sports { get; set; }
        public DbSet<Food> Foods { get; set; }


    }
}
