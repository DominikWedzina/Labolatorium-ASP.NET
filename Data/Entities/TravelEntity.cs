using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    [Table("Travels")]
    public class TravelEntity
    {
        public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime EndDate { get; set; }
        [MaxLength(50)]
        [Required]
        public string StartPlace { get; set; }

        [MaxLength(50)]
        [Required]
        public string EndPlace { get; set; }

        [Required]
        public string Participants { get; set; }
        public int OrganizationId { get; set; }
        public OrganizationEntity? Organization { get; set; }

        public int GuideId { get; set; }
        [Required]
        public GuideEntity? Guide { get; set; }
    }
}
