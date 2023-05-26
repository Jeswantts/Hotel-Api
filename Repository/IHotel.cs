using ModelLibrary.Models;

namespace HotelApi_BigBang.Repository
{
    public interface IHotel
    {
        public IEnumerable<Hotel> GetHotels();
        public Hotel GetHotelById(int id);
        public Hotel PostHotel(Hotel h);
        public Hotel PutHotel(int id, Hotel h);
        public Hotel DeleteHotel(int id);
    }
}
