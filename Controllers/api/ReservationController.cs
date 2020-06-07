using MySqlX.XDevAPI.Common;
using SistemeTeShperndaraGR7.Database.Models;
using SistemeTeShperndaraGR7.Database.Services;
using SistemeTeShperndaraGR7.Models.FilterHotels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SistemeTeShperndaraGR7.Controllers.api
{
    public class ReservationController : ApiController
    {

        
        // GET api/<controller>/5
        public List<HotelFullDataModel> FilterHotels([FromBody] FilterHotelsModel filtermodel)
        {
            var allhotels = ReservationServices.GetAllHotels();
            var allhotelspecs = ReservationServices.GetAllHotelSpecs();
            var result = new List<HotelFullDataModel>();

            foreach(var hotel in allhotels)
            {
                if (allhotelspecs.ContainsKey(hotel.id))
                {
                    result.Add(new HotelFullDataModel
                    {
                        HotelId=hotel.id,
                        Name=hotel.name,
                        Location=hotel.location,
                        Rating=hotel.rating,
                        HasConferenceRoom=allhotelspecs[hotel.id].hasConferenceRoom,
                        HasFreeIncludedMeal=allhotelspecs[hotel.id].hasFreeBreakFast,
                        HasParking=allhotelspecs[hotel.id].hasParking,
                        TotalRooms=hotel.totalrooms
                    });
                }
            }
            if (filtermodel.Location != "All")
                result = result.Where(x => x.Location == filtermodel.Location).ToList();
            if (filtermodel.Rating != 0)
                result = result.Where(x => x.Rating == filtermodel.Rating).ToList();
            if (filtermodel.HasIncludedFreeMeal !=2)
            {
                result = result.Where(x => x.HasFreeIncludedMeal==Convert.ToBoolean(filtermodel.HasIncludedFreeMeal)).ToList();
            }
            if(filtermodel.HasParking!=2)
            {
                result = result.Where(x => x.HasParking == Convert.ToBoolean(filtermodel.HasParking)).ToList();
            }
            return result;
        }

        public int VeqTest([FromBody]int x)
        {
            return x + 10;
        }
       
    }
}