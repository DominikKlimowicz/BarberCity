using System.ComponentModel.DataAnnotations;

namespace BarberCity.Klasy
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Podaj imię")]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "Podaj email")]
        [EmailAddress(ErrorMessage = "Niepoprawny format email")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Wybierz datę wizyty")]
        public DateTime AppointmentDate { get; set; } = DateTime.Today;

        [Required(ErrorMessage = "Wybierz usługę")]
        public string Service { get; set; } = "";
    }
}
