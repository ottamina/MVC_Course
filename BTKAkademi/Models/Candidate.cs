using System.ComponentModel.DataAnnotations;
// bu sınıf, başvuru yapan adayların bilgilerini temsil eder. Adayın e-posta, ad, soyad, yaş, seçilen kurs ve başvuru tarihi gibi bilgilerini içerir. Ayrıca, bazı özellikler için doğrulama kuralları eklenmiştir (örneğin, e-posta, ad ve soyad alanlarının doldurulması zorunludur).

namespace BTKAkademi.Models
{
    public class Candidate
    {
        [Required(ErrorMessage = "Email is required")]
        public String? Email { get; set; } = String.Empty;

        [Required(ErrorMessage = "First name is required")]
        public String? FirstName { get; set; } = String.Empty;

        [Required(ErrorMessage = "Last name is required")]
        public String? LastName { get; set; } = String.Empty;
        public String? FullName => $"{FirstName} {LastName?.ToUpper()}";
        public int? Age { get; set; }
        public String? SelectedCourse { get; set; } = String.Empty;
        public DateTime ApplyAt { get; set; }

        public Candidate()
        {
            ApplyAt = DateTime.Now;
        }
    
    
    }
}