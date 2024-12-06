using Microsoft.EntityFrameworkCore;
using TeamProjectWebAPI.Models;

namespace TeamProjectWebAPI.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hobby>().HasData(
                new Hobby { Id = 1, Name = "Fishing", Description = "Outdoor Activity", Frequency = "Twice a Week", DurationInMinutes = 180 },
                new Hobby { Id = 2, Name = "Music", Description = "Singing Songs", Frequency = "Everyday", DurationInMinutes = 360 },
                new Hobby { Id = 3, Name = "Anime", Description = "Watching Anime", Frequency = "Three Times a Week", DurationInMinutes = 500 },
                new Hobby { Id = 4, Name = "Games", Description = "Playing Games", Frequency = "Five Times a Week", DurationInMinutes = 500 },
                new Hobby { Id = 5, Name = "Reading", Description = "Reading Books", Frequency = "Every Other Day", DurationInMinutes = 400 });

            modelBuilder.Entity<TeamMember>().HasData(
                new TeamMember { Id = 1, FullName = "Kyle Rieve", Birthdate = 6251992, CollegeProgram = "Information Technology", YearInProgram = "Sophomore" },
                new TeamMember { Id = 2, FullName = "Colin Collins", Birthdate = 11132004, CollegeProgram = "Cybersecurity", YearInProgram = "Sophomore" },
                new TeamMember { Id = 3, FullName = "Kyler Hayes", Birthdate = 10132004, CollegeProgram = "Information Technology", YearInProgram = "Sophomore" },
                new TeamMember { Id = 4, FullName = "Bobby Vargas", Birthdate = 2231996, CollegeProgram = "Information Technology", YearInProgram = "Freshman" },
                new TeamMember { Id = 5, FullName = "Zachary Dunn", Birthdate = 11201998, CollegeProgram = "Information Technology", YearInProgram = "Sophomore" });

            modelBuilder.Entity<Sport>().HasData(
                new Sport { Id = 1, SportName = "Football", TeamOrIndividual = "Ohio State", PlayersCount = 11, Season = "Fall" },
                new Sport { Id = 2, SportName = "Track and Field", TeamOrIndividual = "Usain Bolt", PlayersCount = 1, Season = "Summer" },
                new Sport { Id = 3, SportName = "Hockey", TeamOrIndividual = "Wayne Gretzky", PlayersCount = 6, Season = "Winter" },
                new Sport { Id = 4, SportName = "Archery", TeamOrIndividual = "Howard Hill", PlayersCount = 1, Season = "Summer" },
                new Sport { Id = 5, SportName = "Baseball", TeamOrIndividual = "Reds", PlayersCount = 9, Season = "Spring" });

            modelBuilder.Entity<Food>().HasData(
               new Food { Id = 1, FoodName = "Pizza", CuisineType = "Italian", IsSpicy = false, Calories = 285 },
               new Food { Id = 2, FoodName = "Chicken Biryani", CuisineType = "Indian", IsSpicy = true, Calories = 1200 },
               new Food { Id = 3, FoodName = "Chicken", CuisineType = "American", IsSpicy = false, Calories = 200 },
               new Food { Id = 4, FoodName = "Pizza", CuisineType = "Italian", IsSpicy = false, Calories = 285 },
               new Food { Id = 5, FoodName = "Cheeseburger", CuisineType = "American", IsSpicy = false, Calories = 800 });
        }
    }
}
