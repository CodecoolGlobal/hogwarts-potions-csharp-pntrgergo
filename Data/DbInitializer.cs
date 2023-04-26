using System.Collections.Generic;
using System.Linq;
using HogwartsPotions.Models.Entities;
using HogwartsPotions.Models.Enums;

namespace HogwartsPotions.Data
{
    public class DbInitializer
    {
        public static void Initialize(HogwartsContext context)
        {
            context.Database.EnsureCreated();


            if (
                context.Students.Any() ||
                context.Rooms.Any() ||
                context.Recipes.Any() ||
                context.Potions.Any() ||
                context.Ingredients.Any()
            )
            {
                return;
            }

            Student harry = new Student("Harry Potter", HouseType.Gryffindor, PetType.Owl);
            Student hermione = new Student("Hermione Granger", HouseType.Gryffindor, PetType.Cat);
            Student ron = new Student("Ron Weasley", HouseType.Gryffindor, PetType.Rat);
            Student draco = new Student("Draco Malfoy", HouseType.Slytherin, PetType.Owl);
            Student drStrange = new Student("Dr. Stephen Strange", HouseType.Ravenclaw, PetType.None);
            HashSet<Student> students = new HashSet<Student>() { harry, hermione, ron, draco, drStrange };

            // Rooms
            Room room1 = new Room(5);
            Room room2 = new Room(5);
            Room room3 = new Room(5);
            Room room4 = new Room(5);
            Room room5 = new Room(5);
            HashSet<Room> rooms = new HashSet<Room>() { room1, room2, room3, room4, room5 };
        }
    }
}
