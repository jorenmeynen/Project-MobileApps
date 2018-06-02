using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMobileApps.Models
{
    public class Picture
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PictureId { get; set; }
        public int ToddlerId { get; set; }
        public int CornerId { get; set; }
        public string Label { get; set; }
        public string Date { get; set; }
        public string Comment { get; set; }

        public Toddler Toddler { get; set; }
        public Corner Corner { get; set; }
    }
}
