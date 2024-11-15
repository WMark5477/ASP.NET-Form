using System.ComponentModel.DataAnnotations;

namespace Formularz.Models
{
    public class Dane
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Prosze podaj Imie")]
        [MinLength(2, ErrorMessage = "Imie musi miec co najmniej 2 znaki")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Prosze podaj Nazwisko")]
        [MinLength(2, ErrorMessage = "Nazwisko musi miec co najmniej 2 znaki")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Prosze podaj email")]
        [EmailAddress(ErrorMessage = "Niepoprawny format email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Prosze podaj haslo")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)[A-Za-z\\d]{8,}$", ErrorMessage = "Haslo musi zawierac co najmniej jedna wielka litere, jedna mala litere i jedna cyfre")]
        [MinLength(8, ErrorMessage = "Haslo musi zawierac co najmniej 8 znakow")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Potwierdz haslo")]
        [Compare("Password", ErrorMessage = "Hasla nie sa takie same")]
        public string ConfirmPassword { get; set; }

        [Phone(ErrorMessage = "Niepoprawny format numeru telefonu")]
        public string? Phone { get; set; }

        [Range(10, 80, ErrorMessage = "Wiek musi byc w zakresie 10 do 80 lat")]
        public int? Age { get; set; }

        public string? City { get; set; }

        public enum Cities
        {
            Krakow = 1,
            Katowice = 2,
            Wroclaw = 3,
            Warszawa = 4,
            Torun = 5
        }
    }
}
