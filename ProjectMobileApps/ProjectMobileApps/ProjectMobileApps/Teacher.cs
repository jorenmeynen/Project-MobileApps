using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectMobileApps
{
    class Teacher
    {
        public int Teacher_Id { get; set; }
        public int ClassGroup_Id { get; set; }
        public ClassGroup ClassGroup { get; set; }
        public string Name { get; set; }
    }
}
