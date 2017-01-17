using System;
using System.Collections.Generic;
using System.Text;

namespace ARC_Final_Vision_Inspection
{
    public class PLCPartCounter
    {
        public bool visible { get; set; }
        public int goodParts { get; set; }
        public int rejectParts { get; set; }
        private int partCount;
        public int totalParts { 
            get {
                partCount = goodParts + rejectParts;
                return partCount; } 
            set { partCount = goodParts + rejectParts; } 
        }
        public string goodCountPLCAddress { get; set; }
        public string rejectCountPLCAddress { get; set; }
        public string totalCountPLCAddress { get; set; }
        public PLCButton resetButton = new PLCButton();
    }
}
