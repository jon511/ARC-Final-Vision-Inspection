using System;
using System.Collections.Generic;
using System.Text;
using Logix;

namespace ARC_Final_Vision_Inspection
{
    class PLCWeightMonitor
    {
        public bool visible { get; set; }
        public bool checkDeltaWeight { get; set; }
        public bool passed { get; set; }
        public bool failed { get; set; }
        public bool plcCommsFailed { get; set; }
        public int goodCount { get; set; }
        public int rejectCount { get; set; }
        public int totalCount { get; set; }
        public float lowLimit { get; set; }
        public float actualWeight { get; set; }
        public float highLimit { get; set; }
        public float deltaWeight { get; set; }
        public string plcLowLimitAddress { get; set; }
        public string plcActualAddress { get; set; }
        public string plcHighLimitAddress { get; set; }
        public string plcDeltaAddress { get; set; }


        public void getWeightFromPLC(string plcIPAddress)
        {
            int numberOfTags = 0;
            Controller myPLC = new Controller();
            myPLC.IPAddress = plcIPAddress;


            Tag[] tag = new Tag[4]{new Tag(), new Tag(), new Tag(), new Tag()};
            tag[0].Name = "OP250LowLimit";
            tag[1].Name = "OP250Actual";
            tag[2].Name = "OP250HighLimit";
            if (checkDeltaWeight)
            {
                tag[3].Name = plcDeltaAddress; 
            }
            

            TagGroup readGroup = new TagGroup();
            
            if (checkDeltaWeight)
                numberOfTags = 4;
            else
                numberOfTags = 3;

            for (int i = 0; i < numberOfTags; i++)
            {
                readGroup.AddTag(tag[i]);
            }

            myPLC.Connect();

            myPLC.GroupRead(readGroup);

            if (myPLC.GroupRead(readGroup) != ResultCode.E_SUCCESS)
            {
                
                return;

            }

            for (int i = 0; i < numberOfTags; i++)
            {
                float incomingFloat = 0;

                if (ResultCode.QUAL_GOOD == tag[i].QualityCode)
                    incomingFloat = (float)tag[i].Value;
                else
                {
                    plcCommsFailed = true;
                    return;
                }

                switch (i)
                {
                    case 0:
                        lowLimit = incomingFloat;
                        break;
                    case 1:
                        actualWeight = incomingFloat;
                        break;
                    case 2:
                        highLimit = incomingFloat;
                        break;

                    default:
                        break;
                }

            }
            myPLC.Disconnect();

            checkWeight();

        }


        private void checkWeight()
        {
            if (checkDeltaWeight)
	        {
		        if (deltaWeight < lowLimit || deltaWeight > highLimit)
	            {
		            rejectCount++;
	            }
                else
	            {
		            goodCount++;
	            }
	        }
            else
            {   
                if (actualWeight < lowLimit || actualWeight > highLimit)
	            {
		            rejectCount++;
	            }
                else
	            {
		            goodCount++;
	            }
            }

            totalCount = goodCount + rejectCount;

        }
        
    }
}
