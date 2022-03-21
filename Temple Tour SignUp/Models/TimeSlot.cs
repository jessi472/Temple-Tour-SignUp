using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Temple_Tour_SignUp.Models
{
    public class TimeSlot
    {
        [Key]
        [Required]
        public int TimeSlotId { get; set; }

        [Required]
        public string Date { get; set; }

        [Required]
        public string Time { get; set; }

         public bool Taken { get; set; } 
        //8:00 AM
        //9:00 AM
        //10:00 AM
        //11:00 AM
        //12:00 PM
        //1:00 PM
        //2:00 PM
        //3:00 PM
        //4:00 PM
        //5:00 PM
        //6:00 PM
        //7:00 PM
        //8:00 PM


    }
}
