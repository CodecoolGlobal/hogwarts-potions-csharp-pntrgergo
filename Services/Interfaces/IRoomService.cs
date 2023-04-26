using System.Collections.Generic;
using System.Threading.Tasks;
using HogwartsPotions.Models.Entities;

namespace HogwartsPotions.Services.Interfaces;

public interface IRoomService
{

    Task AddRoomToDb(Room room);
    Task<List<Room>> GetAllRooms();
    Task<Room> GetRoomById(long roomId);
    Task<List<Room>> GetRoomsForRatOwners();
    Task UpdateRoomById(Room room);
    Task DeleteRoom(Room room);
}