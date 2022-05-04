using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestCapacityControl.Models
{
    public class ProductUpdateTablet
    {

        public int Id { get; set; }
        public string ProductNameUp { get; set; }
        public double YieldInline { get; set; }
        public double YieldWifi { get; set; }
        public double YieldRFCal { get; set; }
        public double YieldNSFT { get; set; }
        public double YieldRadCurr { get; set; }
        public double YieldTOF { get; set; }
        public double YieldANT { get; set; }
        public double YieldMMI1 { get; set; }
        public double YieldMMI2 { get; set; }
        public double YieldAudio { get; set; }
        public double YieldWriteNumber { get; set; }
        public double YieldCFCUp { get; set; }
        public double YieldMMI3 { get; set; }

        public double NtfInline { get; set; }
        public double NtfWifi { get; set; }
        public double NtfRFCal { get; set; }
        public double NtfNSFT { get; set; }
        public double NtfRadCurr { get; set; }
        public double NtfTOF { get; set; }
        public double NtfANT { get; set; }
        public double NtfMMI1 { get; set; }
        public double NtfMMI2 { get; set; }
        public double NtfAudio { get; set; }
        public double NtfWriteNumber { get; set; }
        public double NtfCFCUp { get; set; }
        public double NtfMMI3 { get; set; }

        public double MTimeInline { get; set; }
        public double MTimeWifi { get; set; }
        public double MTimeRFCal { get; set; }
        public double MTimeNSFT { get; set; }
        public double MTimeRadCurr { get; set; }
        public double MTimeTOF { get; set; }
        public double MTimeANT { get; set; }
        public double MTimeMMI1 { get; set; }
        public double MTimeMMI2 { get; set; }
        public double MTimeAudio { get; set; }
        public double MTimeWriteNumber { get; set; }
        public double MTimeCFCUp { get; set; }
        public double MTimeMMI3 { get; set; }

        public ProductUpdateTablet(string productNameUp, double yieldInline, double yieldWifi, double yieldRFCal, double yieldNSFT, double yieldRadCurr, double yieldTOF, double yieldANT, double yieldMMI1, double yieldMMI2, double yieldAudio, double yieldWriteNumber, double yieldCFCUp, double yieldMMI3, double ntfInline, double ntfWifi, double ntfRFCal, double ntfNSFT, double ntfRadCurr, double ntfTOF, double ntfANT, double ntfMMI1, double ntfMMI2, double ntfAudio, double ntfWriteNumber, double ntfCFCUp, double ntfMMI3, double mTimeInline, double mTimeWifi, double mTimeRFCal, double mTimeNSFT, double mTimeRadCurr, double mTimeTOF, double mTimeANT, double mTimeMMI1, double mTimeMMI2, double mTimeAudio, double mTimeWriteNumber, double mTimeCFCUp, double mTimeMMI3)
        {
            ProductNameUp = productNameUp;
            YieldInline = yieldInline;
            YieldWifi = yieldWifi;
            YieldRFCal = yieldRFCal;
            YieldNSFT = yieldNSFT;
            YieldRadCurr = yieldRadCurr;
            YieldTOF = yieldTOF;
            YieldANT = yieldANT;
            YieldMMI1 = yieldMMI1;
            YieldMMI2 = yieldMMI2;
            YieldAudio = yieldAudio;
            YieldWriteNumber = yieldWriteNumber;
            YieldCFCUp = yieldCFCUp;
            YieldMMI3 = yieldMMI3;
            NtfInline = ntfInline;
            NtfWifi = ntfWifi;
            NtfRFCal = ntfRFCal;
            NtfNSFT = ntfNSFT;
            NtfRadCurr = ntfRadCurr;
            NtfTOF = ntfTOF;
            NtfANT = ntfANT;
            NtfMMI1 = ntfMMI1;
            NtfMMI2 = ntfMMI2;
            NtfAudio = ntfAudio;
            NtfWriteNumber = ntfWriteNumber;
            NtfCFCUp = ntfCFCUp;
            NtfMMI3 = ntfMMI3;
            MTimeInline = mTimeInline;
            MTimeWifi = mTimeWifi;
            MTimeRFCal = mTimeRFCal;
            MTimeNSFT = mTimeNSFT;
            MTimeRadCurr = mTimeRadCurr;
            MTimeTOF = mTimeTOF;
            MTimeANT = mTimeANT;
            MTimeMMI1 = mTimeMMI1;
            MTimeMMI2 = mTimeMMI2;
            MTimeAudio = mTimeAudio;
            MTimeWriteNumber = mTimeWriteNumber;
            MTimeCFCUp = mTimeCFCUp;
            MTimeMMI3 = mTimeMMI3;
        }

        public ProductUpdateTablet()
        {
        }
    }
}
