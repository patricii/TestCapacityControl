using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestCapacityControl.Models
{
    public class TestRatesCelular
    {
        public  int Id{ get; set; }
        public string product { get; set; }
        public double CFCUph { get; set; }
        public double CFCNt { get; set; }
        public double PatsJotUph { get; set; }
        public double PatsM2Uph { get; set; }

        public double JOTSlimUph { get; set; }
        public int JOTSlimPsps { get; set; }
        public int JotSlimSpr { get; set; }
        public double JOTSlimTotalUph { get; set; }
        public double JOTSlimNt { get; set; }

        public double L2ArSlimUph { get; set; }
        public int L2ArSlimFxt { get; set; }
        public int L2ArSlimSpr { get; set; }
        public double L2ArSlimTotalUph { get; set; }
        public double L2ArSlimNt { get; set; }

        public double PATSSlimUph { get; set; }

        public double CAMVALSlimUph { get; set; }
        public int CAMVALSlimFxt { get; set; }
        public int CAMVALSlimSpr { get; set; }
        public double CAMVALSlimTotalUph { get; set; }
        public double CAMVALSlimNt { get; set; }

        public double CAMCALSlimUph { get; set; }
        public int CAMCALSlimFxt { get; set; }
        public int CAMCALSlimSpr { get; set; }
        public double CAMCALSlimTotalUph { get; set; }
        public double CAMCALSlimNt { get; set; }

        public double FODSlimUph { get; set; }
        public int FODSlimFxt { get; set; }
        public int FODSlimSpr { get; set; }
        public double FODSlimTotalUph { get; set; }
        public double FODSlimNt { get; set; }

    }
}
