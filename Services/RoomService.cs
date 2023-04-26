using HogwartsPotions.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using HogwartsPotions.Services.Interfaces;

namespace HogwartsPotions.Services
{
    public class RoomService : IRoomService
    {
        public Task AddRoom(Room room)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteRoom(Room room)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Room>> GetAllRooms()
        {
            throw new System.NotImplementedException();
        }

        public Task<Room> GetRoom(long roomId)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Room>> GetRoomsForRatOwners()
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateRoom(Room room)
        {
            throw new System.NotImplementedException();
        }
    }
}
