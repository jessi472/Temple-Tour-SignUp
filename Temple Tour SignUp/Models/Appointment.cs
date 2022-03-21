using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Temple_Tour_SignUp.Models
{
    public class Appointment
    {
        [Key]
        [Required]
        int AppointmentId { get; set; }
        //link to time slot model like we did with categories
        [Required]
        string GroupName { get; set; }
        [Required]
        [Range(1, 15)] //(Max of 15)
        int GroupSize { get; set; }
        [Required]
        string Email { get; set; }
        string Phone { get; set; }

        //Foreign Key Relationship
        [Required]
        int TimeSlotId { get; set; }
        public TimeSlot TimeSlot { get; set; }
    }
}
