using System.ComponentModel.DataAnnotations;

namespace BarberCity.Klasy
{
    public class UserRegistration
    {
        [Required(ErrorMessage = "Nazwa użytkownika jest wymagana.")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "Nazwa użytkownika musi mieć od 3 do 255 znaków.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Adres e-mail jest wymagany.")]
        [EmailAddress(ErrorMessage = "Podaj poprawny adres e-mail.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Hasło jest wymagane.")]
        [StringLength(255, MinimumLength = 6, ErrorMessage = "Hasło musi mieć co najmniej 6 znaków.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Potwierdzenie hasła jest wymagane.")]
        [Compare("Password", ErrorMessage = "Hasła muszą być takie same.")]
        public string ConfirmPassword { get; set; }

        public DateTime RegistrationDate { get; set; } = DateTime.Now;
    }
}
