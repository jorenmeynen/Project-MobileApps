using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectMobileApps
{
    class Toddler
    {
        public int ToddlerId { get; set; }
        public int ClassGroupId { get; set; }
        public string Name { get; set; }
        public string email { get; set; }

        public ClassGroup ClassGroup { get; set; }
    }
}
