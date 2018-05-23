using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectMobileApps
{
    class Picture
    {
        public int PictureId { get; set; }
        public int ToddlerId { get; set; }
        public int CornerId { get; set; }
        public string Location { get; set; }
        public string Label { get; set; }
        public string Date { get; set; }
        public string Comment { get; set; }
        
        public Toddler Toddler { get; set; }
        public Corner Corner { get; set; }
    }
}
