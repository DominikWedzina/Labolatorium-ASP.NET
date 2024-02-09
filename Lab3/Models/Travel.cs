using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Labolatorium3_App.Models
{
    // Travel - nazwa, data rozpoczęcia i końca, miejsce początkowe i końcowe, uczestnicy, przewodnik
    public class Travel
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please add the name of the travel")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Display(Name = "End date")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Display(Name = "Start place")]
        [Required(ErrorMessage = "Please add the start place")]
        public string StartPlace { get; set; }

        [Display(Name = "End place")]
        [Required(ErrorMessage = "Please add the end place")]
        public string EndPlace { get; set; }

        [Display(Name = "Participants")]
        [Required(ErrorMessage = "Participants are required")]
        public string Participants { get; set; }

        [Display(Name = "Guide")]
        [HiddenInput]

        public int GuideId { get; set; }

        [ValidateNever]
        public List<SelectListItem> Guides { get; set; }

        [HiddenInput]
        public int OrganizationId { get; set; }

        [ValidateNever]
        public List<SelectListItem> Organizations { get; set; }
    }
}
