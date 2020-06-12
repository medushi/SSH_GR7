using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemeTeShperndaraGR7.Models.FilterHotels
{
    public class RoomFullDataModel
    {
        public string HotelName { get; set; }
        public int HotelId { get; set; }
        public int RoomId { get; set; }
        public bool HasSeaSight { get; set; }
        public int NumberOfBeds { get; set; }
        public string Status { get; set; }

    }
}