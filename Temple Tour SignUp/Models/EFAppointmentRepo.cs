using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Temple_Tour_SignUp.Models
{
    public class EFAppointmentRepo : IAppointmentRepo
    {
        private SignUpContext context { get; set; }

        public EFAppointmentRepo (SignUpContext temp)
        {
            context = temp;

        }

        public IQueryable<TimeSlot> TimeSlots => context.TimeSlotResponse;
    }
}
