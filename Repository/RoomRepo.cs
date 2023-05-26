using HotelApi_BigBang.Db;
using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;

namespace HotelApi_BigBang.Repository
{
    public class RoomRepo:IRoom
    {
        private readonly XyzHotelContext context;
        public RoomRepo(XyzHotelContext context)
        {
            this.context = context;
        }

        public Room DeleteRoom(int id)
        {
            Room ro = context.Rooms.FirstOrDefault(x => x.RoomId == id);
            context.Remove(ro);
            context.SaveChanges();
            return ro;
        }

        public Room GetRoomById(int id)
        {
            return context.Rooms.FirstOrDefault(x => x.RoomId == id);
        }

        public IEnumerable<Room> GetRooms()
        {
            return context.Rooms.ToList();
        }

        public Room PostRoom(Room r)
        {
            context.Add(r);
            context.SaveChanges();
            return r;
        }

        public Room PutRoom(int id, Room r)
        {
            context.Entry(r).State = EntityState.Modified;
            context.SaveChanges();
            return r;
        }
    }
}
