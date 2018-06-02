using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjectMobileApps.Models
{
    class Toddler
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ToddlerId { get; set; }
        public int ParentId { get; set; }
        public int TeacherId { get; set; }
        public string ToddlerName { get; set; }
        public string ToddlerImage { get; set; }

        public Parent Parent { get; set; }
        public Teacher Teacher { get; set; }
        public ICollection<Picture> Pictures { get; set; }
    }
}
