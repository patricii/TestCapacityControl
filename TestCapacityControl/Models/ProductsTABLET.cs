using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestCapacityControl.Models
{
    public class ProductsTABLET
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Model { get; set; }
        public string Status { get; set; }


        public double YieldInline = 0.0;
        public double YieldWifi = 0.0;
        public double YieldRFCal = 0.0;
        public double YieldNSFT = 0.0;
        public double YieldRadCurr = 0.0;
        public double YieldTOF = 0.0;
        public double YieldANT = 0.0;
        public double YieldMMI1 = 0.0;
        public double YieldMMI2 = 0.0;
        public double YieldAUDIO = 0.0;
        public double YieldWriteNumber = 0.0;
        public double YieldCFCUp = 0.0;
        public double YieldMMI3 = 0.0;

    }
}
