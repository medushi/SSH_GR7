using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace SistemeTeShperndaraGR7.Models.FilterHotels
{
    public class FilterHotelsModel
    {
        public string ReservationStartDate { get; set; }
        public string ReservationEndDate { get; set; }
        public int Rating { get; set; }
        public string HasIncludedFreeMeal { get; set; }
        public string Location { get; set; }
        public string HasParking { get; set; }
    }
}