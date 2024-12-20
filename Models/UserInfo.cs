using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad alanı zorunlu")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Telefon alanı zorunlu")]
        public string? Telefon { get; set; }
        [Required(ErrorMessage = "Email alanı zorunlu")]
        [EmailAddress(ErrorMessage = "Geçerli bi mail adresi giriniz")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Katılım Durumu alanı zorunlu")]
        public bool? WillAttend { get; set; }

    }
}