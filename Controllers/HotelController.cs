using HotelApi_BigBang.Db;
using HotelApi_BigBang.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;

namespace HotelApi_BigBang.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class HotelController : ControllerBase
    {
        private readonly IHotel hotel;
        public HotelController(IHotel hotel)
        {
            this.hotel = hotel;
        }
        [HttpGet]
        public IEnumerable<Hotel> Get()
        {
            try
            {
                return hotel.GetHotels();
            }
            catch (Exception ex)
            {
                throw new Exception("Not able to get the details" + ex.Message);
            }
            
        }
        [HttpGet("{id}")]

        public Hotel GetId(int id)
        {
            try
            {
                return hotel.GetHotelById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Not able to get the details" + ex.Message);
            }

        }

        [HttpPost]
        public Hotel Post(Hotel h)
        {
            try
            {
                return hotel.PostHotel(h);
            }
            catch (Exception ex)
            {
                throw new Exception("Not able to get the details" + ex.Message);
            }
        }
        [HttpPut]
        public Hotel Put(int id, Hotel h)
        {
            try
            {
                return hotel.PutHotel(id, h);
            }
            catch (Exception ex)
            {
                throw new Exception("Not able to get the details" + ex.Message);
            }

        }
        [HttpDelete]
        public Hotel Delete(int id)
        {
            try
            {
                return hotel.DeleteHotel(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Not able to get the details" + ex.Message);
            }
        }
        [HttpGet("/count/{id}")]
        public ActionResult<object> Count(int id)
        {
            try
            {
                var result = hotel.Count(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving the details: " + ex.Message);
            }
        }
        [HttpGet("/room/list")]
        public ActionResult<object> CountList()
        {
            try
            {
                var result = hotel.RoomList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving the details: " + ex.Message);
            }

        }
        [HttpGet("/filter/{location}")]
        public ActionResult<object> GetHotelsByLocation(string location)
        {
            try
            {
                var hotels = hotel.GetHotelsByLocation(location.ToLower());
                return Ok(hotels);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving the details: " + ex.Message);
            }
        }

    }
}
