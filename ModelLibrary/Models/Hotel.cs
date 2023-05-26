using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Models
{
    public class Hotel
    {
        [Key]
        public int HotelId { get; set; }
        public string? HotelName { get; set; }
        public string? HotelLocation { get; set;}
        public string? HotelType { get; set; }
        public string? Feedback { get; set; }
        public ICollection<Room>? Rooms { get; set; }

    }
}
