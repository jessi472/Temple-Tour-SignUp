using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Temple_Tour_SignUp.Models.ViewModels
{
    public class PageInfo
    {
        public int TotalAppointments { get; set; }

        public int AppointmentsPerPage { get; set; }

        public int CurrentPage { get; set; }

        public int TotalPages => (int)Math.Ceiling((double)TotalAppointments / AppointmentsPerPage);
    }
}
