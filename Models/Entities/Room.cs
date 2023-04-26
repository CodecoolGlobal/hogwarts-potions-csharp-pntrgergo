using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HogwartsPotions.Models.Entities
{
    public class Room
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public int Capacity { get; set; }
        public HashSet<Student> Residents { get; set; }


        public Room(int capacity)
        {
            Capacity = capacity;
            Residents = new HashSet<Student>();
        }

        public void AddResident(Student resident)
        {
            Residents.Add(resident);
        }

        public void AddResidents(HashSet<Student> residents)
        {
            foreach (Student resident in residents)
            {
                AddResident(resident);
            }
        }
    }
}