using System;
using System.ComponentModel.DataAnnotations;

namespace TempleTour.Models
{
    public class Appointment
    {
        [Key]
        [Required]
        //foreign key relationship to responses
        public int TourID { get; set; }
        public string TourTime { get; set; }
        public bool Available { get; set; } = true;
    }
}
