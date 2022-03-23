using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Temple_Tour_SignUp.Models.ViewModels
{
    public class AppointmentsViewModel
    {
        public IQueryable<TimeSlot> TimeSlots { get; set; }

        public PageInfo PageInfo { get; set; }
    }
}
