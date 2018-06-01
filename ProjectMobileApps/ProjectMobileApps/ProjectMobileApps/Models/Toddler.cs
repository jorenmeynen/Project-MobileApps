﻿using System;
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
        public int AdultId { get; set; }
        public Adult Adult { get; set; }
        public string Name { get; set; }

        public ICollection<Picture> Pictures { get; set; }
    }
}
