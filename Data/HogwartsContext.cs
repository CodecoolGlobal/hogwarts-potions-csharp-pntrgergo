using HogwartsPotions.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace HogwartsPotions.Data
{
    public class HogwartsContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }

        public DbSet<Student> Students  { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Potion> Potions { get; set; }

        public HogwartsContext(DbContextOptions<HogwartsContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>().ToTable("Student");
            modelBuilder.Entity<Student>().ToTable("Room");
            modelBuilder.Entity<Recipe>().ToTable("Ingredient");
            modelBuilder.Entity<Ingredient>().ToTable("Recipe");
            modelBuilder.Entity<Potion>().ToTable("Potion");
        }
    }
}