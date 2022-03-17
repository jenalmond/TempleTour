using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTour.Models
{
    public class SignUpResponse
    {
        [Required]
        public string GroupName { get; set; }
        [Required]
        public byte GroupSize { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
    }
}
