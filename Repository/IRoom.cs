using ModelLibrary.Models;

namespace HotelApi_BigBang.Repository
{
    public interface IRoom
    {
        public IEnumerable<Room> GetRooms();
        public Room GetRoomById(int id);
        public Room PostRoom(Room r);
        public Room PutRoom(int id, Room r);
        public Room DeleteRoom(int id);
        public object GetAvailableRoomsByPriceRange(int maxPrice);
    }
}
