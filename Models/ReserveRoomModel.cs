using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemeTeShperndaraGR7.Models
{
    public class ReserveRoomModel
    {
        public string Username { get; set; }
        public int RoomId { get; set; }
        public int HotelId { get; set; }
        public string From { get; set; }
        public string To { get; set; }

    }
}