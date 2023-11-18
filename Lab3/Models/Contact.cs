using System.ComponentModel.DataAnnotations;

namespace Labolatorium3_App.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Musisz podać imię!")]
        [StringLength(maximumLength: 50, ErrorMessage = "Zbyt długie imię wpisz max 50 znaków!")]
        public string Name { get; set; }
        [Phone]
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? Birth { get; set; }
    }
}
