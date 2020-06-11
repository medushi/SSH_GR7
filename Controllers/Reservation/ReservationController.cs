using Newtonsoft.Json;
using SistemeTeShperndaraGR7.Database.Models;
using SistemeTeShperndaraGR7.Database.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace SistemeTeShperndaraGR7.Controllers.Reservation
{
    public class ReservationController : Controller
    {
        static List<Room> _roomsOfSpecificHotel = new List<Room>();

        // GET: Reservation
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult ShowRooms()
        {

            return View(_roomsOfSpecificHotel);
        }
        #region ModelPreparators
        public ActionResult PrepareRoomData(int hotelid)
        {
            var roomsList = new List<Room>();
            using(WebClient client = new WebClient())
            {
                var responseJson = client.DownloadString($"https://localhost:44396/api/Reservation/GetRooms?hotelid={hotelid}");
                _roomsOfSpecificHotel = JsonConvert.DeserializeObject<List<Room>>(responseJson);
            }
            return Content(@"https://localhost:44396/Reservation/ShowRooms");
        }
        #endregion

    }
}