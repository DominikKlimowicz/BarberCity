using System.ComponentModel.DataAnnotations;

namespace BarberCity.Klasy
{
    public class UserLogin
    {
        [Required(ErrorMessage = "Nazwa użytkownika jest wymagana")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Hasło jest wymagane")]
        public string Password { get; set; }
    }
}
