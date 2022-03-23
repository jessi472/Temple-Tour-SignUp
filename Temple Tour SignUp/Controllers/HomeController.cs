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

        [HttpGet]
        public IActionResult SignUpSlots( int pageNum = 1)
        {
            int pageSize = 13;

            var x = new AppointmentsViewModel
            {
                TimeSlots = repo.TimeSlots
                .OrderBy(t => t.Date)
                .Skip((pageNum - 1)* pageSize)
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

        //[HttpPost]
        //public IActionResult SignUpSlots(TimeSlot ts)
        //{
        //    context.Add(ts);
        //    context.SaveChanges();
        //    return View();
        //}

        
    }
}
