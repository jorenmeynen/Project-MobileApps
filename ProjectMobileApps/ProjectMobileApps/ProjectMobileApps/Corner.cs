using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectMobileApps
{
    class Corner
    {
        public int CornerId { get; set; }
        public int ClassGroupId { get; set; }
        public string Name { get; set; }

        public ClassGroup ClassGroup { get; set; }

        public ICollection<Picture> Pictures { get; set; }
    }
}
