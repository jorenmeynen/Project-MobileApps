using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMobileApps.Models
{
    public class Corner
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CornerId { get; set; }
        public string CornerName { get; set; }
        public string CornerImage { get; set; }

        //public int ClassGroupId { get; set; }
        //public ClassGroup ClassGroup { get; set; }
        //public ICollection<Picture> Pictures { get; set; }
    }
}
