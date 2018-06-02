using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjectMobileApps.Models
{
    class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeacherId { get; set; }
        public int LoginId { get; set; }
        public string TeacherName { get; set; }

        public Login Login { get; set; }
        public ICollection<Toddler> Toddlers { get; set; }
        public ICollection<ClassGroup> ClassGroups { get; set; }
    }
}
