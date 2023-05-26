using HotelApi_BigBang.Db;
using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;

namespace HotelApi_BigBang.Repository
{
    public class HotelRepo : IHotel
    {
        private readonly XyzHotelContext context;
        public HotelRepo(XyzHotelContext context)
        {
            this.context = context;
        }

        public Hotel DeleteHotel(int id)
        {
            Hotel hot = context.Hotels.FirstOrDefault(x => x.HotelId == id);
            context.Remove(hot);
            context.SaveChanges();
            return hot;
        }

        public Hotel GetHotelById(int id)
        {
            return context.Hotels.FirstOrDefault(x => x.HotelId == id);
        }

        public IEnumerable<Hotel> GetHotels()
        {
            return context.Hotels.Include(x=>x.Rooms).ToList();
        }

        public Hotel PostHotel(Hotel h)
        {
            context.Add(h);
            context.SaveChanges();
            return h;
        }

        public Hotel PutHotel(int id, Hotel h)
        {
            context.Entry(h).State = EntityState.Modified;
            context.SaveChanges();
            return h;
        }

        public object Count(int id)
        {
            int c = context.Rooms.Count(room => room.HotelId == id && room.RoomStatus == "Avail");
            var result = new { Count = c + " Rooms available in " + id };
            return result;
        }
        public object RoomList()
        {
            var list = context.Rooms.Select(a => new { a.Hotels.HotelName , a.RoomId }).ToList();
            int count = context.Rooms.Count();
            var result = new { Count = count + " Rooms and their details ;", Hotels = list };
            return result;
        }
    }
}
