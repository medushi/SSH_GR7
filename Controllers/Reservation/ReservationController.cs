using SistemeTeShperndaraGR7.Database.Models;
using SistemeTeShperndaraGR7.Database.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemeTeShperndaraGR7.Controllers.Reservation
{
    public class ReservationController : Controller
    {
        // GET: Reservation
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FilterClientHotelReservationRequirements()
        {
            var result = ReservationServices.GetAllHotels();
            return PartialView("", result);
        }
    }
}