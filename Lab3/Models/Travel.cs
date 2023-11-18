using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Labolatorium3_App.Models
{
    // Travel - nazwa, data rozpoczęcia i końca, miejsce początkowe i końcowe, uczestnicy, przewodnik
    public class Travel
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please add the name of the travel")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Please add the start place")]
        public string StartPlace { get; set; }

        [Required(ErrorMessage = "Please add the end place")]
        public string EndPlace { get; set; }

        [Required(ErrorMessage = "Participants are required")]
        public List<string> Participants { get; set; }
        public string Guide { get; set; }


    }
}
