using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemeTeShperndaraGR7.Models.FilterHotels
{
    public class HotelFullDataModel
    {
        public  int HotelId { get; set; }
        public string Location { get; set; }
        public int Rating { get; set; }
        public string Name { get; set; }
        public int TotalRooms { get; set; }
        public bool HasParking { get; set; }
        public bool HasFreeIncludedMeal { get; set; }
        public bool HasConferenceRoom { get; set; }

    }
}