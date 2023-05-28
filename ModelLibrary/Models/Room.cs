using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Models
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        [ForeignKey("Hotel")]
        public int HotelId { get; set; }
        public string? RoomType { get; set; }
        public string? RoomClass { get; set; }
        public int RoomPrice { get; set; }
        public string? RoomStatus { get; set;}
        public Hotel? Hotels { get; set; }

    }
}
