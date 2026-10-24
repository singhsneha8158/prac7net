using System.ComponentModel.DataAnnotations;

namespace Practical_7.Models
{
    public class Feedback
    {
        [Required(ErrorMessage = "Enrollment No is required")]
        public string EnrollmentNo { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Subject is required")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Rating is required")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Comments are required")]
        public string Comments { get; set; }
    }
}