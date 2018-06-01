﻿using System;
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
        public Toddler ToddlerId { get; set; }
        public Corner CornerId { get; set; }
        public string Label { get; set; }
        public string Date { get; set; }
        public string Comment { get; set; }
    }
}
