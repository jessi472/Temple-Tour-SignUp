using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Temple_Tour_SignUp.Models;

namespace Temple_Tour_SignUp.Controllers
{
    public class HomeController : Controller
    {

        private SignUpContext _blahContext { get; set; }

        public HomeController(SignUpContext signUp)
        {
            _blahContext = signUp;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignUpSlots()
        {
            var tours = _blahContext.TimeSlots
                .OrderBy(x => x.Date).ToList();
            return View(tours);
        }

        //[HttpPost]
        //public IActionResult SignUpSlots(int timeSlotId)
        //{
        //    var timeSlot = _blahContext.TimeSlots.FirstOrDefault(x => x.TimeSlotId == timeSlotId);
        //    timeSlot.Taken = true;
        //    ViewBag.TimeSlot = timeSlot;
        //    //_blahContext.Add(ts);
        //    //_blahContext.SaveChanges();
        //    return RedirectToAction("SignUpForm");
        //}

        [HttpGet]
        public IActionResult SignUpForm(int timeSlotId)
        {
            var timeSlot = _blahContext.TimeSlots.FirstOrDefault(x => x.TimeSlotId == timeSlotId);
            timeSlot.Taken = true;
            _blahContext.SaveChanges(); //save timeslot as taken

            ViewBag.TimeSlot = timeSlot;

            return View("SignUp");
        }

        [HttpPost]
        public IActionResult SignUpForm (Appointment appt)
        {
            _blahContext.Appointments.Add(appt);
            _blahContext.SaveChanges();
            return View("Confirmation", appt);
        }
        
    }
}
