using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestCapacityControl.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Model { get; set; }
        public string Status { get; set; }

        public double YieldInline = 0.0;
        public double YieldBrdTest = 0.0;
        public double YieldBoardTst = 0.0;
        public double Yield5GFR = 0.0;
        public double YieldDCAL = 0.0;
        public double YieldDVAL = 0.0;
        public double YieldCamCAL = 0.0;
        public double YieldCamVAL = 0.0;
        public double YieldJOT = 0.0;
        public double YieldL2Vision = 0.0;
        public double YieldL2AR= 0.0;
        public double YieldM2Cam = 0.0;
        public double YieldM2AR = 0.0;
        public double YieldJotSlim = 0.0;
        public double YieldARSlim = 0.0;
        public double YieldCFC = 0.0;
        public double YieldPatsJot = 0.0;
        public double YieldPatsM2 = 0.0;
        public double YieldPatsSlim= 0.0;
    }
}
