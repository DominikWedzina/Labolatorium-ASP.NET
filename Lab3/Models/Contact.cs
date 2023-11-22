using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Labolatorium3_App.Models
{
    public enum Priority
    {
        [Display(Name = "Niski")] Low = 1,
        [Display(Name = "Normalny")] Normal = 2,
        [Display(Name = "Wysoki")] High = 3,
        [Display(Name = "Pilny")] Urgent = 4
    }
    public class Contact
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Musisz podać imię!")]
        [StringLength(maximumLength: 50, ErrorMessage = "Zbyt długie imię wpisz max 50 znaków!")]
        [Display(Name = "Imię")]
        public string Name { get; set; }
        [Phone]
        public string Phone { get; set; }
        [Display(Name = "Adres email")]
        [EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? Birth { get; set; }
        [Display(Name = "Priorytet")]
        public Priority Priority { get; set; }

        [HiddenInput]
        public DateTime Created { get; set; }
    }
}
