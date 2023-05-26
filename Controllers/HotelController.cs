using HotelApi_BigBang.Db;
using HotelApi_BigBang.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelLibrary.Models;

namespace HotelApi_BigBang.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
            return hotel.GetHotels();
        }
        [HttpGet("{id}")]

        public Hotel GetId(int id)
        {
            return hotel.GetHotelById(id);
        }

        [HttpPost]
        public Hotel Post(Hotel h)
        {
            return hotel.PostHotel(h);
        }
        [HttpPut]
        public Hotel Put(int id, Hotel h)
        {
            return hotel.PutHotel(id, h);
        }
        [HttpDelete]
        public Hotel Delete(int id)
        {
            return hotel.DeleteHotel(id);
        }
        [HttpGet("/count")]
        public async Task<ActionResult<int>> Count()
        {
            int count = hotel.Count();
            return Ok(count);

        }

    }
}
