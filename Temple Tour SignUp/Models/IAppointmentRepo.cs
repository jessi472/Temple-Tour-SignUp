using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Temple_Tour_SignUp.Models
{
    public interface IAppointmentRepo
    {
        IQueryable<Appointment> Appointments { get; }
        IQueryable<TimeSlot> TimeSlots { get; } 
        void SaveAppoint(Appointment a);
        void CreateAppoint(Appointment a);
        void DeleteAppoint(Appointment a);
    }

   
}
