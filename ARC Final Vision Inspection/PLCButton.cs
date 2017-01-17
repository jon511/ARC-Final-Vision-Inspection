using System;
using System.Collections.Generic;
using System.Text;

namespace ARC_Final_Vision_Inspection
{
    public class PLCButton
    {
        public bool enabled { get; set; }
        public bool visible { get; set; }
        public bool isActive { get; set; }
        public string writeAddress { get; set; }
        public string readAddress { get; set; }
        public string offLabel { get; set; }
        public string onLabel { get; set; }
    }
}
