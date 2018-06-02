using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjectMobileApps.Models
{
    class Parent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ParentId { get; set; }
        public int LoginId { get; set; }
        public string ParentName { get; set; }

        public Login Login { get; set; }
        public ICollection<Toddler> Toddlers { get; set; }
    }
}
