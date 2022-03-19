using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTour.Models
{
    public class SignUpResponse
    {
        [Key]
        [Required]
        public int GroupID { get; set; }

        [Required]
        public string GroupName { get; set; }

        //max group size is 15
        [Required]
        [Range(0, 15)]
        public int GroupSize { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

       //phone is not required
        [Phone]
        public string Phone { get; set; }

        //foreign key relationship to appointment
        public int TourID { get; set; }
        public Appointment TourTime { get; set; }
    }
}
