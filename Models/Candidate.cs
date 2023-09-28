using System.ComponentModel.DataAnnotations;
namespace BtkAkademi.Models
{
    public class Candidate
    {
        [Required(ErrorMessage="E-mail alanı gereklidir")]
        public String? Email { get; set; } = String.Empty;
        [Required(ErrorMessage="İsim alanı gereklidir")]
        public String? FirstName { get; set; } = String.Empty;
        [Required(ErrorMessage="Soyisim alanı gereklidir")]
        public String? LastName { get; set; } = String.Empty;
        public String? FullName =>$"{FirstName} {LastName?.ToUpper()}";       
        public int? Age { get; set; }
        public String? SelectedCourse { get; set; } = String.Empty;
        public DateTime ApplyAt { get; set; }

        public Candidate()
        {
            ApplyAt=DateTime.Now;
        }
    }
}