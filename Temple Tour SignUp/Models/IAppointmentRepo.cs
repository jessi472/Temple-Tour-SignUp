using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Temple_Tour_SignUp.Models
{
    public interface IAppointmentRepo
    {
        IQueryable<TimeSlot> TimeSlots { get; }
    }
}
