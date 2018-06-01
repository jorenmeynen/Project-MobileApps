using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjectMobileApps.Models
{
    class Adult
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdultId { get; set; }
        public int LoginId { get; set; }
        public Login Login { get; set; }
        public string Name { get; set; }

        public ICollection<Toddler> Toddlers { get; set; }
        public ICollection<ClassGroup> ClassGroups { get; set; }
    }
}
