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
            var tours = _blahContext.TimeSlotResponse
                .OrderBy(x => x.Date).ToList();
            return View(tours);
        }

        [HttpPost]
        public IActionResult SignUpSlots(TimeSlot ts)
        {
            _blahContext.Add(ts);
            _blahContext.SaveChanges();
            return View();
        }

        
    }
}
