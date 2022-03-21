using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Temple_Tour_SignUp.Models
{
    public class SignUpContext : DbContext
    {
        public SignUpContext(DbContextOptions<SignUpContext> options) : base(options)
        {
        }

        public DbSet<TimeSlot> TimeSlotResponse { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<TimeSlot>().HasData(
                //Day1
                new TimeSlot
                {
                    TimeSlotId = 1,
                    Date = "03-20-2022",
                    Time = "8:00 AM",
                    Taken = true

                },
                
                new TimeSlot
                {
                    TimeSlotId =2,
                    Date = "03-20-2022",
                    Time = "9:00 AM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 3,
                    Date = "03-20-2022",
                    Time = "10:00 AM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 4,
                    Date = "03-20-2022",
                    Time = "11:00 AM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 5,
                    Date = "03-20-2022",
                    Time = "12:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 6,
                    Date = "03-20-2022",
                    Time = "1:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 7,
                    Date = "03-20-2022",
                    Time = "2:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 8,
                    Date = "03-20-2022",
                    Time = "3:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 9,
                    Date = "03-20-2022",
                    Time = "4:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 10,
                    Date = "03-20-2022",
                    Time = "5:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 11,
                    Date = "03-20-2022",
                    Time = "6:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 12,
                    Date = "03-20-2022",
                    Time = "7:00 PM",
                    Taken = false
                },
                new TimeSlot
                {
                    TimeSlotId = 13,
                    Date = "03-20-2022",
                    Time = "8:00 PM",
                    Taken = false
                },

                //Day 2
                new TimeSlot
                {
                    TimeSlotId = 14,
                    Date = "03-21-2022",
                    Time = "8:00 AM",
                    Taken = false

                },

                new TimeSlot
                {
                    TimeSlotId = 15,
                    Date = "03-21-2022",
                    Time = "9:00 AM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 16,
                    Date = "03-21-2022",
                    Time = "10:00 AM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 17,
                    Date = "03-21-2022",
                    Time = "11:00 AM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 18,
                    Date = "03-21-2022",
                    Time = "12:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 19,
                    Date = "03-21-2022",
                    Time = "1:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 20,
                    Date = "03-21-2022",
                    Time = "2:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 21,
                    Date = "03-21-2022",
                    Time = "3:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 22,
                    Date = "03-21-2022",
                    Time = "4:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 23,
                    Date = "03-21-2022",
                    Time = "5:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 24,
                    Date = "03-21-2022",
                    Time = "6:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 25,
                    Date = "03-21-2022",
                    Time = "7:00 PM",
                    Taken = false
                },
                new TimeSlot
                {
                    TimeSlotId = 26,
                    Date = "03-21-2022",
                    Time = "8:00 PM",
                    Taken = false
                },

                //Day 3
                new TimeSlot
                {
                    TimeSlotId = 27,
                    Date = "03-22-2022",
                    Time = "8:00 AM",
                    Taken = false

                },

                new TimeSlot
                {
                    TimeSlotId = 28,
                    Date = "03-22-2022",
                    Time = "9:00 AM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 29,
                    Date = "03-22-2022",
                    Time = "10:00 AM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 30,
                    Date = "03-22-2022",
                    Time = "11:00 AM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 31,
                    Date = "03-22-2022",
                    Time = "12:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 32,
                    Date = "03-22-2022",
                    Time = "1:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 33,
                    Date = "03-22-2022",
                    Time = "2:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 34,
                    Date = "03-22-2022",
                    Time = "3:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 35,
                    Date = "03-22-2022",
                    Time = "4:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 36,
                    Date = "03-22-2022",
                    Time = "5:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 37,
                    Date = "03-22-2022",
                    Time = "6:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 38,
                    Date = "03-22-2022",
                    Time = "7:00 PM",
                    Taken = false
                },
                new TimeSlot
                {
                    TimeSlotId = 39,
                    Date = "03-22-2022",
                    Time = "8:00 PM",
                    Taken = false
                },

                //Day 4
                new TimeSlot
                {
                    TimeSlotId = 40,
                    Date = "03-23-2022",
                    Time = "8:00 AM",
                    Taken = false

                },

                new TimeSlot
                {
                    TimeSlotId = 41,
                    Date = "03-23-2022",
                    Time = "9:00 AM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 42,
                    Date = "03-23-2022",
                    Time = "10:00 AM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 43,
                    Date = "03-23-2022",
                    Time = "11:00 AM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 44,
                    Date = "03-23-2022",
                    Time = "12:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 45,
                    Date = "03-23-2022",
                    Time = "1:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 46,
                    Date = "03-23-2022",
                    Time = "2:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 47,
                    Date = "03-23-2022",
                    Time = "3:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 48,
                    Date = "03-23-2022",
                    Time = "4:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 49,
                    Date = "03-23-2022",
                    Time = "5:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 50,
                    Date = "03-23-2022",
                    Time = "6:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 51,
                    Date = "03-23-2022",
                    Time = "7:00 PM",
                    Taken = false
                },
                new TimeSlot
                {
                    TimeSlotId = 52,
                    Date = "03-23-2022",
                    Time = "8:00 PM",
                    Taken = false
                },

                //Day 5
                new TimeSlot
                {
                    TimeSlotId = 53,
                    Date = "03-24-2022",
                    Time = "8:00 AM",
                    Taken = false

                },

                new TimeSlot
                {
                    TimeSlotId = 54,
                    Date = "03-24-2022",
                    Time = "9:00 AM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 55,
                    Date = "03-24-2022",
                    Time = "10:00 AM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 56,
                    Date = "03-24-2022",
                    Time = "11:00 AM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 57,
                    Date = "03-24-2022",
                    Time = "12:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 58,
                    Date = "03-24-2022",
                    Time = "1:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 59,
                    Date = "03-24-2022",
                    Time = "2:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 60,
                    Date = "03-24-2022",
                    Time = "3:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 61,
                    Date = "03-24-2022",
                    Time = "4:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 62,
                    Date = "03-24-2022",
                    Time = "5:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 63,
                    Date = "03-24-2022",
                    Time = "6:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 64,
                    Date = "03-24-2022",
                    Time = "7:00 PM",
                    Taken = false
                },
                new TimeSlot
                {
                    TimeSlotId = 65,
                    Date = "03-24-2022",
                    Time = "8:00 PM",
                    Taken = false
                },

                //Day 6
                new TimeSlot
                {
                    TimeSlotId = 66,
                    Date = "03-25-2022",
                    Time = "8:00 AM",
                    Taken = false

                },

                new TimeSlot
                {
                    TimeSlotId = 67,
                    Date = "03-25-2022",
                    Time = "9:00 AM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 68,
                    Date = "03-25-2022",
                    Time = "10:00 AM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 69,
                    Date = "03-25-2022",
                    Time = "11:00 AM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 70,
                    Date = "03-25-2022",
                    Time = "12:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 71,
                    Date = "03-25-2022",
                    Time = "1:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 72,
                    Date = "03-25-2022",
                    Time = "2:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 73,
                    Date = "03-25-2022",
                    Time = "3:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 74,
                    Date = "03-25-2022",
                    Time = "4:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 75,
                    Date = "03-25-2022",
                    Time = "5:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 76,
                    Date = "03-25-2022",
                    Time = "6:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 77,
                    Date = "03-25-2022",
                    Time = "7:00 PM",
                    Taken = false
                },
                new TimeSlot
                {
                    TimeSlotId = 78,
                    Date = "03-25-2022",
                    Time = "8:00 PM",
                    Taken = false
                },

                //Day 7
                new TimeSlot
                {
                    TimeSlotId = 79,
                    Date = "03-26-2022",
                    Time = "8:00 AM",
                    Taken = false

                },

                new TimeSlot
                {
                    TimeSlotId = 80,
                    Date = "03-26-2022",
                    Time = "9:00 AM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 81,
                    Date = "03-26-2022",
                    Time = "10:00 AM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 82,
                    Date = "03-26-2022",
                    Time = "11:00 AM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 83,
                    Date = "03-26-2022",
                    Time = "12:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 84,
                    Date = "03-26-2022",
                    Time = "1:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 85,
                    Date = "03-26-2022",
                    Time = "2:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 86,
                    Date = "03-26-2022",
                    Time = "3:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 87,
                    Date = "03-26-2022",
                    Time = "4:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 88,
                    Date = "03-26-2022",
                    Time = "5:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 89,
                    Date = "03-26-2022",
                    Time = "6:00 PM",
                    Taken = false
                },

                new TimeSlot
                {
                    TimeSlotId = 90,
                    Date = "03-26-2022",
                    Time = "7:00 PM",
                    Taken = false
                },
                new TimeSlot
                {
                    TimeSlotId = 91,
                    Date = "03-26-2022",
                    Time = "8:00 PM",
                    Taken = false
                }

                );
        }

        public DbSet<Appointment> Appointments { get; set; }
    }
}
