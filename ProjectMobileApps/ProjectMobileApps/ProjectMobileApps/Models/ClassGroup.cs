﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjectMobileApps.Models
{
    class ClassGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClassGroupId { get; set; }
        public int TeacherId { get; set; }
        public Adult Adult { get; set; }
        public string Name { get; set; }
        
        public ICollection<Corner> Corners { get; set; }
    }
}
