using Microsoft.EntityFrameworkCore;
using ModelLibrary.Models;
namespace HotelApi_BigBang.Db
{
    public class XyzHotelContext:DbContext
    {
        public DbSet<Hotel>Hotels { get; set; }
        public DbSet<Room>Rooms { get; set; }
        public DbSet<User>Users { get; set; }
        public XyzHotelContext(DbContextOptions<XyzHotelContext> options) : base(options) { }
  
    }
}
