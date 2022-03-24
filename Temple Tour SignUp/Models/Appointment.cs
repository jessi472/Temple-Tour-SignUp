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
        public int AppointmentId { get; set; }
        //link to time slot model like we did with categories
        [Required]
        public string GroupName { get; set; }
        [Required]
        [Range(1, 15)] //(Max of 15)
        public int GroupSize { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Phone { get; set; }

        //Foreign Key Relationship
        [Required]
        public int TimeSlotId { get; set; }
        public TimeSlot TimeSlot { get; set; }

    }
}
