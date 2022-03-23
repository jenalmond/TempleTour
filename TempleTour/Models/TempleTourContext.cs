using System;
using Microsoft.EntityFrameworkCore;

namespace TempleTour.Models
{
    public class TempleTourContext : DbContext
    {
        public TempleTourContext(DbContextOptions<TempleTourContext> options) : base(options)
        {
        }

        public DbSet<SignUpResponse> responses { get; set; }
        public DbSet<Appointment> appointments { get; set; }

        

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Appointment>().HasData(
                    new Appointment { TourID = 1, TourTime = "8:00am", TourDate = "03/24/2022" },
                    new Appointment { TourID = 2, TourTime = "9:00am", TourDate = "03/24/2022" },
                    new Appointment { TourID = 3, TourTime = "10:00am", TourDate = "03/24/2022" },
                    new Appointment { TourID = 4, TourTime = "11:00am", TourDate = "03/24/2022" },
                    new Appointment { TourID = 5, TourTime = "12:00pm", TourDate = "03/24/2022" },
                    new Appointment { TourID = 6, TourTime = "1:00pm", TourDate = "03/24/2022" },
                    new Appointment { TourID = 7, TourTime = "2:00pm", TourDate = "03/24/2022" },
                    new Appointment { TourID = 8, TourTime = "3:00pm", TourDate = "03/24/2022" },
                    new Appointment { TourID = 9, TourTime = "4:00pm", TourDate = "03/24/2022" },
                    new Appointment { TourID = 10, TourTime = "5:00pm", TourDate = "03/24/2022" },
                    new Appointment { TourID = 11, TourTime = "6:00pm", TourDate = "03/24/2022" },
                    new Appointment { TourID = 12, TourTime = "7:00pm", TourDate = "03/24/2022" },
                    new Appointment { TourID = 13, TourTime = "8:00pm", TourDate = "03/24/2022" },

                    new Appointment { TourID = 14, TourTime = "8:00am", TourDate = "03/25/2022" },
                    new Appointment { TourID = 15, TourTime = "9:00am", TourDate = "03/25/2022" },
                    new Appointment { TourID = 16, TourTime = "10:00am", TourDate = "03/25/2022" },
                    new Appointment { TourID = 17, TourTime = "11:00am", TourDate = "03/25/2022" },
                    new Appointment { TourID = 18, TourTime = "12:00pm", TourDate = "03/25/2022" },
                    new Appointment { TourID = 19, TourTime = "1:00pm", TourDate = "03/25/2022" },
                    new Appointment { TourID = 20, TourTime = "2:00pm", TourDate = "03/25/2022" },
                    new Appointment { TourID = 21, TourTime = "3:00pm", TourDate = "03/25/2022" },
                    new Appointment { TourID = 22, TourTime = "4:00pm", TourDate = "03/25/2022" },
                    new Appointment { TourID = 23, TourTime = "5:00pm", TourDate = "03/25/2022" },
                    new Appointment { TourID = 24, TourTime = "6:00pm", TourDate = "03/25/2022" },
                    new Appointment { TourID = 25, TourTime = "7:00pm", TourDate = "03/25/2022" },
                    new Appointment { TourID = 26, TourTime = "8:00pm", TourDate = "03/25/2022" },

                    new Appointment { TourID = 27, TourTime = "8:00am", TourDate = "03/26/2022" },
                    new Appointment { TourID = 28, TourTime = "9:00am", TourDate = "03/26/2022" },
                    new Appointment { TourID = 29, TourTime = "10:00am", TourDate = "03/26/2022" },
                    new Appointment { TourID = 30, TourTime = "11:00am", TourDate = "03/26/2022" },
                    new Appointment { TourID = 31, TourTime = "12:00pm", TourDate = "03/26/2022" },
                    new Appointment { TourID = 32, TourTime = "1:00pm", TourDate = "03/26/2022" },
                    new Appointment { TourID = 33, TourTime = "2:00pm", TourDate = "03/26/2022" },
                    new Appointment { TourID = 34, TourTime = "3:00pm", TourDate = "03/26/2022" },
                    new Appointment { TourID = 35, TourTime = "4:00pm", TourDate = "03/26/2022" },
                    new Appointment { TourID = 36, TourTime = "5:00pm", TourDate = "03/26/2022" },
                    new Appointment { TourID = 37, TourTime = "6:00pm", TourDate = "03/26/2022" },
                    new Appointment { TourID = 38, TourTime = "7:00pm", TourDate = "03/26/2022" },
                    new Appointment { TourID = 39, TourTime = "8:00pm", TourDate = "03/26/2022" },

                    new Appointment { TourID = 40, TourTime = "8:00am", TourDate = "03/27/2022" },
                    new Appointment { TourID = 41, TourTime = "9:00am", TourDate = "03/27/2022" },
                    new Appointment { TourID = 42, TourTime = "10:00am", TourDate = "03/27/2022" },
                    new Appointment { TourID = 43, TourTime = "11:00am", TourDate = "03/27/2022" },
                    new Appointment { TourID = 44, TourTime = "12:00pm", TourDate = "03/27/2022" },
                    new Appointment { TourID = 45, TourTime = "1:00pm", TourDate = "03/27/2022" },
                    new Appointment { TourID = 46, TourTime = "2:00pm", TourDate = "03/27/2022" },
                    new Appointment { TourID = 47, TourTime = "3:00pm", TourDate = "03/27/2022" },
                    new Appointment { TourID = 48, TourTime = "4:00pm", TourDate = "03/27/2022" },
                    new Appointment { TourID = 49, TourTime = "5:00pm", TourDate = "03/27/2022" },
                    new Appointment { TourID = 50, TourTime = "6:00pm", TourDate = "03/27/2022" },
                    new Appointment { TourID = 51, TourTime = "7:00pm", TourDate = "03/27/2022" },
                    new Appointment { TourID = 52, TourTime = "8:00pm", TourDate = "03/27/2022" },

                    new Appointment { TourID = 53, TourTime = "8:00am", TourDate = "03/28/2022" },
                    new Appointment { TourID = 54, TourTime = "9:00am", TourDate = "03/28/2022" },
                    new Appointment { TourID = 55, TourTime = "10:00am", TourDate = "03/28/2022" },
                    new Appointment { TourID = 56, TourTime = "11:00am", TourDate = "03/28/2022" },
                    new Appointment { TourID = 57, TourTime = "12:00pm", TourDate = "03/28/2022" },
                    new Appointment { TourID = 58, TourTime = "1:00pm", TourDate = "03/28/2022" },
                    new Appointment { TourID = 59, TourTime = "2:00pm", TourDate = "03/28/2022" },
                    new Appointment { TourID = 60, TourTime = "3:00pm", TourDate = "03/28/2022" },
                    new Appointment { TourID = 61, TourTime = "4:00pm", TourDate = "03/28/2022" },
                    new Appointment { TourID = 62, TourTime = "5:00pm", TourDate = "03/28/2022" },
                    new Appointment { TourID = 63, TourTime = "6:00pm", TourDate = "03/28/2022" },
                    new Appointment { TourID = 64, TourTime = "7:00pm", TourDate = "03/28/2022" },
                    new Appointment { TourID = 65, TourTime = "8:00pm", TourDate = "03/28/2022" },

                    new Appointment { TourID = 66, TourTime = "8:00am", TourDate = "03/29/2022" },
                    new Appointment { TourID = 67, TourTime = "9:00am", TourDate = "03/29/2022" },
                    new Appointment { TourID = 68, TourTime = "10:00am", TourDate = "03/29/2022" },
                    new Appointment { TourID = 69, TourTime = "11:00am", TourDate = "03/29/2022" },
                    new Appointment { TourID = 70, TourTime = "12:00pm", TourDate = "03/29/2022" },
                    new Appointment { TourID = 71, TourTime = "1:00pm", TourDate = "03/29/2022" },
                    new Appointment { TourID = 72, TourTime = "2:00pm", TourDate = "03/29/2022" },
                    new Appointment { TourID = 73, TourTime = "3:00pm", TourDate = "03/29/2022" },
                    new Appointment { TourID = 74, TourTime = "4:00pm", TourDate = "03/29/2022" },
                    new Appointment { TourID = 75, TourTime = "5:00pm", TourDate = "03/29/2022" },
                    new Appointment { TourID = 76, TourTime = "6:00pm", TourDate = "03/29/2022" },
                    new Appointment { TourID = 77, TourTime = "7:00pm", TourDate = "03/29/2022" },
                    new Appointment { TourID = 78, TourTime = "8:00pm", TourDate = "03/29/2022" },

                    new Appointment { TourID = 79, TourTime = "8:00am", TourDate = "03/30/2022" },
                    new Appointment { TourID = 80, TourTime = "9:00am", TourDate = "03/30/2022" },
                    new Appointment { TourID = 81, TourTime = "10:00am", TourDate = "03/30/2022" },
                    new Appointment { TourID = 82, TourTime = "11:00am", TourDate = "03/30/2022" },
                    new Appointment { TourID = 83, TourTime = "12:00pm", TourDate = "03/30/2022" },
                    new Appointment { TourID = 84, TourTime = "1:00pm", TourDate = "03/30/2022" },
                    new Appointment { TourID = 85, TourTime = "2:00pm", TourDate = "03/30/2022" },
                    new Appointment { TourID = 86, TourTime = "3:00pm", TourDate = "03/30/2022" },
                    new Appointment { TourID = 87, TourTime = "4:00pm", TourDate = "03/30/2022" },
                    new Appointment { TourID = 88, TourTime = "5:00pm", TourDate = "03/30/2022" },
                    new Appointment { TourID = 89, TourTime = "6:00pm", TourDate = "03/30/2022" },
                    new Appointment { TourID = 90, TourTime = "7:00pm", TourDate = "03/30/2022" },
                    new Appointment { TourID = 91, TourTime = "8:00pm", TourDate = "03/30/2022" }
                    );
        }
    }
}
