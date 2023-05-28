using HotelApi_BigBang.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelLibrary.Models;

namespace HotelApi_BigBang.Controllers
{
    [Authorize(Roles = "Admin,User")]
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
            try
            {
                return room.GetRooms();
            }
            catch (Exception ex)
            {
                throw new Exception("Not able to get the details" + ex.Message);

            }

        }
        [HttpGet("{id}")]

        public Room GetId(int id)
        {
            try
            {
                return room.GetRoomById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Not able to get the details" + ex.Message);

            }
        }

        [HttpPost]
        public Room Post(Room r)
        {
            try
            {
                return room.PostRoom(r);
            }
            catch (Exception ex)
            {
                throw new Exception("Not able to get the details" + ex.Message);

            }
        }
        [HttpPut]
        public Room Put(int id, Room r)
        {
            try
            {
                return room.PutRoom(id, r);
            }
            catch (Exception ex)
            {
                throw new Exception("Not able to get the details" + ex.Message);

            }
        }
        [HttpDelete]
        public Room Delete(int id)
        {
            try
            {
                return room.DeleteRoom(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Not able to get the details" + ex.Message);

            }
        }
        [HttpGet("Avail/{maxPrice}")]
        public ActionResult<object> GetAvailableRoomsByHotelIdAndPriceRange(int maxPrice)
        {
            try
            {
                return room.GetAvailableRoomsByPriceRange(maxPrice);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving the details: " + ex.Message);
            }

        }
        [HttpGet("/room/filter/{aminities}")]
        public ActionResult<object> GetRoomsByType(string aminities)
        {
            try
            {
                var roo = room.GetRoomsByType(aminities.ToLower());
                return Ok(roo);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving the details: " + ex.Message);
            }
        }
    }
}

