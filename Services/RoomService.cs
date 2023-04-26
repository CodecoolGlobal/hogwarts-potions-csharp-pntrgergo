using HogwartsPotions.Models.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HogwartsPotions.Services.Interfaces;
using HogwartsPotions.Data;
using HogwartsPotions.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace HogwartsPotions.Services
{
    public class RoomService : IRoomService
    {
        private readonly HogwartsContext _context;

        public RoomService(HogwartsContext context)
        {
            _context = context;
        }

        public async Task AddRoom(Room room)
        {
            await _context.Rooms.AddAsync(room);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRoom(Room room)
        {
            _context.Rooms.Remove(room);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Room>> GetAllRooms()
        {
            return await _context.Rooms.ToListAsync();
        }

        public async Task<Room> GetRoomById(long roomId)
        {
            return await _context.Rooms.Where(r => r.Id == roomId).FirstOrDefaultAsync();
        }

        public async Task<List<Room>> GetRoomsForRatOwners()
        {
            return await _context.Rooms.Where(r => r.Residents.All(res => res.PetType == PetType.Rat)).ToListAsync();
        }

        public async Task UpdateRoomById(Room room)
        {
            _context.Rooms.Update(room);
            await _context.SaveChangesAsync();
        }
    }
}
