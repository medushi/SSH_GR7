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
            return result;
        }

        public int VeqTest([FromBody]int x)
        {
            return x + 10;
        }
       
    }
}