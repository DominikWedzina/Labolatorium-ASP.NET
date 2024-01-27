using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("travels")]
    internal class TravelEntity
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
        public List<string> Participants { get; set; }
        [MaxLength(50)]
        [Required]
        public string Guide { get; set; }
    }
}
