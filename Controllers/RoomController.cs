using System.Collections.Generic;
using System.Threading.Tasks;
using HogwartsPotions.Data;
using HogwartsPotions.Models.Entities;
using HogwartsPotions.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HogwartsPotions.Controllers
{
    [ApiController, Route("/room")]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public async Task<List<Room>> GetAllRooms()
        {
            return await _roomService.GetAllRooms();
        }

        [HttpPost]
        public async  Task AddRoom([FromBody] Room room)
        {
            await _roomService.AddRoom(room);
        }

        [HttpGet("/{id}")]
        public async Task<Room> GetRoomById(long id)
        {
            return await _roomService.GetRoomById(id);
        }

        [HttpPut("/{id}")]
        public void UpdateRoomById(long id, [FromBody] Room updatedRoom)
        {
            _roomService.UpdateRoomById(updatedRoom);
        }

        [HttpDelete("/{id}")]
        public async Task DeleteRoomById(Room room)
        {
            await _roomService.DeleteRoom(room);
        }

        [HttpGet("/rat-owners")]
        public async Task<List<Room>> GetRoomsForRatOwners()
        {
            return await _roomService.GetRoomsForRatOwners();
        }
    }
}
