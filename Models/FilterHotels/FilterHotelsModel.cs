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
        public int HasIncludedFreeMeal { get; set; }
        public string Location { get; set; }
        public int HasParking { get; set; }
    }
}