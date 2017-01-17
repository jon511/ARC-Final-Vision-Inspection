using System;
using System.Collections.Generic;
using System.Text;

namespace ARC_Final_Vision_Inspection
{
    public class PLCSetup
    {
        public string ipAddress { get; set; }
        public string displayMessageTitle { get; set; }
        public string displayMessageAddress { get; set; }
        public string displayMessageColorAddress { get; set; }
        public string displayMessageString { get; set; }
        public int displayMessageColor { get; set; }
        public string mainSerialNumberAddress { get; set; }
        public string mainSerialNumberString { get; set; }
        public bool secondaryMessageEnabled { get; set; }
        public string secondaryMessageTitle { get; set; }
        public string secondaryDisplayMessageAddress { get; set; }
        public string secondaryDisplayMessageColorAddress { get; set; }
        public string secondaryDisplayMessageString { get; set; }
        public int secondaryDisplayMessageColor { get; set; }
        public string secondarySerialNumberAddress { get; set; }
        public string secondarySerialNumberString { get; set; }
        public bool communicationEnabled { get; set; }
        public bool manualAutoButtonsEnabled { get; set; }
        public bool resultsEnabled { get; set; }
        public bool secondaryResultsEnabled { get; set; }
        public bool countersEnabled { get; set; }
        public bool secondaryCountersEnabled { get; set; }
        public int controllerType { get; set; }
        public PLCButton autoButton = new PLCButton();
        public PLCButton manualButton = new PLCButton();
        public PLCButton plcButton1 = new PLCButton();
        public PLCButton plcButton2 = new PLCButton();
        public PLCButton plcButton3 = new PLCButton();
        public PLCButton plcButton4 = new PLCButton();
        public PLCButton plcButton5 = new PLCButton();
        public PLCButton plcButton6 = new PLCButton();
        public PLCPartCounter plcPartcounter = new PLCPartCounter();
        public PLCPartCounter plcSecPartCounter = new PLCPartCounter();
        public PLCResults plcResult = new PLCResults();
        public PLCResults plcSecondaryResults = new PLCResults();
        

    }
}
