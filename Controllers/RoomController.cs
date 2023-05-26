using HotelApi_BigBang.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelLibrary.Models;

namespace HotelApi_BigBang.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoom room;
        public RoomController(IRoom room)
        {
            this.room = room;
        }
        [HttpGet]
        public IEnumerable<Room> Get()
        {
            return room.GetRooms();
        }
        [HttpGet("{id}")]

        public Room GetId(int id)
        {
            return room.GetRoomById(id);
        }

        [HttpPost]
        public Room Post(Room r)
        {
            return room.PostRoom(r);    
        }
        [HttpPut]
        public Room Put(int id, Room r)
        {
            return room.PutRoom(id, r);
        }
        [HttpDelete]
        public Room Delete(int id)
        {
            return room.DeleteRoom(id);
        }
    }
}

