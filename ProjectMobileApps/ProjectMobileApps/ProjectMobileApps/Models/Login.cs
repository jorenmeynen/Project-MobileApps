using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjectMobileApps.Models
{
    class Login
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LoginId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Adult Name { get; set; }
    }
}
