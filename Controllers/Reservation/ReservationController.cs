using Newtonsoft.Json;
using SistemeTeShperndaraGR7.Database.Models;
using SistemeTeShperndaraGR7.Database.Services;
using SistemeTeShperndaraGR7.Models.FilterHotels;
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
        static List<RoomFullDataModel> _roomsFullDataModel = new List<RoomFullDataModel>();
        static string _fromDate;
        static string _dueDate;

        // GET: Reservation
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowRooms()
        {
            foreach (var room in _roomsOfSpecificHotel)
            {
                var hotelName = ReservationServices.GetAllHotels().Where(x => x.id == room.hotelId).Select(x => x.name).FirstOrDefault();
                _roomsFullDataModel.Add(new RoomFullDataModel
                {
                    HotelId = room.hotelId,
                    HotelName = hotelName,
                    HasSeaSight = room.hasSeaSight,
                    NumberOfBeds=room.numberOfBeds,
                    RoomId=room.id,
                    Status=room.status,
                    FromDate=_fromDate,
                    DueDate=_dueDate                
                });
            }
            return View(_roomsFullDataModel);
        }
        #region ModelPreparators
        public ActionResult PrepareRoomData(int hotelid,string fromDate,string dueDate)
        {
            var roomsList = new List<Room>();
            _fromDate = fromDate;
            _dueDate = dueDate;
            using (WebClient client = new WebClient())
            {
                var responseJson = client.DownloadString($"https://localhost:44396/api/Reservation/GetRooms?hotelid={hotelid}");
                _roomsOfSpecificHotel = JsonConvert.DeserializeObject<List<Room>>(responseJson);
            }
            return Content(@"https://localhost:44396/Reservation/ShowRooms");
        }
        #endregion

    }
}