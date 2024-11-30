using Microsoft.EntityFrameworkCore;
using TeamProjectWebAPI.Models;

namespace TeamProjectWebAPI.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hobby>().HasData(
                new Hobby { Id = 1, Name = "Fishing", Description = "Outdoor Activity", Frequency = "Twice a Week", DurationInMinutes = 180});

            modelBuilder.Entity<TeamMember>().HasData(
                new TeamMember { Id = 1, FullName = "Kyle Rieve", Birthdate = 6251992, CollegeProgram = "Information Technology", YearInProgram = "Sophomore" });

            modelBuilder.Entity<Sport>().HasData(
                new Sport { Id = 1, SportName = "Football", TeamOrIndividual = "Ohio State", PlayersCount = 11, Season = "Fall" });

            modelBuilder.Entity<Food>().HasData(
               new Food { Id = 1, FoodName = "Pizza", CuisineType = "Italian", IsSpicy = false, Calories = 285 });
        }
    }
}
