using System.ComponentModel.DataAnnotations;

namespace SimpleApp.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your Phone Number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please specify weather you going to attend")]
        public bool? WillAttend { get; set; }
    }
}