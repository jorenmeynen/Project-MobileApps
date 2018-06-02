using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjectMobileApps.Models
{
    public class ClassGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClassGroupId { get; set; }
        public int TeacherId { get; set; }
        public string ClassGroupName { get; set; }
        
        public Teacher Teacher { get; set; }
        public ICollection<Corner> Corners { get; set; }
    }
}
