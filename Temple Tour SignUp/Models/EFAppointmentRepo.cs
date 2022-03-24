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
        public IQueryable<Appointment> Appointments => context.Appointments;
        public IQueryable<TimeSlot> TimeSlots => context.TimeSlotResponse;

        public void SaveAppoint(Appointment a)
        {
         
            context.SaveChanges();
        
        } 
        public void CreateAppoint(Appointment a)
        {
            context.Add(a);
            context.SaveChanges();
            
        } 
        public void DeleteAppoint(Appointment a)
        {
            context.Remove(a);
            context.SaveChanges();
        }




    }

    
}
