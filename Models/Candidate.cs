using System.ComponentModel.DataAnnotations;

namespace Egitimproje.Models
{
    public class Candidate
    {
        [Required(ErrorMessage = "Email is Required.")]
        public string? Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Name is Required.")]
        public string? FirstName { get; set; } = string.Empty;
        [Required(ErrorMessage = "LastName is Required.")]
        public string? LastName { get; set; } = string.Empty;
        public string FullName => $"{FirstName} {LastName?.ToUpper()}";
        public int? Age { get; set; }
        public string? SelectedCourse { get; set; } = string.Empty;
        public DateTime? ApplyAt { get; set; } = DateTime.Now;






    }
}