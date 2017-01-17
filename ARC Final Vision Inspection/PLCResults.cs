using System;
using System.Collections.Generic;
using System.Text;

namespace ARC_Final_Vision_Inspection
{
    public class PLCResults
    {
        public bool visible { get; set; }
        public string resultTitle { get; set; }
        public string plcResult1Title { get; set; }
        public string plcResult1Address { get; set; }
        public string plcResult2Title { get; set; }
        public string plcResult2Address { get; set; }
        public string plcResult3Title { get; set; }
        public string plcResult3Address { get; set; }
        public double value1 { get; set; }
        public double value2 { get; set; }
        public double value3 { get; set; }
    }
}
