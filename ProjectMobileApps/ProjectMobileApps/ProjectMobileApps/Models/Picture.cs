using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjectMobileApps.Models
{
    class Picture
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
