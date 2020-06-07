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
        public List<Hotel> FilterHotels([FromUri] FilterHotelsModel filtermodel)
        {
            var result = ReservationServices.GetAllHotels();
            if (filtermodel.Location != "Te gjitha")
                result = result.Where(x => x.location == filtermodel.Location).ToList();
            if (filtermodel.Rating != 0)
                result = result.Where(x => x.rating == filtermodel.Rating).ToList();
            if (filtermodel.HasIncludedFreeMeal !="Te gjitha")
            {
                //e mofidikon me kthy ni model tjeter qe mushet...e bajm hotel_specs ne dictionary me id te hotelit manej mujm mi kqyr 
                //edhe propery si hasincludedfreemeal,hasparking,hasconferenceroom.
            }               
            return result;
        }

        public int VeqTest([FromBody]int x)
        {
            return x + 10;
        }
       
    }
}