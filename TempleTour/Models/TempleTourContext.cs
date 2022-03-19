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
                    new Appointment { TourID = 1, TourTime = "8:00am" },
                    new Appointment { TourID = 2, TourTime = "9:00am" },
                    new Appointment { TourID = 3, TourTime = "10:00am" },
                    new Appointment { TourID = 4, TourTime = "11:00am" },
                    new Appointment { TourID = 5, TourTime = "12:00pm" },
                    new Appointment { TourID = 6, TourTime = "1:00pm" },
                    new Appointment { TourID = 7, TourTime = "2:00pm" },
                    new Appointment { TourID = 8, TourTime = "3:00pm" },
                    new Appointment { TourID = 9, TourTime = "4:00pm" },
                    new Appointment { TourID = 10, TourTime = "5:00pm" },
                    new Appointment { TourID = 11, TourTime = "6:00pm" },
                    new Appointment { TourID = 12, TourTime = "7:00pm" },
                    new Appointment { TourID = 13, TourTime = "8:00pm" });
        }
    }
}
