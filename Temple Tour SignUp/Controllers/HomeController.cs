using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Temple_Tour_SignUp.Models;
using Temple_Tour_SignUp.Models.ViewModels;

namespace Temple_Tour_SignUp.Controllers
{
    public class HomeController : Controller
    {

        private IAppointmentRepo repo;

        public HomeController(IAppointmentRepo temp)
        {
            repo = temp;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TourInfo()
        {
            return View();
        }
        
        
        public IActionResult Contact()
        {
            return View();
        }
     
     
        [HttpGet]
        public IActionResult SignUpSlots(int pageNum = 1)
        {
            int pageSize = 13;

            var x = new AppointmentsViewModel
            {
                TimeSlots = repo.TimeSlots
                .OrderBy(t => t.Date)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalAppointments = repo.TimeSlots.Count(),
                    AppointmentsPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };


            return View(x);
        }

        [HttpGet]
        public IActionResult SignUpForm(int timeSlotId)
        {
            var timeSlot = repo.TimeSlots.FirstOrDefault(x => x.TimeSlotId == timeSlotId);
            timeSlot.Taken = true;
            //repo.SaveAppoint(); //save timeslot as taken

            ViewBag.TimeSlot = timeSlot;

            return View("SignUp");
        }

        [HttpPost]
        public IActionResult SignUpForm(Appointment appt, int timeSlotId)
        {
            if (ModelState.IsValid)
            {

                var timeSlot = repo.TimeSlots.FirstOrDefault(x => x.TimeSlotId == timeSlotId);
                timeSlot.Taken = true;

                ViewBag.TimeSlot = timeSlot;
                repo.CreateAppoint(appt);
                repo.SaveAppoint(appt);


                return View("Confirmation", appt);
            }
            else
            {
                var timeSlot = repo.TimeSlots.FirstOrDefault(x => x.TimeSlotId == timeSlotId);
                timeSlot.Taken = true;

                ViewBag.TimeSlot = timeSlot;
                return View("SignUp", appt);
            }
        }

        public IActionResult Cancellation(int tsId)
        {
            var timeSlot = repo.TimeSlots.FirstOrDefault(x => x.TimeSlotId == tsId);
            if (timeSlot.Taken == true)
            {
                timeSlot.Taken = false;
            }

            return RedirectToAction("SignUpSlots");
        }
    }
}

